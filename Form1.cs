using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAirFly
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        


        private void lblAboutUs_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }


        public void btnStart_Click(object sender, EventArgs e)
        {
          


        }


        private void lblContect_Click(object sender, EventArgs e)
        {
         
        }



        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void toContectToolStripMenuItem_Click(object sender, EventArgs e)
        {
        

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void lblAboutUs_Click_1(object sender, EventArgs e)//הסתרת לייבל קצת עלינו
        {
            lblAboutUs.Visible = false;//לייבל בלתי נראה
        }

        private void lblContect_Click_1(object sender, EventArgs e)//הסתרת לייבל יצירת קשר
        {
          lblContect.Visible = false;// לייבל בלתי נראה 
        }

        private void btnUs_Click(object sender, EventArgs e)//מקש בטן קצת עלינו  
        {
            lblAboutUs.Visible=true;//חשיפת לייבל קצת עלינו 
            lblContect.Visible=false;//הסתרת לייבל יצירת קשר
        }

        private void btnContact_Click(object sender, EventArgs e)//מקש בטן יצירת קשר 
        {
            lblAboutUs.Visible = false;//הסתרת לייבל קצת עלינו 
            lblContect.Visible = true;//חשיפת לייבל יצירת קשר 
        }

        private void btnExit_Click(object sender, EventArgs e)//מקש בטן יציאה 
        {//האם אתה בטוח שאתה רוצה לצאת מסגבוקס
            if (MessageBox.Show("האם אתה בטוח שתרצה לצאת?", "שים לב", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           Close();

        }

        private void btnStart_Click_1(object sender, EventArgs e)//מקש בטן התחל 
        {//מעבר לחלון הבא 
            Form2 a = new Form2();
            a.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}