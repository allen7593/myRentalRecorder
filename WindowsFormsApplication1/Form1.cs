using System;
using System.ComponentModel;
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
            canVisible = false;                                                                         //set canlander not visible
            startDateCan.Visible = false;                                                               //set canlander not visible
            startDateCan.SetDate(DateTime.Today);                                                       //set default as today's date
            startDateTime = DateTime.Today;                                                             //set start date default as today
            startDateBox.Text = DateTime.Today.ToShortDateString();                                     //set start date box defult as today
            double numOfWeeks = Convert.ToDouble(numWeekCount.Value)*7;                                 //caculate number of days need to add
            numWeekCount.Minimum = 0;
            numWeekCount.Maximum = 20;
            amountCount.Minimum = 0;
            amountCount.Maximum = 1000;                                                                 //set amount maximum as 1000
            totalAmoutBox.Text = "0";                                                                   //set total amount default as 0
            endDateTime = DateTime.Today.AddDays(numOfWeeks);
            endDateBox.Text = DateTime.Today.AddDays(numOfWeeks).ToShortDateString();                   //caculate end date
            totalAmoutBox.Text = Convert.ToDouble(numWeekCount.Value * amountCount.Value).ToString();   //calculate total amount
            data = new RentalData();

        }

        private void startDateCan_DateChanged(object sender, DateRangeEventArgs e)
        {                
            startDateTime = e.End;                                                                      //get selected date
            startDateBox.Text = startDateTime.ToShortDateString();                                      //set start date to the selected date
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (canVisible == true)                                                                     //if it is not shown, then show the calander
            {
                startDateCan.Visible = false;
                canVisible = false;
                canShowBut.Text = "Show Can";
            }
            else                                                                                        //if it is shown, then hide the calander
            {
                startDateCan.Visible = true;
                canVisible = true;
                canShowBut.Text = "Hide Can";
            }
        }

        private void numWeekCount_ValueChanged(object sender, EventArgs e)              
        {
            double numOfWeeks = Convert.ToDouble(numWeekCount.Value)*7;                                 //caculate number of days need to add
            endDateTime = startDateTime.AddDays(numOfWeeks);
            endDateBox.Text = startDateTime.AddDays(numOfWeeks).ToShortDateString();                    //add days
            totalAmoutBox.Text = Convert.ToDouble(numWeekCount.Value * amountCount.Value).ToString();   //caculate total amount
        }

        private void amountCount_ValueChanged(object sender, EventArgs e)
        {
            totalAmoutBox.Text = Convert.ToDouble(numWeekCount.Value * amountCount.Value).ToString();   //calculate total amount
        }

        private void updateBut_Click(object sender, EventArgs e)                                        //update everything
        {
            double numOfWeeks = Convert.ToDouble(numWeekCount.Value) * 7;
            endDateTime = startDateTime.AddDays(numOfWeeks);
            endDateBox.Text = startDateTime.AddDays(numOfWeeks).ToShortDateString();
            totalAmoutBox.Text = Convert.ToDouble(numWeekCount.Value * amountCount.Value).ToString();
        }

        private void clearBut_Click(object sender, EventArgs e)                                         //clear everything
        {
            startDateTime = DateTime.Today;
            endDateTime = DateTime.Today;
            numWeekCount.Value = 0;
            amountCount.Value = 0;
            ReferenceBox.Clear();
            updateBut_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“logDataSet.logData”中。您可以根据需要移动或删除它。
            this.logDataTableAdapter.Fill(this.logDataSet.logData);

        }

        private void refreshBut_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void submitBut_Click(object sender, EventArgs e)
        {
            if (ReferenceBox.Text == "")
            {
                MessageBox.Show("Reference number cannot be empty!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (numWeekCount.Value==0)
            {
                MessageBox.Show("Please enter a valid number for number of weeks!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (amountCount.Value == 0)
            {
                MessageBox.Show("Please enter a valid number for amount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult retVal;
            

            data.startDate = startDateTime;
            data.endDate = endDateTime;
            data.numOfWeeks =Convert.ToInt32( numWeekCount.Value);
            data.amount = Convert.ToInt32(amountCount.Value);
            data.totalAmount = Convert.ToInt32(totalAmoutBox.Text);
            data.referenceNum = ReferenceBox.Text;
            retVal = MessageBox.Show("Are you sure you wants to submit the following information?\n" + "Start Date: " + data.startDate.ToShortDateString() + "\n" + "End Date: " + data.endDate.ToShortDateString() + "\n" + "Number of weeks: " + data.numOfWeeks + "\n" + "Total Amount: $" + data.totalAmount + "\n" + "Amount per week: $" + data.amount + "\n" + "Reference Number: " + data.referenceNum, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (retVal == DialogResult.OK)
            {
                //updata to database
                logDataTableAdapter.InsertQuery(data.referenceNum,data.startDate,data.endDate,data.amount,data.totalAmount,data.numOfWeeks);

                
            }
            else
                return;

        }

        private RentalData data;


        public bool canVisible { get; private set; }

        public DateTime startDateTime { get; private set; }

        public DateTime endDateTime { get; private set; }



       
        

        

        

       

    }
}
