using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RPGProject.Classes
{
    public class Weapon 
    {
        private string name;
        private int attack;

        public string Name { get { return name; } set { name = value; } }
        public int Attack { get { return attack; } set { attack = value; } }  

        public Weapon(string name, int attack)
        {
            this.name = name;
            this.attack = attack;
        }

        public Weapon()
        {

        }

        public static List<Weapon> LoadWeapons()
        {
            return new List<Weapon>
            {
                new Weapon("Developer's Sword", 999),
                new Weapon("Wood Sword", 10),
            };
        }

        public static Weapon LoadDeveloperSword()
        {
            return new Weapon("Developer's Sword", 10);
        }
        public static Weapon LoadWoodSword()
        {
            return new Weapon("Wood Sword", 10);
        }
    }
}
