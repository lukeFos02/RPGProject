using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RPGProject.Classes
{
    public class Player
    {
        //data
        private string name;
        private int health;
        private int attack;
        private int defence;
        private Weapon currentWeapon;
        private Armour currentArmour;
        private List<Weapon> weapons;
        private List<Armour> armours;

        //getters/setters
        public string Name { get { return name; } set { name = value; } }
        public int Health { get { return health; } set { health = value; } }
		public int Attack { get { return attack; } set { attack = value; } }
		public int Defence { get { return defence; } set { defence = value; } }
		public Weapon CurrentWeapon { get { return currentWeapon; } set { currentWeapon = value; } } 
        public Armour CurrentArmour { get { return currentArmour; } set { currentArmour = value; } }  
        public List<Weapon> Weapons { get { return weapons; } set { weapons = value; } }
        public List<Armour> Armours { get { return armours; } set { armours = value; } }  
        public Player(string name)
        {
            this.name = name;
            this.health = 50;
            this.currentWeapon = Weapon.LoadWoodSword();
            this.currentArmour = Armour.LoadWoodArmour();
            this.attack = 10 + currentWeapon.Attack;
            this.defence = 10 + currentArmour.Defence;
            this.weapons = new List<Weapon> { Weapon.LoadWoodSword() };
            this.armours = new List<Armour> { Armour.LoadWoodArmour() };
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
