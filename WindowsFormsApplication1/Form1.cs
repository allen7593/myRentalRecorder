using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            canVisible = false;                     //set canlander not visible
            startDateCan.Visible = false;           //set canlander not visible
            startDateCan.SetDate(DateTime.Today);   //set default as today's date
            startDateTime = DateTime.Today;
            startDateBox.Text = DateTime.Today.ToShortDateString();
            double numOfWeeks = Convert.ToDouble(numWeekCount.Value)*7;
            endDateBox.Text = DateTime.Today.AddDays(numOfWeeks).ToShortDateString();
        }

        private void startDateCan_DateChanged(object sender, DateRangeEventArgs e)
        {                
            startDateTime = e.End;
            startDateBox.Text = startDateTime.ToShortDateString();
            
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (canVisible == true)             //if it is not shown, then show the calander
            {
                startDateCan.Visible = false;
                canVisible = false;
                canShowBut.Text = "Show Can";
            }
            else                               //if it is shown, then hide the calander
            {
                startDateCan.Visible = true;
                canVisible = true;
                canShowBut.Text = "Hide Can";
            }
        }

        private void numWeekCount_ValueChanged(object sender, EventArgs e)
        {
            double numOfWeeks = Convert.ToDouble(numWeekCount.Value)*7;

            endDateBox.Text = startDateTime.AddDays(numOfWeeks).ToShortDateString();
        }

        public bool canVisible { get; private set; }

        public DateTime startDateTime { get; private set; }

        public DateTime endDateTime { get; private set; }

       

    }
}
