namespace RPGProject
{
    partial class CreateChar
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.BeginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(23, 35);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(35, 13);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Name";
            this.NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(64, 32);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(100, 20);
            this.NameTB.TabIndex = 1;
            // 
            // BeginBtn
            // 
            this.BeginBtn.Location = new System.Drawing.Point(64, 70);
            this.BeginBtn.Name = "BeginBtn";
            this.BeginBtn.Size = new System.Drawing.Size(75, 23);
            this.BeginBtn.TabIndex = 2;
            this.BeginBtn.Text = "Begin";
            this.BeginBtn.UseVisualStyleBackColor = true;
            this.BeginBtn.Click += new System.EventHandler(this.BeginBtn_Click);
            // 
            // CreateChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 122);
            this.Controls.Add(this.BeginBtn);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.NameLbl);
            this.Name = "CreateChar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button BeginBtn;
    }
}