namespace MIS
{
    partial class Rename_Source_File
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.DaysheetCorrectList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.LCFcorrectList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.AgingCorrectList = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.DaysheetCorrectList);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 409);
            this.panel3.TabIndex = 2;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(0, 389);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(178, 23);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "DAYSHEET";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // DaysheetCorrectList
            // 
            this.DaysheetCorrectList.Dock = System.Windows.Forms.DockStyle.Top;
            this.DaysheetCorrectList.FormattingEnabled = true;
            this.DaysheetCorrectList.ItemHeight = 15;
            this.DaysheetCorrectList.Location = new System.Drawing.Point(0, 40);
            this.DaysheetCorrectList.Name = "DaysheetCorrectList";
            this.DaysheetCorrectList.Size = new System.Drawing.Size(178, 349);
            this.DaysheetCorrectList.TabIndex = 3;
            this.DaysheetCorrectList.SelectedIndexChanged += new System.EventHandler(this.DaysheetCorrectList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "    DAYSHEET FILE NAME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.iconButton2);
            this.panel4.Controls.Add(this.LCFcorrectList);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(194, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 415);
            this.panel4.TabIndex = 6;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(0, 389);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(184, 23);
            this.iconButton2.TabIndex = 7;
            this.iconButton2.Text = "LCF";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // LCFcorrectList
            // 
            this.LCFcorrectList.Dock = System.Windows.Forms.DockStyle.Top;
            this.LCFcorrectList.FormattingEnabled = true;
            this.LCFcorrectList.ItemHeight = 15;
            this.LCFcorrectList.Location = new System.Drawing.Point(0, 40);
            this.LCFcorrectList.Name = "LCFcorrectList";
            this.LCFcorrectList.Size = new System.Drawing.Size(184, 349);
            this.LCFcorrectList.TabIndex = 3;
            this.LCFcorrectList.SelectedIndexChanged += new System.EventHandler(this.LCFcorrectList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "             LCF FILE NAME";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.iconButton3);
            this.panel5.Controls.Add(this.AgingCorrectList);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(384, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 415);
            this.panel5.TabIndex = 7;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(0, 389);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(197, 23);
            this.iconButton3.TabIndex = 8;
            this.iconButton3.Text = "AGING";
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // AgingCorrectList
            // 
            this.AgingCorrectList.Dock = System.Windows.Forms.DockStyle.Top;
            this.AgingCorrectList.FormattingEnabled = true;
            this.AgingCorrectList.ItemHeight = 15;
            this.AgingCorrectList.Location = new System.Drawing.Point(0, 40);
            this.AgingCorrectList.Name = "AgingCorrectList";
            this.AgingCorrectList.Size = new System.Drawing.Size(197, 349);
            this.AgingCorrectList.TabIndex = 3;
            this.AgingCorrectList.SelectedIndexChanged += new System.EventHandler(this.AgingCorrectList_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(0, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "      AGING FILE NAME";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 21);
            this.label9.TabIndex = 0;
            // 
            // Rename_Source_File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(732, 409);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rename_Source_File";
            this.Text = "Rename_Source_File";
            this.Load += new System.EventHandler(this.Rename_Source_File_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel3;
        private ListBox DaysheetCorrectList;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private ListBox LCFcorrectList;
        private Label label5;
        private Panel panel5;
        private ListBox AgingCorrectList;
        private Label label8;
        private Label label9;
        private Label label6;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}