using System.Windows.Forms;
using System;

namespace ProjectAirFly
{
    partial class Form7
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
            this.btnBack5 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblHotel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack5
            // 
            this.btnBack5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack5.Location = new System.Drawing.Point(732, 378);
            this.btnBack5.Name = "btnBack5";
            this.btnBack5.Size = new System.Drawing.Size(121, 45);
            this.btnBack5.TabIndex = 2;
            this.btnBack5.Text = "הקודם";
            this.btnBack5.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(371, 427);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(307, 29);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.booking.com/index.he.html";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblHotel
            // 
            this.lblHotel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHotel.Location = new System.Drawing.Point(371, 378);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHotel.Size = new System.Drawing.Size(311, 38);
            this.lblHotel.TabIndex = 7;
            this.lblHotel.Text = "לבחירת מלון המשיכו לקישור הבא";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = global::ProjectAirFly.Properties.Resources.לוגו_פרויקט;
            this.pictureBox1.Image = global::ProjectAirFly.Properties.Resources.לוגו_פרויקט;
            this.pictureBox1.Location = new System.Drawing.Point(29, 378);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectAirFly.Properties.Resources.תודה_רבה_שמים_עם_עננים;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 526);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnBack5);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form7";
            this.Text = "דרך צלחה";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion
        private System.Windows.Forms.Button btnBack5;
        private LinkLabel linkLabel1;
        private Label lblHotel;
        private PictureBox pictureBox1;
    }
}