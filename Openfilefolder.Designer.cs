namespace MIS
{
    partial class Openfilefolder
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
            this.txtfilechossing = new System.Windows.Forms.TextBox();
            this.butChoose = new FontAwesome.Sharp.IconButton();
            this.butUpload = new FontAwesome.Sharp.IconButton();
            this.butCansel = new FontAwesome.Sharp.IconButton();
            this.labMissingFIleName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtfilechossing
            // 
            this.txtfilechossing.Location = new System.Drawing.Point(45, 41);
            this.txtfilechossing.Name = "txtfilechossing";
            this.txtfilechossing.Size = new System.Drawing.Size(406, 23);
            this.txtfilechossing.TabIndex = 0;
            // 
            // butChoose
            // 
            this.butChoose.FlatAppearance.BorderSize = 0;
            this.butChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butChoose.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.butChoose.IconColor = System.Drawing.Color.White;
            this.butChoose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butChoose.IconSize = 40;
            this.butChoose.Location = new System.Drawing.Point(6, 30);
            this.butChoose.Name = "butChoose";
            this.butChoose.Size = new System.Drawing.Size(33, 34);
            this.butChoose.TabIndex = 1;
            this.butChoose.UseVisualStyleBackColor = true;
            this.butChoose.Click += new System.EventHandler(this.butChoose_Click_1);
            // 
            // butUpload
            // 
            this.butUpload.FlatAppearance.BorderSize = 0;
            this.butUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butUpload.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.butUpload.IconColor = System.Drawing.Color.White;
            this.butUpload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butUpload.IconSize = 35;
            this.butUpload.Location = new System.Drawing.Point(457, 34);
            this.butUpload.Name = "butUpload";
            this.butUpload.Size = new System.Drawing.Size(56, 34);
            this.butUpload.TabIndex = 2;
            this.butUpload.UseVisualStyleBackColor = true;
            this.butUpload.Click += new System.EventHandler(this.butUpload_Click);
            // 
            // butCansel
            // 
            this.butCansel.FlatAppearance.BorderSize = 0;
            this.butCansel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCansel.IconChar = FontAwesome.Sharp.IconChar.Xbox;
            this.butCansel.IconColor = System.Drawing.Color.White;
            this.butCansel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butCansel.IconSize = 35;
            this.butCansel.Location = new System.Drawing.Point(519, 34);
            this.butCansel.Name = "butCansel";
            this.butCansel.Size = new System.Drawing.Size(48, 34);
            this.butCansel.TabIndex = 3;
            this.butCansel.UseVisualStyleBackColor = true;
            this.butCansel.Click += new System.EventHandler(this.butCansel_Click);
            // 
            // labMissingFIleName
            // 
            this.labMissingFIleName.AutoSize = true;
            this.labMissingFIleName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labMissingFIleName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labMissingFIleName.ForeColor = System.Drawing.Color.White;
            this.labMissingFIleName.Location = new System.Drawing.Point(12, 9);
            this.labMissingFIleName.Name = "labMissingFIleName";
            this.labMissingFIleName.Size = new System.Drawing.Size(0, 19);
            this.labMissingFIleName.TabIndex = 4;
            this.labMissingFIleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Openfilefolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(572, 69);
            this.Controls.Add(this.labMissingFIleName);
            this.Controls.Add(this.butCansel);
            this.Controls.Add(this.butUpload);
            this.Controls.Add(this.butChoose);
            this.Controls.Add(this.txtfilechossing);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Openfilefolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Openfilefolder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtfilechossing;
        private FontAwesome.Sharp.IconButton butChoose;
        private FontAwesome.Sharp.IconButton butUpload;
        private FontAwesome.Sharp.IconButton butCansel;
        private Label labMissingFIleName;
    }
}