using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProject.Classes
{
	public class Entity
	{
		protected string name;
		protected int health;
		protected int attack;
		protected int defence;

		public string Name { get { return name; } set { name = value; } }
		public int Health { get { return health; } set { health = value; } }
		public int Attack { get { return attack; } set { attack = value; } }
		public int Defence { get { return defence; } set { defence = value; } }

		public Entity(string name, int health, int attack, int defence)
		{
			this.name = name;
			this.health = health;	
			this.attack = attack;	
			this.defence = defence;	
		}
		//parameterless constructor needed for saving
		public Entity()
		{

		}
	}
}
