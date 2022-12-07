using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGProject.Classes
{
    public class Enemy
    {
        //data
        private string name;
        private int health;
        private int attack;
        private int defence;

        public string Name { get { return name; } set { name = value; } }
        public int Health { get { return health; } set { health = value; } }
        public int Attack { get { return attack; } set { attack = value; } }
        public int Defence { get { return defence; } set { defence = value; } }

        //setters
        public Enemy()
        {

        }
        private Enemy(string name, int health, int attack, int defence)
        {
            this.name = name;   
            this.health = health;
            this.attack = attack;
            this.defence = defence;
        }

        //functions
        public Enemy LoadSlime()
        {
            return new Enemy("Slime", 30, 10, 10);
        }
        public Enemy GetNewEnemy(string loction)
        {
            if (loction == "Forest")
            {
                Enemy CurrentEnemy = new Enemy();
                CurrentEnemy = CurrentEnemy.LoadSlime();
                return CurrentEnemy;
            }
            else
            {
                MessageBox.Show("Error: Failed To Load Enemy");
                return null;
            }
        }
        public int EnemyAttack(Enemy currentEnemy, Player player)
        {
			var rng = new Random();
			int random = rng.Next((player.Health / 20) * -1, (player.Health / 20));
			int damage = currentEnemy.Attack - (player.Defence) + random;
            return damage;
		}
    }
}

