namespace inventory
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.login_panel = new System.Windows.Forms.Panel();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.username = new MetroFramework.Controls.MetroTextBox();
            this.login_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_panel
            // 
            this.login_panel.Controls.Add(this.loginButton);
            this.login_panel.Controls.Add(this.password);
            this.login_panel.Controls.Add(this.username);
            this.login_panel.Location = new System.Drawing.Point(23, 123);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(847, 554);
            this.login_panel.TabIndex = 0;
            this.login_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.login_panel_Paint);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.SkyBlue;
            this.loginButton.DisplayFocus = true;
            this.loginButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.loginButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.loginButton.Location = new System.Drawing.Point(326, 248);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(193, 37);
            this.loginButton.Style = MetroFramework.MetroColorStyle.White;
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginButton.UseCustomBackColor = true;
            this.loginButton.UseCustomForeColor = true;
            this.loginButton.UseSelectable = true;
            this.loginButton.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // password
            // 
            // 
            // 
            // 
            this.password.CustomButton.AutoSize = true;
            this.password.CustomButton.Image = null;
            this.password.CustomButton.Location = new System.Drawing.Point(160, 2);
            this.password.CustomButton.Name = "";
            this.password.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.CustomButton.TabIndex = 1;
            this.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.CustomButton.UseSelectable = true;
            this.password.CustomButton.Visible = false;
            this.password.DisplayIcon = true;
            this.password.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.password.Icon = ((System.Drawing.Image)(resources.GetObject("password.Icon")));
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(325, 173);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.PromptText = "পাসওয়ার্ড";
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.ShortcutsEnabled = true;
            this.password.Size = new System.Drawing.Size(194, 36);
            this.password.TabIndex = 4;
            this.password.UseSelectable = true;
            this.password.WaterMark = "পাসওয়ার্ড";
            this.password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.password.Click += new System.EventHandler(this.metroTextBox2_Click_1);
            // 
            // username
            // 
            // 
            // 
            // 
            this.username.CustomButton.AutoSize = true;
            this.username.CustomButton.Image = null;
            this.username.CustomButton.Location = new System.Drawing.Point(160, 2);
            this.username.CustomButton.Name = "";
            this.username.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.username.CustomButton.TabIndex = 1;
            this.username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.username.CustomButton.UseSelectable = true;
            this.username.CustomButton.Visible = false;
            this.username.DisplayIcon = true;
            this.username.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.username.Icon = ((System.Drawing.Image)(resources.GetObject("username.Icon")));
            this.username.Lines = new string[0];
            this.username.Location = new System.Drawing.Point(325, 83);
            this.username.MaxLength = 32767;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PromptText = "ব্যবহারকারীর নাম";
            this.username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.username.SelectedText = "";
            this.username.SelectionLength = 0;
            this.username.SelectionStart = 0;
            this.username.ShortcutsEnabled = true;
            this.username.Size = new System.Drawing.Size(194, 36);
            this.username.Style = MetroFramework.MetroColorStyle.Green;
            this.username.TabIndex = 3;
            this.username.UseSelectable = true;
            this.username.WaterMark = "ব্যবহারকারীর নাম";
            this.username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.username.Click += new System.EventHandler(this.metroTextBox1_Click_3);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.login_panel);
            this.Name = "login";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "প্রবেশ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.login_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel login_panel;
        private MetroFramework.Controls.MetroButton loginButton;
        private MetroFramework.Controls.MetroTextBox password;
        private MetroFramework.Controls.MetroTextBox username;
    }
}

