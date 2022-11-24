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
        List<Weapon> AllWeapons = Weapon.LoadWeapons();
        List<Armour> AllArmour = Armour.LoadArmours();
        string CurrentLocation = null;
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
            if (player.Name != null && player.Name != "Default")
            {
                TestLb.Text = player.Name;
                WeaponLbl.Text = player.CurrentWeapon.Name;
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
                HealthPb.Maximum = player.Health;
                HealthPb.Value = player.Health;
                HUDTb.AppendText("Current Location - Town");
                HUDTb.AppendText(Environment.NewLine);
                HUDTb.AppendText("Remember You Can Only Save While In Town");
                HUDTb.AppendText(Environment.NewLine);
                HUDBtn1.Text = "Go Out Of Town";
                HUDBtn2.Text = "Blacksmith";
                HUDBtn3.Text = "Stats";
                HUDBtn4.Text = "Save";
            }
        }

        private void HUDBtn1_Click(object sender, EventArgs e)
        {
            switch (HUDBtn1.Text)
            {
                case "Go Out Of Town":
                    HUDTb.AppendText("Current Location - Outside Town");
                    HUDTb.AppendText(Environment.NewLine);
                    HUDBtn1.Text = "Go To Forest";
                    HUDBtn2.Text = "Go To Caves";
                    HUDBtn3.Text = "Go Back To Town";
                    HUDBtn4.Text = "";
                    break;
                case "Go To Forest":
                    HUDBtn1.Text = "Fight";
                    HUDBtn2.Text = "";
                    HUDBtn3.Text = "";
                    HUDBtn4.Text = "";
                    CurrentLocation = "Forest";
                    break;
                case "Fight":

                    break;
            }

        }

        private void HUDBtn2_Click(object sender, EventArgs e)
        {
            switch (HUDBtn2.Text)
            {
                case "Blacksmith":
                    foreach (Weapon w in AllWeapons)
                    {
                        BlacksmithLB.Items.Add(w.Name); 
                    }
                    foreach (Armour a in AllArmour)
                    {
                        BlacksmithLB.Items.Add(a.Name);
                    }
                    BlacksmithLB.DoubleClick += new EventHandler(BlacksmithLB_DoubleClick);
                    BlacksmithLB.Visible = true;
                    break;
            }
        }

        private void HUDBtn3_Click(object sender, EventArgs e)
        {
            switch (HUDBtn3.Text)
            {
                case "Go Back To Town":
                    HUDTb.AppendText("Current Location - Town");
                    HUDTb.AppendText(Environment.NewLine);
                    HUDTb.AppendText("Remember You Can Only Save While In Town");
                    HUDTb.AppendText(Environment.NewLine);
                    HUDBtn1.Text = "Go Out Of Town";
                    HUDBtn2.Text = "Blacksmith";
                    HUDBtn3.Text = "Stats";
                    HUDBtn4.Text = "Save";
                    break;
            }

        }

        private void HUDBtn4_Click(object sender, EventArgs e)
        {
            switch (HUDBtn4.Text)
            {
                case "Save":
                    SaveManagement.SavePlayer(player);
                    break;
            }
        }
        private void BlacksmithLB_DoubleClick(object sender, EventArgs e)
        {
            if (BlacksmithLB.SelectedItem != null)
            {
                MessageBox.Show(BlacksmithLB.SelectedItem.ToString());
            }
        }
    }
}
