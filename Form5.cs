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
    public partial class Form5 : Form
    {
        
        public Form5()
        {
            InitializeComponent();
        }
       

        private void btnNext5_Click(object sender, EventArgs e)
        {
          
        }

        private void btnBack4_Click(object sender, EventArgs e)
        {
           
        }

        private void lblDataOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnBack4_Click_1(object sender, EventArgs e)
        {//חזרה לחלון 4
            Form4 show = new Form4();
            show.ShowDialog();
        }

        private void btnNext5_Click_1(object sender, EventArgs e)
        {//מעבר לחלון 6
            Form6 show = new Form6();
            show.ShowDialog();
        }

        private void btnCheck5_Click(object sender, EventArgs e)
        {
            string A;//משתנה שנכניס בו את הנתונים לסיכום הזמנה אם סימנו כיוון אחד
            string B;//משתנה שנכניס בו את הנתונים לסיכום הזמנה אם סימנו שני כיוונים
            string bb;//משתנה להבין אם נבחר הלוך וחזור או רק אחד מהם
            bool aa = Form2.flag;
            if (aa)
            {
                bb = "כיוון אחד";

            }
            else
            {
                bb = "הלוך וחזור";
            }

            //תנאי על דגל בשביל כיוון אחד ו שני כיוונים
            double P = Form3.Total;//מחיר סופי אחרי הנחה 
            string M = Form2.Makor;//מקור
            string Y = Form2.Yaad;//יעד
            string SD = Form2.StartDate;//תאריך יציאה
            string ED = Form2.EndDate;//תאריך חזרה
            int PL = Form3.PriceOfLuggage;//מחיר מזוודות
            A ="מקור:" + M + "\n" +"יעד:"+ Y +"\n" +"תאריך יציאה:"+SD+"\n" +  "מחיר כרטיס טיסה(כולל בחירת מחלקה וסוג נוסע):" + P +"\n"+"מחיר מזוודות:"+PL+"\n"+"שני כיוונים או כיוון אחד:"+bb;
            lblDataOrder.Text = A;//הדפסה בלייבל אם כיוון אחד
            if(!aa)
            {
                B  = "מקור:" + M + "\n" + "יעד:" + Y + "\n" + "תאריך יציאה:" + SD + "\n" + "תאריך חזרה:" + ED + "\n"+ "מחיר כרטיס טיסה(כולל בחירת מחלקה וסוג נוסע):" + P + "\n" + "מחיר מזוודות:" + PL + "\n" + "שני כיוונים או כיוון אחד:" + bb;
                
                lblDataOrder.Text = B;//הדפסה בלייבל אם שני כיוונים
            }
            btnNext5.Enabled = true;//פתיחת מקש הבא
            
        }
    }
}
