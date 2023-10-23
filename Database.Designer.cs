namespace MIS
{
    partial class Database
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.butMasterExceView = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 327);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 23);
            this.panel1.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, -5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(144, 28);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Login To Box";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // butMasterExceView
            // 
            this.butMasterExceView.FlatAppearance.BorderSize = 0;
            this.butMasterExceView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMasterExceView.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butMasterExceView.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.butMasterExceView.IconColor = System.Drawing.Color.Black;
            this.butMasterExceView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butMasterExceView.IconSize = 35;
            this.butMasterExceView.Location = new System.Drawing.Point(12, 12);
            this.butMasterExceView.Name = "butMasterExceView";
            this.butMasterExceView.Size = new System.Drawing.Size(102, 89);
            this.butMasterExceView.TabIndex = 4;
            this.butMasterExceView.Text = "To View Master Data Base";
            this.butMasterExceView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butMasterExceView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.butMasterExceView.UseVisualStyleBackColor = true;
            this.butMasterExceView.Click += new System.EventHandler(this.butMasterExceView_Click);
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 350);
            this.Controls.Add(this.butMasterExceView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Database";
            this.Text = "Database";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton butMasterExceView;
    }
}