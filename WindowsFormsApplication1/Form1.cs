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
            startDateTime = DateTime.Today;         //set start date default as today
            startDateBox.Text = DateTime.Today.ToShortDateString();
            double numOfWeeks = Convert.ToDouble(numWeekCount.Value)*7;
            amountCount.Maximum = 1000;
            totalAmoutBox.Text = "0";
            endDateBox.Text = DateTime.Today.AddDays(numOfWeeks).ToShortDateString();
            totalAmoutBox.Text = Convert.ToDouble(numWeekCount.Value * amountCount.Value).ToString();


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
            totalAmoutBox.Text = Convert.ToDouble(numWeekCount.Value * amountCount.Value).ToString();
        }

        private void amountCount_ValueChanged(object sender, EventArgs e)
        {
            totalAmoutBox.Text = Convert.ToDouble(numWeekCount.Value * amountCount.Value).ToString();
        }

        private void updateBut_Click(object sender, EventArgs e)
        {
            double numOfWeeks = Convert.ToDouble(numWeekCount.Value) * 7;
            endDateBox.Text = startDateTime.AddDays(numOfWeeks).ToShortDateString();
            totalAmoutBox.Text = Convert.ToDouble(numWeekCount.Value * amountCount.Value).ToString();
        }

        private void clearBut_Click(object sender, EventArgs e)
        {
            numWeekCount.Value = 0;
            amountCount.Value = 0;
            updateBut_Click(sender, e);
        }

        public bool canVisible { get; private set; }

        public DateTime startDateTime { get; private set; }

        public DateTime endDateTime { get; private set; }

        

        

        

       

    }
}
