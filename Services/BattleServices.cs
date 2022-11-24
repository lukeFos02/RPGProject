using RPGProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGProject.Services
{
    public class BattleServices
    {
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
    }
}
