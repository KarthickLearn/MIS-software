namespace MIS
{
    partial class Final
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateLasteBeforeMonth = new System.Windows.Forms.DateTimePicker();
            this.dateTimeLastMonth = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCurrentMonth = new System.Windows.Forms.DateTimePicker();
            this.textBoxNoofWorkingDays = new System.Windows.Forms.TextBox();
            this.textBoxNoofTotaldays = new System.Windows.Forms.TextBox();
            this.butMonthEndReport = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboPraticeFileName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateLasteBeforeMonth
            // 
            this.dateLasteBeforeMonth.CustomFormat = "MMM - yyyy";
            this.dateLasteBeforeMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateLasteBeforeMonth.Location = new System.Drawing.Point(337, 70);
            this.dateLasteBeforeMonth.Name = "dateLasteBeforeMonth";
            this.dateLasteBeforeMonth.Size = new System.Drawing.Size(98, 23);
            this.dateLasteBeforeMonth.TabIndex = 0;
            // 
            // dateTimeLastMonth
            // 
            this.dateTimeLastMonth.CustomFormat = "MMM - yyyy";
            this.dateTimeLastMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeLastMonth.Location = new System.Drawing.Point(337, 144);
            this.dateTimeLastMonth.Name = "dateTimeLastMonth";
            this.dateTimeLastMonth.Size = new System.Drawing.Size(98, 23);
            this.dateTimeLastMonth.TabIndex = 1;
            // 
            // dateTimeCurrentMonth
            // 
            this.dateTimeCurrentMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeCurrentMonth.Location = new System.Drawing.Point(337, 206);
            this.dateTimeCurrentMonth.Name = "dateTimeCurrentMonth";
            this.dateTimeCurrentMonth.Size = new System.Drawing.Size(98, 23);
            this.dateTimeCurrentMonth.TabIndex = 2;
            this.dateTimeCurrentMonth.ValueChanged += new System.EventHandler(this.dateTimeCurrentMonth_ValueChanged);
            // 
            // textBoxNoofWorkingDays
            // 
            this.textBoxNoofWorkingDays.Location = new System.Drawing.Point(233, 312);
            this.textBoxNoofWorkingDays.Name = "textBoxNoofWorkingDays";
            this.textBoxNoofWorkingDays.Size = new System.Drawing.Size(60, 23);
            this.textBoxNoofWorkingDays.TabIndex = 3;
            this.textBoxNoofWorkingDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNoofWorkingDays.TextChanged += new System.EventHandler(this.textBoxNoofWorkingDays_TextChanged);
            // 
            // textBoxNoofTotaldays
            // 
            this.textBoxNoofTotaldays.Location = new System.Drawing.Point(233, 359);
            this.textBoxNoofTotaldays.Name = "textBoxNoofTotaldays";
            this.textBoxNoofTotaldays.Size = new System.Drawing.Size(60, 23);
            this.textBoxNoofTotaldays.TabIndex = 4;
            this.textBoxNoofTotaldays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butMonthEndReport
            // 
            this.butMonthEndReport.IconChar = FontAwesome.Sharp.IconChar.None;
            this.butMonthEndReport.IconColor = System.Drawing.Color.Black;
            this.butMonthEndReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butMonthEndReport.Location = new System.Drawing.Point(337, 312);
            this.butMonthEndReport.Name = "butMonthEndReport";
            this.butMonthEndReport.Size = new System.Drawing.Size(209, 70);
            this.butMonthEndReport.TabIndex = 5;
            this.butMonthEndReport.Text = "Month End Report";
            this.butMonthEndReport.UseVisualStyleBackColor = true;
            this.butMonthEndReport.Click += new System.EventHandler(this.butMonthEndReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "No of Working Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total No of Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Before Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(51, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(51, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Current Month";
            // 
            // comboPraticeFileName
            // 
            this.comboPraticeFileName.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboPraticeFileName.FormattingEnabled = true;
            this.comboPraticeFileName.Location = new System.Drawing.Point(265, 20);
            this.comboPraticeFileName.Name = "comboPraticeFileName";
            this.comboPraticeFileName.Size = new System.Drawing.Size(302, 21);
            this.comboPraticeFileName.TabIndex = 11;
            this.comboPraticeFileName.SelectedIndexChanged += new System.EventHandler(this.comboPraticeFileName_SelectedIndexChanged);
            // 
            // Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(705, 464);
            this.Controls.Add(this.comboPraticeFileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butMonthEndReport);
            this.Controls.Add(this.textBoxNoofTotaldays);
            this.Controls.Add(this.textBoxNoofWorkingDays);
            this.Controls.Add(this.dateTimeCurrentMonth);
            this.Controls.Add(this.dateTimeLastMonth);
            this.Controls.Add(this.dateLasteBeforeMonth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Final";
            this.Text = "Final";
            this.Load += new System.EventHandler(this.Final_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateLasteBeforeMonth;
        private DateTimePicker dateTimeLastMonth;
        private DateTimePicker dateTimeCurrentMonth;
        private TextBox textBoxNoofWorkingDays;
        private TextBox textBoxNoofTotaldays;
        private FontAwesome.Sharp.IconButton butMonthEndReport;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboPraticeFileName;
    }
}