namespace MIS
{
    partial class File_Converstion
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
            this.LCFColumList = new System.Windows.Forms.ListBox();
            this.PracticeNameList = new System.Windows.Forms.ListBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LCFColumList
            // 
            this.LCFColumList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LCFColumList.FormattingEnabled = true;
            this.LCFColumList.ItemHeight = 15;
            this.LCFColumList.Location = new System.Drawing.Point(0, 15);
            this.LCFColumList.Name = "LCFColumList";
            this.LCFColumList.Size = new System.Drawing.Size(153, 334);
            this.LCFColumList.TabIndex = 0;
            this.LCFColumList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // PracticeNameList
            // 
            this.PracticeNameList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PracticeNameList.FormattingEnabled = true;
            this.PracticeNameList.ItemHeight = 15;
            this.PracticeNameList.Location = new System.Drawing.Point(0, 15);
            this.PracticeNameList.Name = "PracticeNameList";
            this.PracticeNameList.Size = new System.Drawing.Size(206, 334);
            this.PracticeNameList.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(435, 41);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(124, 45);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "File Converstion";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(435, 345);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(124, 45);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "LCF Check";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "              Practice Name                       ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "            Check                     ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PracticeNameList);
            this.panel1.Location = new System.Drawing.Point(45, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 349);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LCFColumList);
            this.panel2.Location = new System.Drawing.Point(276, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 349);
            this.panel2.TabIndex = 7;
            // 
            // File_Converstion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "File_Converstion";
            this.Text = "File_Converstion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox LCFColumList;
        private ListBox PracticeNameList;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
    }
}