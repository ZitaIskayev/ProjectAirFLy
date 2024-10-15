namespace ProjectAirFly
{
    partial class Form5
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
            this.btnBack4 = new System.Windows.Forms.Button();
            this.btnNext5 = new System.Windows.Forms.Button();
            this.lblSumOfOrder = new System.Windows.Forms.Label();
            this.lblDataOrder = new System.Windows.Forms.Label();
            this.btnCheck5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack4
            // 
            this.btnBack4.AutoSize = true;
            this.btnBack4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack4.Location = new System.Drawing.Point(717, 437);
            this.btnBack4.Name = "btnBack4";
            this.btnBack4.Size = new System.Drawing.Size(94, 53);
            this.btnBack4.TabIndex = 3;
            this.btnBack4.Text = "הקודם";
            this.btnBack4.UseVisualStyleBackColor = true;
            this.btnBack4.Click += new System.EventHandler(this.btnBack4_Click_1);
            // 
            // btnNext5
            // 
            this.btnNext5.AutoSize = true;
            this.btnNext5.Enabled = false;
            this.btnNext5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext5.Location = new System.Drawing.Point(83, 437);
            this.btnNext5.Name = "btnNext5";
            this.btnNext5.Size = new System.Drawing.Size(86, 53);
            this.btnNext5.TabIndex = 5;
            this.btnNext5.Text = "הבא";
            this.btnNext5.UseVisualStyleBackColor = true;
            this.btnNext5.Click += new System.EventHandler(this.btnNext5_Click_1);
            // 
            // lblSumOfOrder
            // 
            this.lblSumOfOrder.AutoSize = true;
            this.lblSumOfOrder.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumOfOrder.Location = new System.Drawing.Point(700, 24);
            this.lblSumOfOrder.Name = "lblSumOfOrder";
            this.lblSumOfOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSumOfOrder.Size = new System.Drawing.Size(106, 22);
            this.lblSumOfOrder.TabIndex = 6;
            this.lblSumOfOrder.Text = "סיכום הזמנה:";
            // 
            // lblDataOrder
            // 
            this.lblDataOrder.BackColor = System.Drawing.SystemColors.Control;
            this.lblDataOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDataOrder.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDataOrder.Location = new System.Drawing.Point(66, 173);
            this.lblDataOrder.Name = "lblDataOrder";
            this.lblDataOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDataOrder.Size = new System.Drawing.Size(749, 207);
            this.lblDataOrder.TabIndex = 7;
            this.lblDataOrder.Click += new System.EventHandler(this.lblDataOrder_Click);
            // 
            // btnCheck5
            // 
            this.btnCheck5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.btnCheck5.Location = new System.Drawing.Point(293, 437);
            this.btnCheck5.Name = "btnCheck5";
            this.btnCheck5.Size = new System.Drawing.Size(228, 53);
            this.btnCheck5.TabIndex = 8;
            this.btnCheck5.Text = "הצג סיכום הזמנה";
            this.btnCheck5.UseVisualStyleBackColor = true;
            this.btnCheck5.Click += new System.EventHandler(this.btnCheck5_Click);
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
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectAirFly.Properties.Resources.מ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(859, 502);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCheck5);
            this.Controls.Add(this.lblDataOrder);
            this.Controls.Add(this.lblSumOfOrder);
            this.Controls.Add(this.btnNext5);
            this.Controls.Add(this.btnBack4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form5";
            this.Text = "סיכום הזמנה";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack4;
        private System.Windows.Forms.Button btnNext5;
        private System.Windows.Forms.Label lblSumOfOrder;
        private System.Windows.Forms.Label lblDataOrder;
        private System.Windows.Forms.Button btnCheck5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}