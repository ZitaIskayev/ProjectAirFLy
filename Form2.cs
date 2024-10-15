using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAirFly
{
    public partial class Form2 : Form
    {

        public static double PriceOfTicket;//מחיר כרטיס טיסה
        public static string Makor;//מקור 
        public static string Yaad;//יעד
        public static bool flag;//שני כייונים או כיוון אחד
        public static string StartDate;//תאריך יציאה
        public static string EndDate;//תאריך חזרה

        public Form2()
        {
            InitializeComponent();
            InitializeLinkLabels();

        }
        private void InitializeLinkLabels()//שיטה לפקד קישור
        {
            // הגדרת הקישור עבור linkLabel2
            linkLabel2.Text = "לחץ כאן לביקור באתר למטייל";
            linkLabel2.Links.Add(0, linkLabel2.Text.Length, "https://www.lametayel.co.il/");

            // הגדרת האירוע של לחיצה על הקישור
            linkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);


        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }



        private void rdOneWay_CheckedChanged(object sender, EventArgs e)
        {


        }
        private void btnClear_Click()
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //הגדרת התאריך המינימלי שהמשתמש לא יוכל להקיש תאריך שעבר 
            
                DateTime today = DateTime.Today;
                date1.MinDate = today;
                date2.MinDate = today;
            
        }

        private void lblToBack_Click(object sender, EventArgs e)
        {

        }

        private void rdOneWay_CheckedChanged_1(object sender, EventArgs e)// רדיו כיוון אחד 
        {
            if (rdOneWay.Checked)//אם כיוון אחד נבחר
            {//הסתרת תאריך חזור 
                lblEndDate.Visible = false;
                txtEndDate.Visible = false;
                date2.Visible = false;

                flag = true;



            }


        }

        private void lblFromBack_Click(object sender, EventArgs e)
        {

        }

        private void btnNext1_Click(object sender, EventArgs e)
        {


            double p = 0;//איפוס משתנה מחיר 
            if (cmbMakor.SelectedIndex == 0)
                p += 1500;//מחיר תל אביב
            if (cmbMakor.SelectedIndex == 1)
                p += 1000;//מחיר מיקונוס
            if (cmbMakor.SelectedIndex == 2)
                p += 2700;//מחיר ברצלונה
            if (cmbMakor.SelectedIndex == 3)
                p += 5000;//מחיר זנזיבר
            PriceOfTicket += p;//מחיר כרטיס לפני הנחת סוג נוסע ובחירת מחלקה

            Form3 a = new Form3();//מעבר לחלון 3
            a.ShowDialog();





        }

        private void date1_DateChanged(object sender, DateRangeEventArgs e)
        {
            SelectionRange selectedRange = date1.SelectionRange;
            DateTime startDate = selectedRange.Start;
            txtStartDate.Text = e.Start.ToShortDateString();//שיטה שמירה את התאריך לטקסט כדי שנוכל לכתוב בתוך התיבת טקסט
           
        }


        private void date2_DateChanged(object sender, DateRangeEventArgs e)
        {

            SelectionRange selectedRange = date2.SelectionRange;
            DateTime endDate = selectedRange.End;
            txtEndDate.Text = e.End.ToShortDateString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {//כפתור לניקויי הבחירות של המשתמש
            rdOneWay.Checked = false;//רדיו כיוון אחד ריק
            rdGoBack.Checked = true;//רדיו שני כיוונים ברירת מחדל 
            cmbMakor.SelectedItem = null;//תיבת קומבוטקסט ריקה
            cmbYaad.SelectedItem = null;
            txtStartDate.Text = "";//תיבת טקסט ריקה
            txtEndDate.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // בדיקה שנבחר מקור
            if (cmbMakor.SelectedIndex == -1)
            {
                MessageBox.Show("לא בחרת מקור", "לתשומת ליבך", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNext1.Enabled = false;
                return;
            }
            //בדיקה שנבחר יעד
            if (cmbYaad.SelectedIndex == -1)
            {
                MessageBox.Show("לא בחרת יעד", "לתשומת ליבך", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNext1.Enabled = false;
                return;
            }
            //בדיקה מקור ויעד שונים
            if (cmbMakor.SelectedItem.ToString() == cmbYaad.SelectedItem.ToString())
            {
                MessageBox.Show("עלייך לבחור מקור ויעד שונים", "לתשומת ליבך", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNext1.Enabled = false;
                return;
            }

            // נוודא שנבחר תאריך יציאה
            if (string.IsNullOrEmpty(txtStartDate.Text))
            {
                MessageBox.Show("לא בחרת תאריך יציאה", "לתשומת ליבך", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNext1.Enabled = false;
                return;
            }

            // נוודא שנבחר תאריך חזרה אם נבחר כיוון הלוך וחזור
            if (rdGoBack.Checked && string.IsNullOrEmpty(txtEndDate.Text))
            {
                MessageBox.Show("לא בחרת תאריך חזרה", "לתשומת ליבך", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNext1.Enabled = false;
                return;
            }

            // נוודא שתאריך החזרה לא מוקדם מתאריך היציאה אם נבחר כיוון הלוך וחזור
            if (rdGoBack.Checked && date2.SelectionStart < date1.SelectionStart)
            {
                MessageBox.Show("תאריך החזרה לא יכול להיות מוקדם יותר מתאריך היציאה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                date2.SetDate(date1.SelectionStart); // תיקן  התאריך באופן אוטומטי 
                btnNext1.Enabled = false;
                return;
            }

            // אם כל התנאים מתקיימים
            btnNext1.Enabled = true;


        }

        private void rdGoBack_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGoBack.Checked)//בחרנו הלוך וחזור
            {
                lblEndDate.Visible = true;
                txtEndDate.Visible = true;
                date1.Visible = true;
                date2.Visible = true;
                flag = false;
            }
        }

        private void cmbYaad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Yaad = cmbYaad.Text;
        }

        private void cmbMakor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Makor = cmbMakor.Text;
        }

        private void txtStartDate_TextChanged(object sender, EventArgs e)
        {
            StartDate = txtStartDate.Text;
        }

        private void txtEndDate_TextChanged(object sender, EventArgs e)
        {
            EndDate = txtEndDate.Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // פתיחת הקישור בדפדפן ברירת המחדל
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}

