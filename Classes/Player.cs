using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProject.Classes
{
    public class Player
    {
        public string name;
        public int health;
        public Weapon currentWeapon;
        public Armour currentArmour;
        public List<Weapon> weapons;
        public List<Armour> armours;

        public Player(string name, int health, Weapon currentWeapon, Armour currentArmour, Weapon firstWeapon, Armour firstArmour)
        {
            this.name = name;
            this.health = health;
            this.currentWeapon = currentWeapon;
            this.currentArmour = currentArmour;
            this.weapons = new List<Weapon> { firstWeapon};
            this.armours = new List<Armour> { firstArmour };
        }
        public Player()
        {

        }
    }
}
