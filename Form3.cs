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
    public partial class Form3 : Form
    {//לקיחת נתונים מחלון 2 ממשתנה מחיר סופי לחלון 3
        public static double Total = Form2.PriceOfTicket;//מחיר סופי הוא מחיר של כרטיס הטיסה מחלון קודם אחרי הנחת סוג נוסע ותוספת לפי סוג מחלקה
        public static int PriceOfLuggage;//מחיר מזוודות

        public Form3()
        {
            InitializeComponent();
        }

        private void counterTrolley_ValueChanged(object sender, EventArgs e)
        {

        }

        private void grpLuggages_Enter(object sender, EventArgs e)
        {

        }

        private void btnNext2_Click(object sender, EventArgs e)
        {

            //מעבר לחלון 4
            Form4 show = new Form4();
            show.ShowDialog();
        }

        private void cmbTrolley_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdBaby_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBaby.Checked)//הנחת תינוק
            {
                Total = Total * 0.5;
            }
        }

        private void rdAdult_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAdult.Checked)//מבוגר 
            {
                Total = Total * 1;
            }
        }

        private void chkTrolley_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTrolley.Checked == true)//טרולי 150שח
            {
                PriceOfLuggage += 150;
            }





        }

        private void chk24Kg_CheckedChanged(object sender, EventArgs e)
        {
            if (chk24Kg.Checked == true)//מזוודה 250שח
            {
                PriceOfLuggage += 250;
            }





        }

        private void chkBag_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBag.Checked)//תיק גב כלול במחיר 
            {
                PriceOfLuggage += 0;
            }



        }

        private void grpClass_Enter(object sender, EventArgs e)
        {

        }

        private void rdFirstClass_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFirstClass.Checked)//מחלקה ראשונה 
            {
                Total = Total * (1 + 0.4);
            }
        }

        private void rdBusiness_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBusiness.Checked)//מחלקת עסקים
            {
                Total = Total * (1 + 0.2);
            }

        }

        private void rdEconomy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdEconomy.Checked)//מחלקת תיירים
            {
                Total = Total * 1;
            }
        }

        private void rdChild_CheckedChanged(object sender, EventArgs e)
        {
            if (rdChild.Checked)//הנחת ילד 
            {
                Total = Total * 0.8;
            }
        }

        private void rdBabySmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBabySmall.Checked)//תינוק מתחת לגיל 9 חודשים
            {
                Total = Total * 0;
            }
        }

        private void btnCheak_Click(object sender, EventArgs e)
        {
            if ((rdAdult.Checked == false) && (rdBaby.Checked == false) && (rdBabySmall.Checked == false) && (rdChild.Checked == false))
            {//הודעת שגיאה לא נבחר סוג נוסע
                btnNext2.Enabled = false;
                MessageBox.Show("יש לבחור סוג נוסע", "לתשומת ליבך", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
           else if ((rdFirstClass.Checked == false) && (rdBusiness.Checked == false) && (rdEconomy.Checked == false))
            {//הודעת שגיאה לא נבחרה מחלקה
                btnNext2.Enabled = false;
                MessageBox.Show("יש לבחור סוג מחלקה", "לתשומת ליבך", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (chkBag.Checked == false)
            {//הודעת שגיאה לא נבר תיק גב או כבודה בתשלום נוסף
                btnNext2.Enabled = false;
                MessageBox.Show("יש לבחור תיק גב הכלול במחיר  ", "לתשומת ליבך", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else 
            {//עומד בתנאים הכפתור הבא זמין
                btnNext2.Enabled = true;
            }
        }

        private void btnBack1_Click(object sender, EventArgs e)
        { //חזרה לחלון 2
            Form2 show = new Form2();
            show.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {//ניקויי כל האפשרויות
            rdFirstClass.Checked = false;
            rdBusiness.Checked = false;
            rdEconomy.Checked = false;
            rdAdult.Checked = false;
            rdBaby.Checked = false;
            rdBabySmall.Checked = false;
            rdChild.Checked = false;
            chk24Kg.Checked = false;
            chkBag.Checked = false;
            chkTrolley.Checked = false;


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
