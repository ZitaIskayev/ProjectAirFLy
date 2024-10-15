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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            InsertData();
        }

        private void InsertData()//שיטה להגדרת הקישור ומציאתו
        {
            // הגדרת הקישור
            linkLabel1.Text = "לחץ כאן לביקור באתר";
            linkLabel1.Links.Add(0, 19, "http://www.Booking.com");

            // הגדרת האירוע של לחיצה על הקישור
            linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // פתיחת הקישור בדפדפן ברירת המחדל
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());

        }

        private void btnPrintOrder_Click(object sender, EventArgs e)
        {

        }

    }
}

