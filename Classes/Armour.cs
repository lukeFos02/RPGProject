using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RPGProject.Classes
{
    public class Armour
    {
        private string name;
        private int defence;

        public string Name { get { return name; } set { name = value; } } 
        public int Defence { get { return defence; } set { defence = value; } }   

        public Armour(string name, int defence)
        {
            this.name = name;
            this.defence = defence;
        }

        public Armour()
        {

        }
        public static List<Armour> LoadArmours()
        {
            return new List<Armour>
            {
                new Armour("Developer's Armour", 999),
                new Armour("Wood Armour", 10),
            };
        }

        public static Armour LoadDeveloperArmour()
        {
            return new Armour("Developer's Armour", 999);
        }
        public static Armour LoadWoodArmour()
        {
            return new Armour("Wood Armour", 10);
        }
    }
}
