using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightCraft
{
    public partial class MenuForm : Form
    {
        Form gameScreen;
        public MenuForm()
        {
            InitializeComponent();
            gameScreen = new GameScreen();
            gameScreen.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameScreen.Activate();
            gameScreen.Show();
            gameScreen.BringToFront();
            this.Hide();
        }
    }
}