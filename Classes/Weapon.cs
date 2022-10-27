using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProject.Classes
{
    public class Weapon
    {
        public string name;
        public int attack;

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
                new Weapon("Wood Sword", 10),
            };
        }

        public static Weapon LoadWoodSword()
        {
            return new Weapon("Wood Sword", 10);
        }
    }
}
