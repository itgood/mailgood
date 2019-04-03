namespace WindowsFormsApp23
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.metroButton4 = new MetroFramework.Controls.MetroButton();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.ProxyCount = new MetroFramework.Controls.MetroLabel();
			this.Proxy = new MetroFramework.Controls.MetroLabel();
			this.errorcount = new MetroFramework.Controls.MetroLabel();
			this.ostcount = new MetroFramework.Controls.MetroLabel();
			this.badcount = new MetroFramework.Controls.MetroLabel();
			this.goodcount = new MetroFramework.Controls.MetroLabel();
			this.allcount = new MetroFramework.Controls.MetroLabel();
			this.error = new MetroFramework.Controls.MetroLabel();
			this.remainder = new MetroFramework.Controls.MetroLabel();
			this.bad = new MetroFramework.Controls.MetroLabel();
			this.good = new MetroFramework.Controls.MetroLabel();
			this.all = new MetroFramework.Controls.MetroLabel();
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
			this.metroButton3 = new MetroFramework.Controls.MetroButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.metroPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.metroButton4);
			this.groupBox1.Controls.Add(this.metroButton2);
			this.groupBox1.Controls.Add(this.metroButton1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.groupBox1.ForeColor = System.Drawing.Color.Snow;
			this.groupBox1.Location = new System.Drawing.Point(5, 63);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(198, 110);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Загрузить";
			// 
			// metroButton4
			// 
			this.metroButton4.Location = new System.Drawing.Point(3, 74);
			this.metroButton4.Name = "metroButton4";
			this.metroButton4.Size = new System.Drawing.Size(124, 21);
			this.metroButton4.TabIndex = 2;
			this.metroButton4.Text = "Старт";
			this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroButton4.UseSelectable = true;
			this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
			// 
			// metroButton2
			// 
			this.metroButton2.Location = new System.Drawing.Point(6, 47);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(121, 21);
			this.metroButton2.TabIndex = 1;
			this.metroButton2.Text = "Прокси";
			this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroButton2.UseSelectable = true;
			this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(7, 20);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(120, 21);
			this.metroButton1.TabIndex = 0;
			this.metroButton1.Text = "Базу";
			this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.metroLabel2);
			this.groupBox2.Controls.Add(this.metroTextBox1);
			this.groupBox2.Controls.Add(this.metroLabel1);
			this.groupBox2.Controls.Add(this.metroComboBox1);
			this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.groupBox2.Location = new System.Drawing.Point(5, 179);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(198, 104);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Настройки";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(100, 59);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(53, 19);
			this.metroLabel2.TabIndex = 3;
			this.metroLabel2.Text = "Потоки";
			this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// metroTextBox1
			// 
			// 
			// 
			// 
			this.metroTextBox1.CustomButton.Image = null;
			this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(67, 1);
			this.metroTextBox1.CustomButton.Name = "";
			this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.metroTextBox1.CustomButton.TabIndex = 1;
			this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.metroTextBox1.CustomButton.UseSelectable = true;
			this.metroTextBox1.CustomButton.Visible = false;
			this.metroTextBox1.Lines = new string[] {
        "1"};
			this.metroTextBox1.Location = new System.Drawing.Point(7, 55);
			this.metroTextBox1.MaxLength = 32767;
			this.metroTextBox1.Name = "metroTextBox1";
			this.metroTextBox1.PasswordChar = '\0';
			this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.metroTextBox1.SelectedText = "";
			this.metroTextBox1.SelectionLength = 0;
			this.metroTextBox1.SelectionStart = 0;
			this.metroTextBox1.ShortcutsEnabled = true;
			this.metroTextBox1.Size = new System.Drawing.Size(89, 23);
			this.metroTextBox1.TabIndex = 1;
			this.metroTextBox1.Text = "1";
			this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroTextBox1.UseSelectable = true;
			this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.metroTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.metroLabel1.Location = new System.Drawing.Point(102, 29);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(80, 19);
			this.metroLabel1.TabIndex = 2;
			this.metroLabel1.Text = "Тип прокси";
			this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// metroComboBox1
			// 
			this.metroComboBox1.FormattingEnabled = true;
			this.metroComboBox1.ItemHeight = 23;
			this.metroComboBox1.Location = new System.Drawing.Point(6, 19);
			this.metroComboBox1.Name = "metroComboBox1";
			this.metroComboBox1.Size = new System.Drawing.Size(90, 29);
			this.metroComboBox1.TabIndex = 0;
			this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroComboBox1.UseSelectable = true;
			this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.ProxyCount);
			this.groupBox3.Controls.Add(this.Proxy);
			this.groupBox3.Controls.Add(this.errorcount);
			this.groupBox3.Controls.Add(this.ostcount);
			this.groupBox3.Controls.Add(this.badcount);
			this.groupBox3.Controls.Add(this.goodcount);
			this.groupBox3.Controls.Add(this.allcount);
			this.groupBox3.Controls.Add(this.error);
			this.groupBox3.Controls.Add(this.remainder);
			this.groupBox3.Controls.Add(this.bad);
			this.groupBox3.Controls.Add(this.good);
			this.groupBox3.Controls.Add(this.all);
			this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.groupBox3.Location = new System.Drawing.Point(5, 289);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(198, 140);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Результат";
			// 
			// ProxyCount
			// 
			this.ProxyCount.AutoSize = true;
			this.ProxyCount.Location = new System.Drawing.Point(69, 115);
			this.ProxyCount.Name = "ProxyCount";
			this.ProxyCount.Size = new System.Drawing.Size(16, 19);
			this.ProxyCount.TabIndex = 11;
			this.ProxyCount.Text = "0";
			this.ProxyCount.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// Proxy
			// 
			this.Proxy.AutoSize = true;
			this.Proxy.Location = new System.Drawing.Point(3, 115);
			this.Proxy.Name = "Proxy";
			this.Proxy.Size = new System.Drawing.Size(54, 19);
			this.Proxy.TabIndex = 10;
			this.Proxy.Text = "Прокси";
			this.Proxy.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// errorcount
			// 
			this.errorcount.AutoSize = true;
			this.errorcount.Location = new System.Drawing.Point(69, 92);
			this.errorcount.Name = "errorcount";
			this.errorcount.Size = new System.Drawing.Size(16, 19);
			this.errorcount.TabIndex = 9;
			this.errorcount.Text = "0";
			this.errorcount.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// ostcount
			// 
			this.ostcount.AutoSize = true;
			this.ostcount.Location = new System.Drawing.Point(69, 72);
			this.ostcount.Name = "ostcount";
			this.ostcount.Size = new System.Drawing.Size(16, 19);
			this.ostcount.TabIndex = 8;
			this.ostcount.Text = "0";
			this.ostcount.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// badcount
			// 
			this.badcount.AutoSize = true;
			this.badcount.Location = new System.Drawing.Point(70, 54);
			this.badcount.Name = "badcount";
			this.badcount.Size = new System.Drawing.Size(16, 19);
			this.badcount.TabIndex = 7;
			this.badcount.Text = "0";
			this.badcount.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// goodcount
			// 
			this.goodcount.AutoSize = true;
			this.goodcount.Location = new System.Drawing.Point(69, 34);
			this.goodcount.Name = "goodcount";
			this.goodcount.Size = new System.Drawing.Size(16, 19);
			this.goodcount.TabIndex = 6;
			this.goodcount.Text = "0";
			this.goodcount.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// allcount
			// 
			this.allcount.AutoSize = true;
			this.allcount.Location = new System.Drawing.Point(70, 15);
			this.allcount.Name = "allcount";
			this.allcount.Size = new System.Drawing.Size(16, 19);
			this.allcount.TabIndex = 5;
			this.allcount.Text = "0";
			this.allcount.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// error
			// 
			this.error.AutoSize = true;
			this.error.Location = new System.Drawing.Point(3, 92);
			this.error.Name = "error";
			this.error.Size = new System.Drawing.Size(61, 19);
			this.error.TabIndex = 4;
			this.error.Text = "Ошибки";
			this.error.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// remainder
			// 
			this.remainder.AutoSize = true;
			this.remainder.Location = new System.Drawing.Point(3, 73);
			this.remainder.Name = "remainder";
			this.remainder.Size = new System.Drawing.Size(57, 19);
			this.remainder.TabIndex = 3;
			this.remainder.Text = "Остаток";
			this.remainder.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// bad
			// 
			this.bad.AutoSize = true;
			this.bad.Location = new System.Drawing.Point(3, 54);
			this.bad.Name = "bad";
			this.bad.Size = new System.Drawing.Size(53, 19);
			this.bad.TabIndex = 2;
			this.bad.Text = "Плохих";
			this.bad.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// good
			// 
			this.good.AutoSize = true;
			this.good.Location = new System.Drawing.Point(3, 35);
			this.good.Name = "good";
			this.good.Size = new System.Drawing.Size(66, 19);
			this.good.TabIndex = 1;
			this.good.Text = "Хороших";
			this.good.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// all
			// 
			this.all.AutoSize = true;
			this.all.Location = new System.Drawing.Point(3, 16);
			this.all.Name = "all";
			this.all.Size = new System.Drawing.Size(43, 19);
			this.all.TabIndex = 0;
			this.all.Text = "Всего";
			this.all.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// metroPanel1
			// 
			this.metroPanel1.Controls.Add(this.metroGrid1);
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new System.Drawing.Point(209, 63);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new System.Drawing.Size(512, 323);
			this.metroPanel1.TabIndex = 3;
			this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			// 
			// metroGrid1
			// 
			this.metroGrid1.AllowUserToResizeRows = false;
			this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
			this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroGrid1.EnableHeadersVisualStyles = false;
			this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.metroGrid1.Location = new System.Drawing.Point(0, 0);
			this.metroGrid1.Name = "metroGrid1";
			this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.metroGrid1.Size = new System.Drawing.Size(512, 323);
			this.metroGrid1.TabIndex = 2;
			this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// metroButton3
			// 
			this.metroButton3.Location = new System.Drawing.Point(531, 8);
			this.metroButton3.Name = "metroButton3";
			this.metroButton3.Size = new System.Drawing.Size(75, 23);
			this.metroButton3.TabIndex = 4;
			this.metroButton3.Text = "metroButton3";
			this.metroButton3.UseSelectable = true;
			this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(735, 452);
			this.Controls.Add(this.metroButton3);
			this.Controls.Add(this.metroPanel1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.metroPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private MetroFramework.Controls.MetroButton metroButton1;
		private MetroFramework.Controls.MetroButton metroButton2;
		private System.Windows.Forms.GroupBox groupBox2;
		private MetroFramework.Controls.MetroComboBox metroComboBox1;
		private MetroFramework.Controls.MetroTextBox metroTextBox1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.GroupBox groupBox3;
		private MetroFramework.Controls.MetroLabel error;
		private MetroFramework.Controls.MetroLabel remainder;
		private MetroFramework.Controls.MetroLabel bad;
		private MetroFramework.Controls.MetroLabel good;
		private MetroFramework.Controls.MetroLabel all;
		private MetroFramework.Controls.MetroPanel metroPanel1;
		private MetroFramework.Controls.MetroGrid metroGrid1;
		private MetroFramework.Controls.MetroLabel errorcount;
		private MetroFramework.Controls.MetroLabel ostcount;
		private MetroFramework.Controls.MetroLabel badcount;
		private MetroFramework.Controls.MetroLabel goodcount;
		private MetroFramework.Controls.MetroLabel allcount;
		private MetroFramework.Controls.MetroButton metroButton3;
		private MetroFramework.Controls.MetroButton metroButton4;
		private MetroFramework.Controls.MetroLabel ProxyCount;
		private MetroFramework.Controls.MetroLabel Proxy;
	}
}

