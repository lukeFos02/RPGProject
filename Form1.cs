﻿using RPGProject.Classes;
using RPGProject.Services;
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
        Player Player = new Player("", 1, 1, 1);
        List<Weapon> AllWeapons = Weapon.LoadWeapons();
        List<Armour> AllArmour = Armour.LoadArmours();
        string CurrentLocation = "";
        Enemy Opponent = new Enemy("PlaceHolder", 0, 0, 0);
		int OpponentFullHealth = 0;
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
            Player = SaveManagement.LoadPLayer();
            if (Player.Name != null && Player.Name != "Default")
            {
                TestLb.Text = Player.Name;
                WeaponLbl.Text = Player.CurrentWeapon.Name;
                Player.Attack = 10 + Player.CurrentWeapon.Attack;
                Player.Defence = 10 + Player.CurrentArmour.Defence;
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
                HealthPb.Maximum = Player.Health;
                HealthPb.Value = Player.Health;
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
                    HUDBtn2.Text = "Go Back";
                    HUDBtn3.Text = "";
                    HUDBtn4.Text = "";
					CurrentLocation = "Forest";
					HUDTb.AppendText("Current Location - Forest");
                    HUDTb.AppendText(Environment.NewLine);
                    break;
                case "Fight":
					Opponent = Opponent.GetNewEnemy(CurrentLocation);
                    OpponentPB.Visible= true;
                    OpponentPB.Maximum = Opponent.Health;
                    OpponentPB.Value = Opponent.Health;
					OpponentFullHealth = Opponent.Health;
					HUDTb.AppendText(Opponent.Name + " Approches!");
					HUDTb.AppendText(Environment.NewLine);
                    HUDBtn1.Text = "Attack";
                    HUDBtn2.Text = "Defend";
                    HUDBtn3.Text = "Run";
					break;
                case "Attack":
					var rng = new Random();
                    int random = rng.Next((OpponentFullHealth / 20) * -1, (OpponentFullHealth / 20));
					int damage = Player.Attack - (Opponent.Defence) + random;
                    Opponent.Health = Opponent.Health - damage;
                    if(Opponent.Health > 0)
                    {
						OpponentPB.Value = OpponentPB.Value - damage;
					}
                    else
                    {
						HUDTb.AppendText(Opponent.Name + " Is Defeated!");
						HUDTb.AppendText(Environment.NewLine);
                        OpponentPB.Visible = false;
						HUDBtn1.Text = "Fight";
						HUDBtn2.Text = "Go Back";
						HUDBtn3.Text = "";
						HUDBtn4.Text = "";
					}
                    int damageTaken = Opponent.EnemyAttack(Opponent, Player);
                    Player.Health = Player.Health - damageTaken;
                    if(Player.Health > 0)
                    {
                        HealthPb.Value = HealthPb.Value - damageTaken;
                    }
                    else
                    {
						HUDTb.AppendText("You Have Been Defeated");
						HUDTb.AppendText(Environment.NewLine);
						OpponentPB.Visible = false;
						HUDBtn1.Text = "Go Out Of Town";
						HUDBtn2.Text = "Blacksmith";
						HUDBtn3.Text = "Stats";
						HUDBtn4.Text = "Save";
					}
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
                case "Go Back":
					HUDTb.AppendText("Current Location - Outside Town");
					HUDTb.AppendText(Environment.NewLine);
					HUDBtn1.Text = "Go To Forest";
					HUDBtn2.Text = "Go To Caves";
					HUDBtn3.Text = "Go Back To Town";
					HUDBtn4.Text = "";
					break;
				case "Defend":
                    Player.Defence = Player.Defence + 5;
					int damageTaken = Opponent.EnemyAttack(Opponent, Player);
					Player.Health = Player.Health - damageTaken;
					if (Player.Health > 0)
					{
						HealthPb.Value = HealthPb.Value - damageTaken;
					}
					else
					{
						HUDTb.AppendText("You Have Been Defeated");
						HUDTb.AppendText(Environment.NewLine);
						OpponentPB.Visible = false;
						HUDBtn1.Text = "Go Out Of Town";
						HUDBtn2.Text = "Blacksmith";
						HUDBtn3.Text = "Stats";
						HUDBtn4.Text = "Save";
					}
                    Player.Defence = Player.Defence - 5;
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
                case "Run":
					var rng = new Random();
                    int runChance = rng.Next(1, 100);
                    if(runChance > 25)
                    {
						HUDTb.AppendText("Got Away From " + Opponent.Name);
						HUDTb.AppendText(Environment.NewLine);
                        OpponentPB.Visible = false;
						HUDBtn1.Text = "Fight";
						HUDBtn2.Text = "Go Back";
						HUDBtn3.Text = "";
						HUDBtn4.Text = "";
					}
                    else
                    {
						HUDTb.AppendText("Could Not Escape " + Opponent.Name);
						HUDTb.AppendText(Environment.NewLine);
					}
					int damageTaken = Opponent.EnemyAttack(Opponent, Player);
					Player.Health = Player.Health - damageTaken;
					if (Player.Health > 0)
					{
						HealthPb.Value = HealthPb.Value - damageTaken;
					}
					else
					{
						HUDTb.AppendText("You Have Been Defeated");
						HUDTb.AppendText(Environment.NewLine);
						OpponentPB.Visible = false;
						HUDBtn1.Text = "Go Out Of Town";
						HUDBtn2.Text = "Blacksmith";
						HUDBtn3.Text = "Stats";
						HUDBtn4.Text = "Save";
					}
					break;
            }
        }

        private void HUDBtn4_Click(object sender, EventArgs e)
        {
            switch (HUDBtn4.Text)
            {
                case "Save":
                    SaveManagement.SavePlayer(Player);
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
