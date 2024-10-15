using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectAirFly
{
    public partial class Form6 : Form
    {
        public static string FName;//שם פרטי
        public static string SName;//שם משפחה
        
        public bool Check(string text)
        {// שיטה שמקבלת טקסט ובודקת שאין ספרות בתיבת טקסט ומחזירה הודעה אם יש
            bool flag=true;
            for(int i=0;i<text.Length;i++)
            {
                if (text[i] < '0' || text[i]>'9')
                {
                    flag = false;
                    MessageBox.Show("עליך להזין ספרות בלבד", "לתשומת ליבך", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnNext4.Enabled = false;
                    break;
                }
                
            }
           return flag; 
        }
        private bool IsOnlyLetters(string input)//שיטה שמקבלת טקסט ומחזירה אם כולם טקסט
        {
            return input.All(Char.IsLetter);
        }
        public Form6()
        {
            InitializeComponent();
        }
        public Form6(int total)
        { 
         InitializeComponent();
       
        }
        

        private void label1_Click()
        {

        }

        private void txtNumTeens_TextChanged()
        {

        }

        private void txtNumChild_TextChanged()
        {

        }

        private void txtNumBaby_TextChanged()
        {

        }

        private void btnBack3_Click()
        {
            
        }

        private void People_age_Load()
        {

        }

        private void cmbPassengers_SelectedIndexChanged()
        {

        }

        private void dateTimePicker1_ValueChanged()
        {

        }

        private void btnNext4_Click()
        {
           
           


        }

        private void txtNumAdult_TextChanged()
        {

        }

        private void lblAmountPass_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnCheck4_Click(object sender, EventArgs e)
        {
            
            if (!txtFName.Text.All(Char.IsLetter))//בדיקה שכל התווים הם אותיות
            {
                MessageBox.Show("עליך להכניס רק אותיות", "לתשומת ליבך", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNext4.Enabled = false;
            }
            if (!txtSName.Text.All(Char.IsLetter))//בדיקה שכל התווים הם אותיות
            {
                MessageBox.Show("עליך להכניס רק אותיות", "לתשומת ליבך", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNext4.Enabled = false;
            }
           else if (cmbMonth.SelectedIndex==-1) 
            {//לבחור חודש
                MessageBox.Show("עליך לבחור חודש שמופיע בכרטיס האשראי", "לתשומת ליבך", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNext4.Enabled = false;

            }
           else if (cmbYear.SelectedIndex == -1)
            {//לבחור שנה 
                MessageBox.Show("עליך לבחור שנה שמופיעה בכרטיס האשראי", "לתשומת ליבך", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNext4.Enabled = false;

            }
            else
            {//פתיחת מקש הבא
                btnNext4.Enabled = true;
            }
          
            


            
            

        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtCvv_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNext4_Click(object sender, EventArgs e)
        {//מעבר לחלון 7
            Form7 show = new Form7();
            show.ShowDialog();
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {//חזרה לחלון 5
            Form5 show = new Form5();
            show.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {//בדיקה האם יש יותר או פחות מ9 ספרות וגם לבתייחס למקרה שהמשתמש ירשום אותיות
            string ID = txtID.Text;
            bool I=Check(ID);
            if (ID.Length != 9)
            {
                MessageBox.Show("עליך להזין תעודת זהות בעלת 9 ספרות", "לתשומת ליבך", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCheck4.Enabled = false;
                return;
            }
            else if((ID.Length==9)&&(I))
            {
                MessageBox.Show("הנתונים נקלטו בהצלחה", "מאושר", MessageBoxButtons.OK);
                btnCheck4.Enabled = true;
                return;

            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {//בדיקה האם יש יותר או פחות מ16 ספרות וגם לבדוק אותיות
            string CardNumber = txtCardNumber.Text;
            bool C=Check(CardNumber);
            if (CardNumber.Length != 16)
            {
                MessageBox.Show("עליך להזין מס כרטיס בעל 16 ספרות", "לתשומת ליבך", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCheck4.Enabled = false;
                return;
            }
            else if((CardNumber.Length==16)&&(C))
            {

                MessageBox.Show("הנתונים נקלטו בהצלחה", "מאושר", MessageBoxButtons.OK);
                btnCheck4.Enabled = true;
                return;
            }
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //בדיקת איות ובדיקה שהכניס 3 מספרים
            string Cvv = txtCvv.Text;
            bool V=Check(Cvv);
            if (Cvv.Length != 3)
            {
                
                MessageBox.Show("עליך להזין 3 ספרות שנמצאות בגב הכרטיס", "לתשומת ליבך", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCheck4.Enabled = false;
                return;

            }
            else if((Cvv.Length ==3)&&(V))
            {
                MessageBox.Show("הנתונים נקלטו בהצלחה", "מאושר", MessageBoxButtons.OK);
                btnCheck4.Enabled = true;
                return;
                
            }
            
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
 
          if (!IsOnlyLetters(txtFName.Text))
          {
            MessageBox.Show("עליך להכניס רק אותיות", "לתשומת ליבך", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnNext4.Enabled = false;
          }
          else
          {
           btnNext4.Enabled = true;
          }
            
        }

        private void txtSName_TextChanged(object sender, EventArgs e)
        {

            if (!IsOnlyLetters(txtSName.Text))
            {
                MessageBox.Show("עליך להכניס רק אותיות", "לתשומת ליבך", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNext4.Enabled = false;
            }
            else
            {
                btnNext4.Enabled = true;
            }
            
        }
    }
}



