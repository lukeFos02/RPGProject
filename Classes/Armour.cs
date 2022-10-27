using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProject.Classes
{
    public class Armour
    {
        public string name;
        public int defence;

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
                new Armour ("Wood Armour", 10),
            };
        }

        public static Armour LoadWoodArmour()
        {
            return new Armour("Wood Armour", 10);
        }
    }
}
