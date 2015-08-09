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
    public partial class WeaponsForm : Form
    {
        public WeaponsForm()
        {
            InitializeComponent();
            updateGold();
        }

        void updateGold()
        {
            MyGold.Text = GameScreen.getMyGold().ToString();
        }

        private void BuyHealButton_Click(object sender, EventArgs e)
        {
            int myGold = GameScreen.getMyGold();
            if(myGold >= GameConstants.healCost)
            {
                GameScreen.reduceGold(GameConstants.healCost);
                GameScreen.increaseHealth(GameConstants.healHealth);
                updateGold();
                MessageBox.Show("Item purchased.");
            }
            else
            {
                MessageBox.Show("Not enough gold");
            }
        }

        private void BuyWeaponBasicButton_Click(object sender, EventArgs e)
        {
            int myGold = GameScreen.getMyGold();
            if (myGold >= GameConstants.damageBasicCost)
            {
                GameScreen.reduceGold(GameConstants.damageBasicCost);
                GameScreen.increaseDamage(GameConstants.damageBasic);
                updateGold();
                MessageBox.Show("Item purchased.");
            }
            else
            {
                MessageBox.Show("Not enough gold");
            }
        }

        private void BuyWeaponUltraButton_Click(object sender, EventArgs e)
        {
            int myGold = GameScreen.getMyGold();
            if (myGold >= GameConstants.damageUltraCost)
            {
                GameScreen.reduceGold(GameConstants.damageUltraCost);
                GameScreen.increaseDamage(GameConstants.damageUltimate);
                updateGold();
                MessageBox.Show("Item purchased.");
            }
            else
            {
                MessageBox.Show("Not enough gold");
            }
        }

        private void BuyArmorBasicButton_Click(object sender, EventArgs e)
        {
            int myGold = GameScreen.getMyGold();
            if (myGold >= GameConstants.armorBasicCost)
            {
                GameScreen.reduceGold(GameConstants.armorBasicCost);
                GameScreen.increaseArmor(GameConstants.armorBasic);
                updateGold();
                MessageBox.Show("Item purchased.");
            }
            else
            {
                MessageBox.Show("Not enough gold");
            }
        }

        private void BuyArmorUltraButton_Click(object sender, EventArgs e)
        {
            int myGold = GameScreen.getMyGold();
            if (myGold >= GameConstants.armorUltimateCost)
            {
                GameScreen.reduceGold(GameConstants.armorUltimateCost);
                GameScreen.increaseArmor(GameConstants.armorUltimate);
                updateGold();
                MessageBox.Show("Item purchased.");
            }
            else
            {
                MessageBox.Show("Not enough gold");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}