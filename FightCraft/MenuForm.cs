using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
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
            try {
                SoundPlayer bgm = new SoundPlayer(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources\\sakura.wav"));
                bgm.PlayLooping();
            }
            catch(Exception e)
            {
                MessageBox.Show("Audio file missing. Copy the Resources folder to the location of the .exe file : " +e.Message);
            }
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
            switch (MessageBox.Show(this, "Are you sure you want to quit?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}