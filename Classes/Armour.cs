using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RPGProject.Classes
{
    public class Armour : Entity
    {
        public Armour(string name, int health, int attack, int defence) : base(name, health, attack, defence)
        {
            this.name = name;
            this.health = health;
            this.attack = attack;   
            this.defence = defence;
        }
        public Armour()
        {

        }
        public static List<Armour> LoadArmours()
        {
            return new List<Armour>
            {
                new Armour("Developer's Armour", 999, 999, 999),
                new Armour("Wood Armour", 0, 0, 10),
            };
        }

        public static Armour LoadDeveloperArmour()
        {
            return new Armour("Developer's Armour", 999, 999, 999);
        }
        public static Armour LoadWoodArmour()
        {
            return new Armour("Wood Armour", 0, 0, 10);
        }
    }
}
