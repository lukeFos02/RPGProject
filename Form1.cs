using RPGProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGProject
{
    public partial class Form1 : Form
    {
        Player player = new Player();
        public Form1()
        {
            InitializeComponent();
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            CreateChar createChar = new CreateChar();
            createChar.Show();
            NewGameBtn.Enabled = false;
            NewGameBtn.Visible = false;
            ContinueBtn.Enabled = false;    
            ContinueBtn.Visible = false;    
        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            player = SaveManagement.LoadPLayer();
            if (player.name != null && player.name != "Default")
            {
                TestLb.Text = "Name: " + player.name;
                NewGameBtn.Enabled = false;
                NewGameBtn.Visible = false;
                ContinueBtn.Enabled = false;
                ContinueBtn.Visible = false;
            }
        }
    }
}
