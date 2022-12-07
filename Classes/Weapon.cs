using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RPGProject.Classes
{
    public class Weapon : Entity
    {
        public Weapon(string name, int health, int attack, int defence) : base(name, health, attack, defence)
        {
            this.name = name;
            this.health = health;
            this.attack = attack;
            this.defence = defence;
        }
        public Weapon()
        {

        }

        public static List<Weapon> LoadWeapons()
        {
            return new List<Weapon>
            {
                new Weapon("Developer's Sword", 999, 999, 999),
                new Weapon("Wood Sword", 0, 10, 0),
            };
        }

        public static Weapon LoadDeveloperSword()
        {
            return new Weapon("Developer's Sword", 999, 999, 999);
        }
        public static Weapon LoadWoodSword()
        {
            return new Weapon("Wood Sword", 0, 10, 0);
        }
    }
}
