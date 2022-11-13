namespace RPGProject
{
    partial class Form1
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
            this.NewGameBtn = new System.Windows.Forms.Button();
            this.ContinueBtn = new System.Windows.Forms.Button();
            this.TestLb = new System.Windows.Forms.Label();
            this.HUDPanel = new System.Windows.Forms.Panel();
            this.WeaponLbl = new System.Windows.Forms.Label();
            this.HealthPb = new System.Windows.Forms.ProgressBar();
            this.HUDTb = new System.Windows.Forms.TextBox();
            this.HUDBtn4 = new System.Windows.Forms.Button();
            this.HUDBtn3 = new System.Windows.Forms.Button();
            this.HUDBtn2 = new System.Windows.Forms.Button();
            this.HUDBtn1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BlacksmithLB = new System.Windows.Forms.ListBox();
            this.HUDPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.Location = new System.Drawing.Point(531, 203);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(175, 71);
            this.NewGameBtn.TabIndex = 0;
            this.NewGameBtn.Text = "New Game";
            this.NewGameBtn.UseVisualStyleBackColor = true;
            this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // ContinueBtn
            // 
            this.ContinueBtn.Location = new System.Drawing.Point(531, 326);
            this.ContinueBtn.Name = "ContinueBtn";
            this.ContinueBtn.Size = new System.Drawing.Size(175, 71);
            this.ContinueBtn.TabIndex = 1;
            this.ContinueBtn.Text = "Continue";
            this.ContinueBtn.UseVisualStyleBackColor = true;
            this.ContinueBtn.Click += new System.EventHandler(this.ContinueBtn_Click);
            // 
            // TestLb
            // 
            this.TestLb.AutoSize = true;
            this.TestLb.Location = new System.Drawing.Point(538, 7);
            this.TestLb.Name = "TestLb";
            this.TestLb.Size = new System.Drawing.Size(41, 13);
            this.TestLb.TabIndex = 2;
            this.TestLb.Text = "(Name)";
            // 
            // HUDPanel
            // 
            this.HUDPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HUDPanel.Controls.Add(this.WeaponLbl);
            this.HUDPanel.Controls.Add(this.HealthPb);
            this.HUDPanel.Controls.Add(this.TestLb);
            this.HUDPanel.Controls.Add(this.HUDTb);
            this.HUDPanel.Controls.Add(this.HUDBtn4);
            this.HUDPanel.Controls.Add(this.HUDBtn3);
            this.HUDPanel.Controls.Add(this.HUDBtn2);
            this.HUDPanel.Controls.Add(this.HUDBtn1);
            this.HUDPanel.Location = new System.Drawing.Point(10, 495);
            this.HUDPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HUDPanel.Name = "HUDPanel";
            this.HUDPanel.Size = new System.Drawing.Size(1246, 177);
            this.HUDPanel.TabIndex = 3;
            this.HUDPanel.Visible = false;
            // 
            // WeaponLbl
            // 
            this.WeaponLbl.AutoSize = true;
            this.WeaponLbl.Location = new System.Drawing.Point(540, 55);
            this.WeaponLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeaponLbl.Name = "WeaponLbl";
            this.WeaponLbl.Size = new System.Drawing.Size(54, 13);
            this.WeaponLbl.TabIndex = 6;
            this.WeaponLbl.Text = "(Weapon)";
            // 
            // HealthPb
            // 
            this.HealthPb.ForeColor = System.Drawing.Color.Lime;
            this.HealthPb.Location = new System.Drawing.Point(541, 23);
            this.HealthPb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HealthPb.Name = "HealthPb";
            this.HealthPb.Size = new System.Drawing.Size(296, 28);
            this.HealthPb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.HealthPb.TabIndex = 5;
            this.HealthPb.Visible = false;
            // 
            // HUDTb
            // 
            this.HUDTb.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HUDTb.Location = new System.Drawing.Point(3, 3);
            this.HUDTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HUDTb.Multiline = true;
            this.HUDTb.Name = "HUDTb";
            this.HUDTb.ReadOnly = true;
            this.HUDTb.Size = new System.Drawing.Size(498, 170);
            this.HUDTb.TabIndex = 4;
            this.HUDTb.TabStop = false;
            this.HUDTb.Visible = false;
            // 
            // HUDBtn4
            // 
            this.HUDBtn4.Location = new System.Drawing.Point(1050, 89);
            this.HUDBtn4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HUDBtn4.Name = "HUDBtn4";
            this.HUDBtn4.Size = new System.Drawing.Size(174, 70);
            this.HUDBtn4.TabIndex = 3;
            this.HUDBtn4.Text = "HUD 4";
            this.HUDBtn4.UseVisualStyleBackColor = true;
            this.HUDBtn4.Visible = false;
            this.HUDBtn4.Click += new System.EventHandler(this.HUDBtn4_Click);
            // 
            // HUDBtn3
            // 
            this.HUDBtn3.Location = new System.Drawing.Point(872, 89);
            this.HUDBtn3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HUDBtn3.Name = "HUDBtn3";
            this.HUDBtn3.Size = new System.Drawing.Size(174, 70);
            this.HUDBtn3.TabIndex = 2;
            this.HUDBtn3.Text = "HUD 3";
            this.HUDBtn3.UseVisualStyleBackColor = true;
            this.HUDBtn3.Visible = false;
            this.HUDBtn3.Click += new System.EventHandler(this.HUDBtn3_Click);
            // 
            // HUDBtn2
            // 
            this.HUDBtn2.Location = new System.Drawing.Point(1050, 15);
            this.HUDBtn2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HUDBtn2.Name = "HUDBtn2";
            this.HUDBtn2.Size = new System.Drawing.Size(174, 70);
            this.HUDBtn2.TabIndex = 1;
            this.HUDBtn2.Text = "HUD 2";
            this.HUDBtn2.UseVisualStyleBackColor = true;
            this.HUDBtn2.Visible = false;
            this.HUDBtn2.Click += new System.EventHandler(this.HUDBtn2_Click);
            // 
            // HUDBtn1
            // 
            this.HUDBtn1.Location = new System.Drawing.Point(872, 15);
            this.HUDBtn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HUDBtn1.Name = "HUDBtn1";
            this.HUDBtn1.Size = new System.Drawing.Size(174, 70);
            this.HUDBtn1.TabIndex = 0;
            this.HUDBtn1.Text = "HUD 1";
            this.HUDBtn1.UseVisualStyleBackColor = true;
            this.HUDBtn1.Visible = false;
            this.HUDBtn1.Click += new System.EventHandler(this.HUDBtn1_Click);
            // 
            // BlacksmithLB
            // 
            this.BlacksmithLB.FormattingEnabled = true;
            this.BlacksmithLB.Location = new System.Drawing.Point(10, 44);
            this.BlacksmithLB.Name = "BlacksmithLB";
            this.BlacksmithLB.Size = new System.Drawing.Size(339, 446);
            this.BlacksmithLB.TabIndex = 4;
            this.BlacksmithLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.BlacksmithLB);
            this.Controls.Add(this.HUDPanel);
            this.Controls.Add(this.ContinueBtn);
            this.Controls.Add(this.NewGameBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPG Game";
            this.HUDPanel.ResumeLayout(false);
            this.HUDPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewGameBtn;
        private System.Windows.Forms.Button ContinueBtn;
        private System.Windows.Forms.Label TestLb;
        private System.Windows.Forms.Panel HUDPanel;
        private System.Windows.Forms.Button HUDBtn4;
        private System.Windows.Forms.Button HUDBtn3;
        private System.Windows.Forms.Button HUDBtn2;
        private System.Windows.Forms.Button HUDBtn1;
        private System.Windows.Forms.ProgressBar HealthPb;
        private System.Windows.Forms.TextBox HUDTb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label WeaponLbl;
        private System.Windows.Forms.ListBox BlacksmithLB;
    }
}

