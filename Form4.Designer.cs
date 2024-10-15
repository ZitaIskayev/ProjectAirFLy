namespace ProjectAirFly
{
    partial class Form4
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
            this.btnNext3 = new System.Windows.Forms.Button();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.grpDrink = new System.Windows.Forms.GroupBox();
            this.rdHotDrink = new System.Windows.Forms.RadioButton();
            this.rdAlcoholDrink = new System.Windows.Forms.RadioButton();
            this.rdSahootDrink = new System.Windows.Forms.RadioButton();
            this.rdKalDrink = new System.Windows.Forms.RadioButton();
            this.grpMeal = new System.Windows.Forms.GroupBox();
            this.rdKosher = new System.Windows.Forms.RadioButton();
            this.rdDairy = new System.Windows.Forms.RadioButton();
            this.rdVegi = new System.Windows.Forms.RadioButton();
            this.rdMeat = new System.Windows.Forms.RadioButton();
            this.btnCheck3 = new System.Windows.Forms.Button();
            this.lblEara1 = new System.Windows.Forms.Label();
            this.lblEara2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpDrink.SuspendLayout();
            this.grpMeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext3
            // 
            this.btnNext3.AutoSize = true;
            this.btnNext3.Enabled = false;
            this.btnNext3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext3.Location = new System.Drawing.Point(229, 464);
            this.btnNext3.Name = "btnNext3";
            this.btnNext3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNext3.Size = new System.Drawing.Size(75, 53);
            this.btnNext3.TabIndex = 0;
            this.btnNext3.Text = "הבא";
            this.btnNext3.UseVisualStyleBackColor = true;
            this.btnNext3.Click += new System.EventHandler(this.btnNext3_Click);
            // 
            // btnBack2
            // 
            this.btnBack2.AutoSize = true;
            this.btnBack2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack2.Location = new System.Drawing.Point(641, 464);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBack2.Size = new System.Drawing.Size(75, 53);
            this.btnBack2.TabIndex = 8;
            this.btnBack2.Text = "הקודם";
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // grpDrink
            // 
            this.grpDrink.Controls.Add(this.rdHotDrink);
            this.grpDrink.Controls.Add(this.rdAlcoholDrink);
            this.grpDrink.Controls.Add(this.rdSahootDrink);
            this.grpDrink.Controls.Add(this.rdKalDrink);
            this.grpDrink.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDrink.Location = new System.Drawing.Point(469, 231);
            this.grpDrink.Name = "grpDrink";
            this.grpDrink.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpDrink.Size = new System.Drawing.Size(247, 187);
            this.grpDrink.TabIndex = 20;
            this.grpDrink.TabStop = false;
            this.grpDrink.Text = "משקאות";
            // 
            // rdHotDrink
            // 
            this.rdHotDrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdHotDrink.AutoSize = true;
            this.rdHotDrink.Location = new System.Drawing.Point(81, 31);
            this.rdHotDrink.Name = "rdHotDrink";
            this.rdHotDrink.Size = new System.Drawing.Size(137, 26);
            this.rdHotDrink.TabIndex = 8;
            this.rdHotDrink.TabStop = true;
            this.rdHotDrink.Text = "משקאות חמים";
            this.rdHotDrink.UseVisualStyleBackColor = true;
            this.rdHotDrink.CheckedChanged += new System.EventHandler(this.rdHotDrink_CheckedChanged);
            // 
            // rdAlcoholDrink
            // 
            this.rdAlcoholDrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdAlcoholDrink.AutoSize = true;
            this.rdAlcoholDrink.Location = new System.Drawing.Point(38, 130);
            this.rdAlcoholDrink.Name = "rdAlcoholDrink";
            this.rdAlcoholDrink.Size = new System.Drawing.Size(180, 26);
            this.rdAlcoholDrink.TabIndex = 7;
            this.rdAlcoholDrink.TabStop = true;
            this.rdAlcoholDrink.Text = "משקאות אלכוהוליים";
            this.rdAlcoholDrink.UseVisualStyleBackColor = true;
            this.rdAlcoholDrink.CheckedChanged += new System.EventHandler(this.rdAlcoholDrink_CheckedChanged);
            // 
            // rdSahootDrink
            // 
            this.rdSahootDrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdSahootDrink.AutoSize = true;
            this.rdSahootDrink.Location = new System.Drawing.Point(64, 98);
            this.rdSahootDrink.Name = "rdSahootDrink";
            this.rdSahootDrink.Size = new System.Drawing.Size(154, 26);
            this.rdSahootDrink.TabIndex = 6;
            this.rdSahootDrink.TabStop = true;
            this.rdSahootDrink.Text = "משקאות סחוטים";
            this.rdSahootDrink.UseVisualStyleBackColor = true;
            this.rdSahootDrink.CheckedChanged += new System.EventHandler(this.rdSahootDrink_CheckedChanged);
            // 
            // rdKalDrink
            // 
            this.rdKalDrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdKalDrink.AutoSize = true;
            this.rdKalDrink.Location = new System.Drawing.Point(83, 66);
            this.rdKalDrink.Name = "rdKalDrink";
            this.rdKalDrink.Size = new System.Drawing.Size(135, 26);
            this.rdKalDrink.TabIndex = 5;
            this.rdKalDrink.TabStop = true;
            this.rdKalDrink.Text = "משקאות קלים";
            this.rdKalDrink.UseVisualStyleBackColor = true;
            this.rdKalDrink.CheckedChanged += new System.EventHandler(this.rdKalDrink_CheckedChanged);
            // 
            // grpMeal
            // 
            this.grpMeal.Controls.Add(this.rdKosher);
            this.grpMeal.Controls.Add(this.rdDairy);
            this.grpMeal.Controls.Add(this.rdVegi);
            this.grpMeal.Controls.Add(this.rdMeat);
            this.grpMeal.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMeal.Location = new System.Drawing.Point(183, 231);
            this.grpMeal.Name = "grpMeal";
            this.grpMeal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpMeal.Size = new System.Drawing.Size(242, 187);
            this.grpMeal.TabIndex = 19;
            this.grpMeal.TabStop = false;
            this.grpMeal.Text = "ארוחות";
            // 
            // rdKosher
            // 
            this.rdKosher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdKosher.AutoSize = true;
            this.rdKosher.Location = new System.Drawing.Point(94, 31);
            this.rdKosher.Name = "rdKosher";
            this.rdKosher.Size = new System.Drawing.Size(125, 26);
            this.rdKosher.TabIndex = 3;
            this.rdKosher.TabStop = true;
            this.rdKosher.Text = "ארוחה כשרה";
            this.rdKosher.UseVisualStyleBackColor = true;
            this.rdKosher.CheckedChanged += new System.EventHandler(this.rdKosher_CheckedChanged);
            // 
            // rdDairy
            // 
            this.rdDairy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdDairy.AutoSize = true;
            this.rdDairy.Location = new System.Drawing.Point(89, 63);
            this.rdDairy.Name = "rdDairy";
            this.rdDairy.Size = new System.Drawing.Size(130, 26);
            this.rdDairy.TabIndex = 2;
            this.rdDairy.TabStop = true;
            this.rdDairy.Text = "ארוחה חלבית";
            this.rdDairy.UseVisualStyleBackColor = true;
            this.rdDairy.CheckedChanged += new System.EventHandler(this.rdDairy_CheckedChanged);
            // 
            // rdVegi
            // 
            this.rdVegi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdVegi.AutoSize = true;
            this.rdVegi.Location = new System.Drawing.Point(75, 130);
            this.rdVegi.Name = "rdVegi";
            this.rdVegi.Size = new System.Drawing.Size(144, 26);
            this.rdVegi.TabIndex = 1;
            this.rdVegi.TabStop = true;
            this.rdVegi.Text = "ארוחה צמחונית";
            this.rdVegi.UseVisualStyleBackColor = true;
            this.rdVegi.CheckedChanged += new System.EventHandler(this.rdVegi_CheckedChanged);
            // 
            // rdMeat
            // 
            this.rdMeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdMeat.AutoSize = true;
            this.rdMeat.Location = new System.Drawing.Point(83, 98);
            this.rdMeat.Name = "rdMeat";
            this.rdMeat.Size = new System.Drawing.Size(136, 26);
            this.rdMeat.TabIndex = 0;
            this.rdMeat.TabStop = true;
            this.rdMeat.Text = "ארוחה בשרית ";
            this.rdMeat.UseVisualStyleBackColor = true;
            this.rdMeat.CheckedChanged += new System.EventHandler(this.rdMeat_CheckedChanged);
            // 
            // btnCheck3
            // 
            this.btnCheck3.AutoSize = true;
            this.btnCheck3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck3.Location = new System.Drawing.Point(452, 464);
            this.btnCheck3.Name = "btnCheck3";
            this.btnCheck3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCheck3.Size = new System.Drawing.Size(75, 53);
            this.btnCheck3.TabIndex = 21;
            this.btnCheck3.Text = "בדיקה";
            this.btnCheck3.UseVisualStyleBackColor = true;
            this.btnCheck3.Click += new System.EventHandler(this.btnCheck3_Click);
            // 
            // lblEara1
            // 
            this.lblEara1.AutoSize = true;
            this.lblEara1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEara1.ForeColor = System.Drawing.Color.Red;
            this.lblEara1.Location = new System.Drawing.Point(517, 9);
            this.lblEara1.Name = "lblEara1";
            this.lblEara1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEara1.Size = new System.Drawing.Size(299, 17);
            this.lblEara1.TabIndex = 22;
            this.lblEara1.Text = "*הערה- ניתן להוסיף משקאות/ארוחות גם בזמן הטיסה";
            // 
            // lblEara2
            // 
            this.lblEara2.AutoSize = true;
            this.lblEara2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEara2.ForeColor = System.Drawing.Color.Red;
            this.lblEara2.Location = new System.Drawing.Point(473, 41);
            this.lblEara2.Name = "lblEara2";
            this.lblEara2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEara2.Size = new System.Drawing.Size(343, 17);
            this.lblEara2.TabIndex = 23;
            this.lblEara2.Text = "לתשומת ליבכם-מים וחטיף אנרגיה ינתנו בחינם במהלך הטיסה";
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
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectAirFly.Properties.Resources.אוכל;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 529);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEara2);
            this.Controls.Add(this.lblEara1);
            this.Controls.Add(this.btnCheck3);
            this.Controls.Add(this.grpDrink);
            this.Controls.Add(this.grpMeal);
            this.Controls.Add(this.btnBack2);
            this.Controls.Add(this.btnNext3);
            this.Name = "Form4";
            this.Text = "ארוחה ושתיה";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.grpDrink.ResumeLayout(false);
            this.grpDrink.PerformLayout();
            this.grpMeal.ResumeLayout(false);
            this.grpMeal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNext3;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.GroupBox grpDrink;
        private System.Windows.Forms.RadioButton rdAlcoholDrink;
        private System.Windows.Forms.RadioButton rdSahootDrink;
        private System.Windows.Forms.RadioButton rdKalDrink;
        private System.Windows.Forms.GroupBox grpMeal;
        private System.Windows.Forms.RadioButton rdHotDrink;
        private System.Windows.Forms.Button btnCheck3;
        private System.Windows.Forms.Label lblEara1;
        private System.Windows.Forms.RadioButton rdKosher;
        private System.Windows.Forms.RadioButton rdDairy;
        private System.Windows.Forms.RadioButton rdVegi;
        private System.Windows.Forms.RadioButton rdMeat;
        private System.Windows.Forms.Label lblEara2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}