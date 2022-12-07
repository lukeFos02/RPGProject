using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGProject.Classes
{
    public class Enemy : Entity
    {
        //data (all based of enitiy atm)

        //setters
        public Enemy(string name, int health, int attack, int defence) : base(name, health, attack, defence)
        {
            this.name = name;   
            this.health = health;
            this.attack = attack;
            this.defence = defence;
        }

        //functions
        public Enemy LoadSlime()
        {
            return new Enemy("Slime", 30, 25, 10);
        }
        public Enemy GetNewEnemy(string loction)
        {
            if (loction == "Forest")
            {
                Enemy CurrentEnemy = new Enemy("PlaceHolder", 1, 1, 1);
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
			int random = rng.Next(((player.Health / 20) * -1), (player.Health / 20));
			int damage = currentEnemy.Attack - (player.Defence) + random;
            if (damage < 0) { return 0; }
            return damage;
		}
    }
}

