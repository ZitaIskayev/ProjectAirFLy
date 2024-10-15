namespace ProjectAirFly
{
    partial class Form2
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
            this.rdOneWay = new System.Windows.Forms.RadioButton();
            this.rdGoBack = new System.Windows.Forms.RadioButton();
            this.lblMakor = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.date2 = new System.Windows.Forms.MonthCalendar();
            this.date1 = new System.Windows.Forms.MonthCalendar();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.lblYaad = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.cmbYaad = new System.Windows.Forms.ComboBox();
            this.cmbMakor = new System.Windows.Forms.ComboBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.btnCheak1 = new System.Windows.Forms.Button();
            this.lblMetayel = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdOneWay
            // 
            this.rdOneWay.AutoSize = true;
            this.rdOneWay.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdOneWay.Location = new System.Drawing.Point(12, 290);
            this.rdOneWay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdOneWay.Name = "rdOneWay";
            this.rdOneWay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdOneWay.Size = new System.Drawing.Size(96, 26);
            this.rdOneWay.TabIndex = 0;
            this.rdOneWay.TabStop = true;
            this.rdOneWay.Text = "כיוון אחד";
            this.rdOneWay.UseVisualStyleBackColor = true;
            this.rdOneWay.CheckedChanged += new System.EventHandler(this.rdOneWay_CheckedChanged_1);
            // 
            // rdGoBack
            // 
            this.rdGoBack.AutoSize = true;
            this.rdGoBack.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGoBack.Location = new System.Drawing.Point(181, 290);
            this.rdGoBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdGoBack.Name = "rdGoBack";
            this.rdGoBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdGoBack.Size = new System.Drawing.Size(102, 26);
            this.rdGoBack.TabIndex = 1;
            this.rdGoBack.TabStop = true;
            this.rdGoBack.Text = "הלוך-חזור";
            this.rdGoBack.UseVisualStyleBackColor = true;
            this.rdGoBack.CheckedChanged += new System.EventHandler(this.rdGoBack_CheckedChanged);
            // 
            // lblMakor
            // 
            this.lblMakor.AutoSize = true;
            this.lblMakor.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakor.Location = new System.Drawing.Point(188, 171);
            this.lblMakor.Name = "lblMakor";
            this.lblMakor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMakor.Size = new System.Drawing.Size(50, 22);
            this.lblMakor.TabIndex = 2;
            this.lblMakor.Text = "מקור ";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(860, 487);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClear.Size = new System.Drawing.Size(85, 52);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "נקה";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // date2
            // 
            this.date2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.Location = new System.Drawing.Point(366, 206);
            this.date2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.date2.Name = "date2";
            this.date2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.date2.TabIndex = 4;
            this.date2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.date2_DateChanged);
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.Location = new System.Drawing.Point(669, 206);
            this.date1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.date1.Name = "date1";
            this.date1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.date1.TabIndex = 5;
            this.date1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.date1_DateChanged);
            // 
            // btnNext1
            // 
            this.btnNext1.Enabled = false;
            this.btnNext1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext1.Location = new System.Drawing.Point(366, 487);
            this.btnNext1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNext1.Size = new System.Drawing.Size(85, 52);
            this.btnNext1.TabIndex = 6;
            this.btnNext1.Text = "המשך";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // lblYaad
            // 
            this.lblYaad.AutoSize = true;
            this.lblYaad.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYaad.Location = new System.Drawing.Point(204, 227);
            this.lblYaad.Name = "lblYaad";
            this.lblYaad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblYaad.Size = new System.Drawing.Size(34, 22);
            this.lblYaad.TabIndex = 8;
            this.lblYaad.Text = "יעד";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(830, 159);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStartDate.Size = new System.Drawing.Size(104, 22);
            this.lblStartDate.TabIndex = 9;
            this.lblStartDate.Text = "תאריך יציאה";
            this.lblStartDate.Click += new System.EventHandler(this.lblFromBack_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(524, 159);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEndDate.Size = new System.Drawing.Size(98, 22);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "תאריך חזרה";
            this.lblEndDate.Click += new System.EventHandler(this.lblToBack_Click);
            // 
            // cmbYaad
            // 
            this.cmbYaad.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYaad.FormattingEnabled = true;
            this.cmbYaad.Items.AddRange(new object[] {
            "תל אביב TLV",
            "מיקונוס JMK",
            "ברצלונה BCN",
            "זנזיבר ZNZ"});
            this.cmbYaad.Location = new System.Drawing.Point(33, 224);
            this.cmbYaad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbYaad.Name = "cmbYaad";
            this.cmbYaad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbYaad.Size = new System.Drawing.Size(141, 30);
            this.cmbYaad.TabIndex = 11;
            this.cmbYaad.SelectedIndexChanged += new System.EventHandler(this.cmbYaad_SelectedIndexChanged);
            // 
            // cmbMakor
            // 
            this.cmbMakor.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMakor.FormattingEnabled = true;
            this.cmbMakor.Items.AddRange(new object[] {
            "תל אביב TLV",
            "מיקונוס JMK",
            "ברצלונה BCN",
            "זנזיבר ZNZ"});
            this.cmbMakor.Location = new System.Drawing.Point(33, 163);
            this.cmbMakor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMakor.Name = "cmbMakor";
            this.cmbMakor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbMakor.Size = new System.Drawing.Size(141, 30);
            this.cmbMakor.TabIndex = 12;
            this.cmbMakor.SelectedIndexChanged += new System.EventHandler(this.cmbMakor_SelectedIndexChanged);
            // 
            // txtEndDate
            // 
            this.txtEndDate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndDate.Location = new System.Drawing.Point(366, 159);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEndDate.Size = new System.Drawing.Size(126, 30);
            this.txtEndDate.TabIndex = 13;
            this.txtEndDate.TextChanged += new System.EventHandler(this.txtEndDate_TextChanged);
            // 
            // txtStartDate
            // 
            this.txtStartDate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDate.Location = new System.Drawing.Point(669, 159);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStartDate.Size = new System.Drawing.Size(122, 30);
            this.txtStartDate.TabIndex = 14;
            this.txtStartDate.TextChanged += new System.EventHandler(this.txtStartDate_TextChanged);
            // 
            // btnCheak1
            // 
            this.btnCheak1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheak1.Location = new System.Drawing.Point(605, 485);
            this.btnCheak1.Name = "btnCheak1";
            this.btnCheak1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCheak1.Size = new System.Drawing.Size(85, 54);
            this.btnCheak1.TabIndex = 15;
            this.btnCheak1.Text = "בדיקה";
            this.btnCheak1.UseVisualStyleBackColor = true;
            this.btnCheak1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMetayel
            // 
            this.lblMetayel.AutoSize = true;
            this.lblMetayel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMetayel.Location = new System.Drawing.Point(12, 344);
            this.lblMetayel.Name = "lblMetayel";
            this.lblMetayel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMetayel.Size = new System.Drawing.Size(275, 110);
            this.lblMetayel.TabIndex = 17;
            this.lblMetayel.Text = "באתר למייטל תוכל/י למצוא מידע על \r\nמקומות שאסור לפספס \r\nביעד שאליו תרצה/י לטוס \r\n" +
    "וגם תוכל/י לעשות ביטוח נסיעות \r\n(בתשלום נוסף)";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold);
            this.linkLabel2.Location = new System.Drawing.Point(29, 466);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(244, 22);
            this.linkLabel2.TabIndex = 18;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://www.lametayel.co.il/";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = global::ProjectAirFly.Properties.Resources.לוגו_פרויקט;
            this.pictureBox1.Image = global::ProjectAirFly.Properties.Resources.לוגו_פרויקט;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectAirFly.Properties.Resources.יעדיםם;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.lblMetayel);
            this.Controls.Add(this.btnCheak1);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.cmbMakor);
            this.Controls.Add(this.cmbYaad);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblYaad);
            this.Controls.Add(this.btnNext1);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblMakor);
            this.Controls.Add(this.rdGoBack);
            this.Controls.Add(this.rdOneWay);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "כרטיס טיסה";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdOneWay;
        private System.Windows.Forms.RadioButton rdGoBack;
        private System.Windows.Forms.Label lblMakor;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MonthCalendar date2;
        private System.Windows.Forms.MonthCalendar date1;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Label lblYaad;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.ComboBox cmbYaad;
        private System.Windows.Forms.ComboBox cmbMakor;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Button btnCheak1;
        private System.Windows.Forms.Label lblMetayel;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}