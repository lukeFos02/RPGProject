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
            this.HealthPb = new System.Windows.Forms.ProgressBar();
            this.HUBTb = new System.Windows.Forms.TextBox();
            this.HUDBtn4 = new System.Windows.Forms.Button();
            this.HUDBtn3 = new System.Windows.Forms.Button();
            this.HUDBtn2 = new System.Windows.Forms.Button();
            this.HUDBtn1 = new System.Windows.Forms.Button();
            this.HUDPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.Location = new System.Drawing.Point(708, 250);
            this.NewGameBtn.Margin = new System.Windows.Forms.Padding(4);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(233, 87);
            this.NewGameBtn.TabIndex = 0;
            this.NewGameBtn.Text = "New Game";
            this.NewGameBtn.UseVisualStyleBackColor = true;
            this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // ContinueBtn
            // 
            this.ContinueBtn.Location = new System.Drawing.Point(708, 401);
            this.ContinueBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ContinueBtn.Name = "ContinueBtn";
            this.ContinueBtn.Size = new System.Drawing.Size(233, 87);
            this.ContinueBtn.TabIndex = 1;
            this.ContinueBtn.Text = "Continue";
            this.ContinueBtn.UseVisualStyleBackColor = true;
            this.ContinueBtn.Click += new System.EventHandler(this.ContinueBtn_Click);
            // 
            // TestLb
            // 
            this.TestLb.AutoSize = true;
            this.TestLb.Location = new System.Drawing.Point(718, 9);
            this.TestLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TestLb.Name = "TestLb";
            this.TestLb.Size = new System.Drawing.Size(52, 16);
            this.TestLb.TabIndex = 2;
            this.TestLb.Text = "(Name)";
            // 
            // HUDPanel
            // 
            this.HUDPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HUDPanel.Controls.Add(this.HealthPb);
            this.HUDPanel.Controls.Add(this.TestLb);
            this.HUDPanel.Controls.Add(this.HUBTb);
            this.HUDPanel.Controls.Add(this.HUDBtn4);
            this.HUDPanel.Controls.Add(this.HUDBtn3);
            this.HUDPanel.Controls.Add(this.HUDBtn2);
            this.HUDPanel.Controls.Add(this.HUDBtn1);
            this.HUDPanel.Location = new System.Drawing.Point(13, 609);
            this.HUDPanel.Name = "HUDPanel";
            this.HUDPanel.Size = new System.Drawing.Size(1660, 217);
            this.HUDPanel.TabIndex = 3;
            this.HUDPanel.Visible = false;
            // 
            // HealthPb
            // 
            this.HealthPb.ForeColor = System.Drawing.Color.Lime;
            this.HealthPb.Location = new System.Drawing.Point(721, 28);
            this.HealthPb.Name = "HealthPb";
            this.HealthPb.Size = new System.Drawing.Size(395, 35);
            this.HealthPb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.HealthPb.TabIndex = 5;
            this.HealthPb.Visible = false;
            // 
            // HUBTb
            // 
            this.HUBTb.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HUBTb.Location = new System.Drawing.Point(4, 4);
            this.HUBTb.Multiline = true;
            this.HUBTb.Name = "HUBTb";
            this.HUBTb.ReadOnly = true;
            this.HUBTb.Size = new System.Drawing.Size(663, 208);
            this.HUBTb.TabIndex = 4;
            this.HUBTb.TabStop = false;
            this.HUBTb.Visible = false;
            // 
            // HUDBtn4
            // 
            this.HUDBtn4.Location = new System.Drawing.Point(1400, 110);
            this.HUDBtn4.Name = "HUDBtn4";
            this.HUDBtn4.Size = new System.Drawing.Size(232, 86);
            this.HUDBtn4.TabIndex = 3;
            this.HUDBtn4.Text = "HUD 4";
            this.HUDBtn4.UseVisualStyleBackColor = true;
            this.HUDBtn4.Visible = false;
            // 
            // HUDBtn3
            // 
            this.HUDBtn3.Location = new System.Drawing.Point(1162, 110);
            this.HUDBtn3.Name = "HUDBtn3";
            this.HUDBtn3.Size = new System.Drawing.Size(232, 86);
            this.HUDBtn3.TabIndex = 2;
            this.HUDBtn3.Text = "HUD 3";
            this.HUDBtn3.UseVisualStyleBackColor = true;
            this.HUDBtn3.Visible = false;
            // 
            // HUDBtn2
            // 
            this.HUDBtn2.Location = new System.Drawing.Point(1400, 18);
            this.HUDBtn2.Name = "HUDBtn2";
            this.HUDBtn2.Size = new System.Drawing.Size(232, 86);
            this.HUDBtn2.TabIndex = 1;
            this.HUDBtn2.Text = "HUD 2";
            this.HUDBtn2.UseVisualStyleBackColor = true;
            this.HUDBtn2.Visible = false;
            // 
            // HUDBtn1
            // 
            this.HUDBtn1.Location = new System.Drawing.Point(1162, 18);
            this.HUDBtn1.Name = "HUDBtn1";
            this.HUDBtn1.Size = new System.Drawing.Size(232, 86);
            this.HUDBtn1.TabIndex = 0;
            this.HUDBtn1.Text = "HUD 1";
            this.HUDBtn1.UseVisualStyleBackColor = true;
            this.HUDBtn1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.HUDPanel);
            this.Controls.Add(this.ContinueBtn);
            this.Controls.Add(this.NewGameBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox HUBTb;
    }
}

