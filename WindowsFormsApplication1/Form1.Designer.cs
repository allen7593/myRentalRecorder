namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.startDate = new System.Windows.Forms.Label();
            this.startDateCan = new System.Windows.Forms.MonthCalendar();
            this.startDateBox = new System.Windows.Forms.TextBox();
            this.endDate = new System.Windows.Forms.Label();
            this.endDateBox = new System.Windows.Forms.TextBox();
            this.numWeek = new System.Windows.Forms.Label();
            this.numWeekCount = new System.Windows.Forms.NumericUpDown();
            this.amount = new System.Windows.Forms.Label();
            this.amountCount = new System.Windows.Forms.NumericUpDown();
            this.Reference = new System.Windows.Forms.Label();
            this.ReferenceBox = new System.Windows.Forms.TextBox();
            this.submitBut = new System.Windows.Forms.Button();
            this.clearBut = new System.Windows.Forms.Button();
            this.canShowBut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totalAmoutBox = new System.Windows.Forms.TextBox();
            this.updateBut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numWeekCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Location = new System.Drawing.Point(23, 13);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(71, 12);
            this.startDate.TabIndex = 0;
            this.startDate.Text = "Start Date:";
            // 
            // startDateCan
            // 
            this.startDateCan.Location = new System.Drawing.Point(91, 34);
            this.startDateCan.Name = "startDateCan";
            this.startDateCan.TabIndex = 1;
            this.startDateCan.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.startDateCan_DateChanged);
            // 
            // startDateBox
            // 
            this.startDateBox.Location = new System.Drawing.Point(91, 13);
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.ReadOnly = true;
            this.startDateBox.Size = new System.Drawing.Size(220, 21);
            this.startDateBox.TabIndex = 2;
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Location = new System.Drawing.Point(317, 13);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(59, 12);
            this.endDate.TabIndex = 3;
            this.endDate.Text = "End Date:";
            // 
            // endDateBox
            // 
            this.endDateBox.Location = new System.Drawing.Point(382, 13);
            this.endDateBox.Name = "endDateBox";
            this.endDateBox.ReadOnly = true;
            this.endDateBox.Size = new System.Drawing.Size(208, 21);
            this.endDateBox.TabIndex = 4;
            // 
            // numWeek
            // 
            this.numWeek.AutoSize = true;
            this.numWeek.Location = new System.Drawing.Point(319, 50);
            this.numWeek.Name = "numWeek";
            this.numWeek.Size = new System.Drawing.Size(101, 12);
            this.numWeek.TabIndex = 5;
            this.numWeek.Text = "Number of Weeks:";
            // 
            // numWeekCount
            // 
            this.numWeekCount.Location = new System.Drawing.Point(416, 48);
            this.numWeekCount.Name = "numWeekCount";
            this.numWeekCount.Size = new System.Drawing.Size(174, 21);
            this.numWeekCount.TabIndex = 6;
            this.numWeekCount.ValueChanged += new System.EventHandler(this.numWeekCount_ValueChanged);
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(317, 80);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(113, 12);
            this.amount.TabIndex = 7;
            this.amount.Text = "Amount pre week: $";
            // 
            // amountCount
            // 
            this.amountCount.Location = new System.Drawing.Point(430, 80);
            this.amountCount.Name = "amountCount";
            this.amountCount.Size = new System.Drawing.Size(160, 21);
            this.amountCount.TabIndex = 8;
            this.amountCount.ValueChanged += new System.EventHandler(this.amountCount_ValueChanged);
            // 
            // Reference
            // 
            this.Reference.AutoSize = true;
            this.Reference.Location = new System.Drawing.Point(317, 137);
            this.Reference.Name = "Reference";
            this.Reference.Size = new System.Drawing.Size(89, 12);
            this.Reference.TabIndex = 9;
            this.Reference.Text = "Reference NO.:";
            // 
            // ReferenceBox
            // 
            this.ReferenceBox.Location = new System.Drawing.Point(405, 134);
            this.ReferenceBox.Name = "ReferenceBox";
            this.ReferenceBox.Size = new System.Drawing.Size(185, 21);
            this.ReferenceBox.TabIndex = 10;
            // 
            // submitBut
            // 
            this.submitBut.Location = new System.Drawing.Point(345, 161);
            this.submitBut.Name = "submitBut";
            this.submitBut.Size = new System.Drawing.Size(75, 23);
            this.submitBut.TabIndex = 11;
            this.submitBut.Text = "Submit";
            this.submitBut.UseVisualStyleBackColor = true;
            // 
            // clearBut
            // 
            this.clearBut.Location = new System.Drawing.Point(515, 161);
            this.clearBut.Name = "clearBut";
            this.clearBut.Size = new System.Drawing.Size(75, 23);
            this.clearBut.TabIndex = 12;
            this.clearBut.Text = "Clear";
            this.clearBut.UseVisualStyleBackColor = true;
            this.clearBut.Click += new System.EventHandler(this.clearBut_Click);
            // 
            // canShowBut
            // 
            this.canShowBut.Location = new System.Drawing.Point(25, 34);
            this.canShowBut.Name = "canShowBut";
            this.canShowBut.Size = new System.Drawing.Size(62, 23);
            this.canShowBut.TabIndex = 13;
            this.canShowBut.Text = "Show Can";
            this.canShowBut.UseVisualStyleBackColor = true;
            this.canShowBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total Amount: $";
            // 
            // totalAmoutBox
            // 
            this.totalAmoutBox.Location = new System.Drawing.Point(416, 107);
            this.totalAmoutBox.Name = "totalAmoutBox";
            this.totalAmoutBox.ReadOnly = true;
            this.totalAmoutBox.Size = new System.Drawing.Size(174, 21);
            this.totalAmoutBox.TabIndex = 15;
            // 
            // updateBut
            // 
            this.updateBut.Location = new System.Drawing.Point(430, 161);
            this.updateBut.Name = "updateBut";
            this.updateBut.Size = new System.Drawing.Size(75, 23);
            this.updateBut.TabIndex = 16;
            this.updateBut.Text = "Update";
            this.updateBut.UseVisualStyleBackColor = true;
            this.updateBut.Click += new System.EventHandler(this.updateBut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(565, 292);
            this.dataGridView1.TabIndex = 17;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(604, 530);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.updateBut);
            this.Controls.Add(this.totalAmoutBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.canShowBut);
            this.Controls.Add(this.clearBut);
            this.Controls.Add(this.submitBut);
            this.Controls.Add(this.ReferenceBox);
            this.Controls.Add(this.Reference);
            this.Controls.Add(this.amountCount);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.numWeekCount);
            this.Controls.Add(this.numWeek);
            this.Controls.Add(this.endDateBox);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDateBox);
            this.Controls.Add(this.startDateCan);
            this.Controls.Add(this.startDate);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numWeekCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.MonthCalendar startDateCan;
        private System.Windows.Forms.TextBox startDateBox;
        private System.Windows.Forms.Label endDate;
        private System.Windows.Forms.TextBox endDateBox;
        private System.Windows.Forms.Label numWeek;
        private System.Windows.Forms.NumericUpDown numWeekCount;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.NumericUpDown amountCount;
        private System.Windows.Forms.Label Reference;
        private System.Windows.Forms.TextBox ReferenceBox;
        private System.Windows.Forms.Button submitBut;
        private System.Windows.Forms.Button clearBut;
        private System.Windows.Forms.Button canShowBut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalAmoutBox;
        private System.Windows.Forms.Button updateBut;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

