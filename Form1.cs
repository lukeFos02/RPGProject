using RPGProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGProject
{
    public partial class Form1 : Form
    {
        Player player = new Player();
        public Form1()
        {
            InitializeComponent();
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            CreateChar createChar = new CreateChar();
            createChar.Show();
        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            player = SaveManagement.LoadPLayer();
            if (player.GetName() != null && player.GetName() != "Default")
            {
                TestLb.Text = player.GetName();
                NewGameBtn.Enabled = false;
                NewGameBtn.Visible = false;
                ContinueBtn.Enabled = false;
                ContinueBtn.Visible = false;
                HUDPanel.Visible = true;
                HUDTb.Visible = true;
                HUDBtn1.Visible = true;
                HUDBtn2.Visible = true;
                HUDBtn3.Visible = true;
                HUDBtn4.Visible = true;
                HealthPb.Visible = true;
                HealthPb.Maximum = player.GetHealth();
                HealthPb.Value = player.GetHealth();
                HUDTb.AppendText("Current Location: Town");
                HUDTb.AppendText(Environment.NewLine);
                HUDTb.AppendText("Remember You Can Only Save While In Town");
                HUDTb.AppendText(Environment.NewLine);
                HUDBtn1.Text = "Go Out Of Town";
                HUDBtn2.Text = "Blacksmith";
                HUDBtn3.Text = "Stats";
                HUDBtn4.Text = "Save";
            }
        }
    }
}
