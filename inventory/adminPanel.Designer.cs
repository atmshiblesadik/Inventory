namespace inventory
{
    partial class adminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPanel));
            this.admin_panel = new System.Windows.Forms.Panel();
            this.buttonInformation = new System.Windows.Forms.Button();
            this.buttonAccounnt = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonDailySell = new System.Windows.Forms.Button();
            this.buttonWorkers = new System.Windows.Forms.Button();
            this.buttonDailyConsumption = new System.Windows.Forms.Button();
            this.admin_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // admin_panel
            // 
            this.admin_panel.BackColor = System.Drawing.Color.Transparent;
            this.admin_panel.Controls.Add(this.buttonInformation);
            this.admin_panel.Controls.Add(this.buttonAccounnt);
            this.admin_panel.Controls.Add(this.buttonOrder);
            this.admin_panel.Controls.Add(this.buttonDailySell);
            this.admin_panel.Controls.Add(this.buttonWorkers);
            this.admin_panel.Controls.Add(this.buttonDailyConsumption);
            this.admin_panel.Location = new System.Drawing.Point(23, 91);
            this.admin_panel.Name = "admin_panel";
            this.admin_panel.Size = new System.Drawing.Size(847, 554);
            this.admin_panel.TabIndex = 7;
            // 
            // buttonInformation
            // 
            this.buttonInformation.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonInformation.FlatAppearance.BorderSize = 0;
            this.buttonInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInformation.ForeColor = System.Drawing.Color.Black;
            this.buttonInformation.Image = ((System.Drawing.Image)(resources.GetObject("buttonInformation.Image")));
            this.buttonInformation.Location = new System.Drawing.Point(601, 85);
            this.buttonInformation.Name = "buttonInformation";
            this.buttonInformation.Size = new System.Drawing.Size(153, 272);
            this.buttonInformation.TabIndex = 10;
            this.buttonInformation.Text = "তথ্য";
            this.buttonInformation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonInformation.UseVisualStyleBackColor = false;
            this.buttonInformation.Click += new System.EventHandler(this.buttonInformation_Click);
            // 
            // buttonAccounnt
            // 
            this.buttonAccounnt.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAccounnt.FlatAppearance.BorderSize = 0;
            this.buttonAccounnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccounnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccounnt.ForeColor = System.Drawing.Color.Black;
            this.buttonAccounnt.Image = ((System.Drawing.Image)(resources.GetObject("buttonAccounnt.Image")));
            this.buttonAccounnt.Location = new System.Drawing.Point(435, 85);
            this.buttonAccounnt.Name = "buttonAccounnt";
            this.buttonAccounnt.Size = new System.Drawing.Size(136, 128);
            this.buttonAccounnt.TabIndex = 9;
            this.buttonAccounnt.Text = "হিসাব";
            this.buttonAccounnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAccounnt.UseVisualStyleBackColor = false;
            this.buttonAccounnt.Click += new System.EventHandler(this.buttonAccounnt_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonOrder.FlatAppearance.BorderSize = 0;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder.ForeColor = System.Drawing.Color.Black;
            this.buttonOrder.Image = ((System.Drawing.Image)(resources.GetObject("buttonOrder.Image")));
            this.buttonOrder.Location = new System.Drawing.Point(271, 85);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(136, 128);
            this.buttonOrder.TabIndex = 8;
            this.buttonOrder.Text = "ওয়ার্ডার";
            this.buttonOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonDailySell
            // 
            this.buttonDailySell.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonDailySell.FlatAppearance.BorderSize = 0;
            this.buttonDailySell.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDailySell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDailySell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDailySell.ForeColor = System.Drawing.Color.Black;
            this.buttonDailySell.Image = ((System.Drawing.Image)(resources.GetObject("buttonDailySell.Image")));
            this.buttonDailySell.Location = new System.Drawing.Point(108, 85);
            this.buttonDailySell.Name = "buttonDailySell";
            this.buttonDailySell.Size = new System.Drawing.Size(136, 128);
            this.buttonDailySell.TabIndex = 7;
            this.buttonDailySell.Text = "প্রতিদিনের বিক্রি";
            this.buttonDailySell.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDailySell.UseVisualStyleBackColor = false;
            this.buttonDailySell.Click += new System.EventHandler(this.buttonDailySell_Click);
            // 
            // buttonWorkers
            // 
            this.buttonWorkers.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonWorkers.FlatAppearance.BorderSize = 0;
            this.buttonWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWorkers.ForeColor = System.Drawing.Color.Black;
            this.buttonWorkers.Image = ((System.Drawing.Image)(resources.GetObject("buttonWorkers.Image")));
            this.buttonWorkers.Location = new System.Drawing.Point(271, 229);
            this.buttonWorkers.Name = "buttonWorkers";
            this.buttonWorkers.Size = new System.Drawing.Size(300, 128);
            this.buttonWorkers.TabIndex = 6;
            this.buttonWorkers.Text = "কর্মচারী";
            this.buttonWorkers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonWorkers.UseVisualStyleBackColor = false;
            this.buttonWorkers.Click += new System.EventHandler(this.buttonWorkers_Click);
            // 
            // buttonDailyConsumption
            // 
            this.buttonDailyConsumption.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonDailyConsumption.FlatAppearance.BorderSize = 0;
            this.buttonDailyConsumption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDailyConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDailyConsumption.ForeColor = System.Drawing.Color.Black;
            this.buttonDailyConsumption.Image = ((System.Drawing.Image)(resources.GetObject("buttonDailyConsumption.Image")));
            this.buttonDailyConsumption.Location = new System.Drawing.Point(108, 229);
            this.buttonDailyConsumption.Name = "buttonDailyConsumption";
            this.buttonDailyConsumption.Size = new System.Drawing.Size(136, 128);
            this.buttonDailyConsumption.TabIndex = 5;
            this.buttonDailyConsumption.Text = "প্রতিদিনের খরচ";
            this.buttonDailyConsumption.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDailyConsumption.UseVisualStyleBackColor = false;
            this.buttonDailyConsumption.Click += new System.EventHandler(this.buttonDailyConsumption_Click);
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.admin_panel);
            this.Name = "adminPanel";
            this.Text = "মূল পাতা";
            this.Load += new System.EventHandler(this.adminPanel_Load);
            this.admin_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel admin_panel;
        private System.Windows.Forms.Button buttonAccounnt;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonDailySell;
        private System.Windows.Forms.Button buttonWorkers;
        private System.Windows.Forms.Button buttonDailyConsumption;
        private System.Windows.Forms.Button buttonInformation;
    }
}