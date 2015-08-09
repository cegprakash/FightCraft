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
        public MenuForm()
        {
            InitializeComponent();
 
    }
        void gameScreenClosed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
            this.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form gameScreen = new GameScreen();
            gameScreen.Activate();
            gameScreen.Show();
            gameScreen.FormClosed += new FormClosedEventHandler(gameScreenClosed);

            gameScreen.BringToFront();
            this.Hide();
        }




        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }
    }
}