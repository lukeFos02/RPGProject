﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProject.Classes
{
    public class Player
    {
        //data
        public string name;
        public int health;
        public Weapon currentWeapon;
        public Armour currentArmour;
        public List<Weapon> weapons;
        public List<Armour> armours;

        //getters
        public string GetName()
        {
            return name;
        }

        public int GetHealth()
        {
            return health;
        }

        public Weapon GetWeapon()
        {
            return currentWeapon;
        }

        public Armour GetArmour()
        {
            return currentArmour;
        }

        public List<Weapon> GetAllWeapons()
        {
            return weapons;
        }

        public List<Armour> GetAllArmour()
        {
            return armours; 
        }

        //setters
        public Player(string name, int health, Weapon currentWeapon, Armour currentArmour, Weapon firstWeapon, Armour firstArmour)
        {
            this.name = name;
            this.health = health;
            this.currentWeapon = currentWeapon;
            this.currentArmour = currentArmour;
            this.weapons = new List<Weapon> { firstWeapon};
            this.armours = new List<Armour> { firstArmour };
        }

        public void GiveWeapon(Weapon weapon)
        {
            currentWeapon = weapon;
            weapons.Add(weapon);
        }

        public void GiveArmour(Armour armour)
        {
            currentArmour = armour; 
            armours.Add(armour);    
        }

        public Player()
        {

        }
    }
}
