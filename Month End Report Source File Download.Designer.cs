namespace MIS
{
    partial class Source
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
            this.comboBoxBMName = new System.Windows.Forms.ComboBox();
            this.comboBoxTLName = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butbrwose = new System.Windows.Forms.Button();
            this.butCopy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboPracticeName = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FileListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxBMName
            // 
            this.comboBoxBMName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxBMName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxBMName.FormattingEnabled = true;
            this.comboBoxBMName.Location = new System.Drawing.Point(3, 12);
            this.comboBoxBMName.Name = "comboBoxBMName";
            this.comboBoxBMName.Size = new System.Drawing.Size(129, 21);
            this.comboBoxBMName.TabIndex = 0;
            this.comboBoxBMName.SelectedIndexChanged += new System.EventHandler(this.comboBoxBMName_SelectedIndexChanged);
            // 
            // comboBoxTLName
            // 
            this.comboBoxTLName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxTLName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTLName.FormattingEnabled = true;
            this.comboBoxTLName.Location = new System.Drawing.Point(138, 12);
            this.comboBoxTLName.Name = "comboBoxTLName";
            this.comboBoxTLName.Size = new System.Drawing.Size(150, 21);
            this.comboBoxTLName.TabIndex = 1;
            this.comboBoxTLName.SelectedIndexChanged += new System.EventHandler(this.comboBoxTLName_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(3, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // butbrwose
            // 
            this.butbrwose.Location = new System.Drawing.Point(480, 38);
            this.butbrwose.Name = "butbrwose";
            this.butbrwose.Size = new System.Drawing.Size(61, 22);
            this.butbrwose.TabIndex = 5;
            this.butbrwose.Text = "Browse";
            this.butbrwose.UseVisualStyleBackColor = true;
            // 
            // butCopy
            // 
            this.butCopy.Location = new System.Drawing.Point(547, 37);
            this.butCopy.Name = "butCopy";
            this.butCopy.Size = new System.Drawing.Size(45, 23);
            this.butCopy.TabIndex = 6;
            this.butCopy.Text = "Copy";
            this.butCopy.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.comboPracticeName);
            this.panel1.Controls.Add(this.comboBoxBMName);
            this.panel1.Controls.Add(this.butCopy);
            this.panel1.Controls.Add(this.comboBoxTLName);
            this.panel1.Controls.Add(this.butbrwose);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 70);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboPracticeName
            // 
            this.comboPracticeName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboPracticeName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboPracticeName.FormattingEnabled = true;
            this.comboPracticeName.Location = new System.Drawing.Point(304, 12);
            this.comboPracticeName.Name = "comboPracticeName";
            this.comboPracticeName.Size = new System.Drawing.Size(288, 21);
            this.comboPracticeName.TabIndex = 7;
            this.comboPracticeName.SelectedIndexChanged += new System.EventHandler(this.comboPracticeName_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 321);
            this.panel2.TabIndex = 8;
            this.panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel2_DragDrop);
            this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel2_DragEnter);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // FileListBox
            // 
            this.FileListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.FileListBox.FormattingEnabled = true;
            this.FileListBox.ItemHeight = 15;
            this.FileListBox.Location = new System.Drawing.Point(536, 70);
            this.FileListBox.Name = "FileListBox";
            this.FileListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FileListBox.Size = new System.Drawing.Size(176, 321);
            this.FileListBox.TabIndex = 9;
            // 
            // Source
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 391);
            this.Controls.Add(this.FileListBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Source";
            this.Text = "Month_End_Report_Source_File_Download";
            this.Load += new System.EventHandler(this.Source_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBoxBMName;
        private ComboBox comboBoxTLName;
        private TextBox textBox1;
        private Button butbrwose;
        private Button butCopy;
        private Panel panel1;
        private ComboBox comboPracticeName;
        private Panel panel2;
        private ListBox FileListBox;
    }
}