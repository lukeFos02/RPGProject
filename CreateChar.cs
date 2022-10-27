﻿using RPGProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace RPGProject
{
    public partial class CreateChar : Form
    {
        List<Weapon> AllWeapons = Weapon.LoadWeapons();
        List<Armour> AllArmours = Armour.LoadArmours();
        Weapon StarterWeapon = Weapon.LoadWoodSword();
        Armour StarterArmour = Armour.LoadWoodArmour();
        public CreateChar()
        {
            InitializeComponent();
        }

        private void BeginBtn_Click(object sender, EventArgs e)
        {
            if (NameTB.Text.Length > 0)
            {
                Player player = new Player(NameTB.Text, 50, StarterWeapon, StarterArmour, StarterWeapon, StarterArmour);
                SaveManagement.SavePlayer(player);
                Close();
            }
            else
            {
                MessageBox.Show("You Must Give Yourself A Name");
            }
        }
    }
}