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
    public partial class Form4 : Form
    {
        public static double MealsPrice, DrinksPrice;
        public Form4()
        {
            InitializeComponent();
        }
      

        private void btnNext3_Click()
        {
          
        }

        private void counterTrolley_ValueChanged()
        {

        }

        private void chkTrolley_CheckedChanged()
        {
            
        }

        private void chk20Kg_CheckedChanged()
        {
           
        }

        private void chk32Kg_CheckedChanged()
        {
       
        }

        private void chkFreeBag_CheckedChanged()
        {
           
        }

        private void btnBack2_Click()
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        

        private void rdKalDrink_CheckedChanged(object sender, EventArgs e)
        {
            if (rdKalDrink.Checked)//שתיה קלה
            {
                DrinksPrice += 12;
            }

        }

        private void rdSahootDrink_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSahootDrink.Checked)//משקאות סחוטים
            {
                DrinksPrice += 25;
            }
        }

        private void rdAlcoholDrink_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAlcoholDrink.Checked)//משקאות אלכוהוליים
            {
                DrinksPrice += 45;
            }
        }

        

        private void rdKosher_CheckedChanged(object sender, EventArgs e)
        {
            if (rdKosher.Checked)//ארוחה כשרה 
            {
                MealsPrice += 60;
            }
        }

        private void rdDairy_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDairy.Checked)//ארוחה חלבית
            {
                MealsPrice += 45;
            }
        }

        private void rdMeat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMeat.Checked)//ארוחה בשרית
            {
                MealsPrice += 75;
            }
        }

        private void rdVegi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdVegi.Checked)//ארוחה צמחונית
            {
                MealsPrice += 68;
            }
        }

        private void btnCheck3_Click(object sender, EventArgs e)
        {
            if  ((rdHotDrink.Checked == false) && (rdSahootDrink.Checked == false) && (rdAlcoholDrink.Checked == false)&& (rdKalDrink.Checked == false))
            {//הודעת שגיאה לא נבחר סוג משקה
                btnNext3.Enabled = false;
                MessageBox.Show("יש לבחור סוג משקה", "לתשומת ליבך", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }
            else if ( (rdKosher.Checked == false) && (rdDairy.Checked == false)&& (rdMeat.Checked == false)&&(rdVegi.Checked==false))
            {//הודעת שגיאה לא נבחרה ארוחה
                btnNext3.Enabled = false;
                MessageBox.Show("יש לבחור ארוחה", "לתשומת ליבך", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {//עומד בתנאים הכפתור הבא זמין
                btnNext3.Enabled = true;
            }
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {//מעבר לחלון 5
            Form5 show = new Form5();
            show.ShowDialog();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {//חזרה לחלון 3
            Form3 show = new Form3();
            show.ShowDialog();
        }

        private void rdHotDrink_CheckedChanged(object sender, EventArgs e)
        {
            if (rdHotDrink.Checked)//שתיה חמה 
            {
                DrinksPrice += 15;
            }

        }
    }
}
