using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightCraft
{
    public partial class GameScreen : Form
    {
        int level;
        static Hero myHero, enemyHero;
        GameConstants constants = new GameConstants();
        Random random = new Random();
        public GameScreen()
        {
            level = 1;
            InitializeComponent();
            initLevel(level);
            initMyTurn();
        }

        public void initLevel(int level)
        {
            myHero = constants.MyHero;
            myHero.level = level;
            switch (level) {
                case 1:
                    enemyHero = constants.Lvl1Enemy;
                    break;
                case 2:
                    enemyHero = constants.Lvl2Enemy;
                    break;
                case 3:
                    enemyHero = constants.Lvl3Enemy;
                    break;
                default:
                    throw new Exception("INVALID_LEVEL");
            }

            MyLevelLabel.Text = "Level " + myHero.level;
            EnemyLevelLabel.Text = "Level" + enemyHero.level;
            updateGold();
            try {
                MyHeroImage.BackgroundImage = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),myHero.imagePath));
                EnemyHeroImage.BackgroundImage = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), enemyHero.imagePath));
            }
            catch(Exception e)
            {
                MessageBox.Show("Images are missing. Please move the Images folder to the location of your exe file : "+e.Message);
            }
            updateBars();
            initMyTurn();
        }
        public void updateGold()
        {
            MyGold.Text = myHero.gold.ToString();
        }

        public void updateBars()
        {
            MyHealthBar.Value = (int)Math.Floor((myHero.currentState.health / myHero.attributes.health) * 100);
            MyArmorBar.Value = (int)Math.Floor((myHero.currentState.armor / myHero.attributes.armor) * 100);
            MyDamageBar.Value = (int)Math.Floor((myHero.currentState.damagePerHit / myHero.attributes.damagePerHit) * 100);
            MyManaBar.Value = (int)Math.Floor((myHero.currentState.mana / myHero.attributes.mana) * 100);
            EnemyHealthBar.Value = (int)Math.Floor((enemyHero.currentState.health / enemyHero.attributes.health) * 100);
            EnemyArmorBar.Value = (int)Math.Floor((enemyHero.currentState.armor / enemyHero.attributes.armor) * 100);
            EnemyDamageBar.Value = (int)Math.Floor((enemyHero.currentState.damagePerHit / enemyHero.attributes.damagePerHit) * 100);
            EnemyManaBar.Value = (int)Math.Floor((enemyHero.currentState.mana / enemyHero.attributes.mana) * 100);
            MyHealthLabel.Text = ((int)myHero.currentState.health).ToString();
            MyArmorLabel.Text = ((int)myHero.currentState.armor).ToString() + "%";
            MyDamageLabel.Text = ((int)myHero.currentState.damagePerHit).ToString();
            MyManaLabel.Text = ((int)myHero.currentState.mana).ToString();
            EnemyHealthLabel.Text = ((int)enemyHero.currentState.health).ToString();
            EnemyArmorLabel.Text = ((int)enemyHero.currentState.armor).ToString()+"%";
            EnemyDamageLabel.Text = ((int)enemyHero.currentState.damagePerHit).ToString();
            EnemyManaLabel.Text = ((int)enemyHero.currentState.mana).ToString();
        }

        public void initMyTurn()
        {
            PhysicalAttackButton.Enabled = true;
            MagicalAttackButton.Enabled = myHero.currentState.mana >= GameConstants.manaCost;        
        }

        public void initEnemyTurn()
        {
            PhysicalAttackButton.Enabled = false;
            MagicalAttackButton.Enabled = false;
        }


        public bool isGameLost()
        {
            return myHero.currentState.health <= 0;
        }

        public bool isEnemyDefeated()
        {
            return enemyHero.currentState.health <= 0;
        }

        void print(string message)
        {
            GameConsole.Text = message + "\n" + GameConsole.Text;
        }

        private void PhysicalAttackButton_Click(object sender, EventArgs e)
        {
            double damage = myHero.physicalAttack(enemyHero);
            print("You made a physical attack causing "+(int)damage+ " damage");
            updateBars();
            if (isGameWon())
            {
                MessageBox.Show("CONGRATS!! You have defeated all the bosses.");
                this.Close();
            }
            else if (isEnemyDefeated())
            {
                level++;
                initLevel(level);
                initMyTurn();
            }
            else
            {
                initEnemyTurn();
                play_enemy_AI();
            }
        }

        private void MagicalAttackButton_Click(object sender, EventArgs e)
        {
            Tuple<double, int> result = myHero.magicalAttack(enemyHero);
            updateBars();
            if (result.Item2 < 0)
                print("You striked a magical pure damage of " + (int)result.Item1 + ". But the enemy gained "+-result.Item2+" bonus armor");
            else
                print("You striked a magical pure damage of " + (int)result.Item1 + ". Also gained " + result.Item2+" bonus armor");
            if (isGameWon())
            {
                MessageBox.Show("CONGRATS!! You have defeated all the bosses.");
                this.Close();
            }
            else if (isEnemyDefeated())
            {
                level++;
                initLevel(level);
                initMyTurn();
            }
            else
            {
                initEnemyTurn();
                play_enemy_AI();
            }
        }

        public void play_enemy_AI()
        {
            if(enemyHero.currentState.mana < GameConstants.manaCost || random.Next()%2 == 0)
            {   //do physical attack
                double damage = enemyHero.physicalAttack(myHero);
                print("Enemy made a physical attack causing " + (int)damage + " damage");
            }
            else
            {
                //do magical attack
                Tuple<double, int> result = enemyHero.magicalAttack(myHero);
                if (result.Item2 < 0)
                    print("Enemy striked a magical pure damage of " + (int)result.Item1 + ". But you gained " + -result.Item2 + " bonus armor");
                else
                    print("Enemy striked a magical pure damage of " + (int)result.Item1 + ". Also gained " + result.Item2 + " bonus armor");
            }
            updateBars();
            if (isGameLost())
            {
                MessageBox.Show("OOPS!! The boss killed you.");
                this.Close();
            }
            else
            {
                initMyTurn();
            }

        }


        void shopFormClosed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
            this.BringToFront();
            updateGold();
            updateBars();
        }

        private void ShopButton_Click(object sender, EventArgs e)
        {
            Form shopForm = new WeaponsForm();
            shopForm.Activate();
            shopForm.Show();
            shopForm.FormClosed += new FormClosedEventHandler(shopFormClosed);
            shopForm.BringToFront();
            this.Hide();
        }

        public bool isGameWon()
        {
            return isEnemyDefeated() && enemyHero.level == 3;
        }

        public static int getMyGold()
        {
            return myHero.gold;
        }

        public static void reduceGold(int cost)
        {
            myHero.gold -= cost;
        }
        public static void increaseHealth(double health)
        {
            myHero.currentState.health = Math.Min(myHero.attributes.health, myHero.currentState.health + health);
        }
        
        public static void increaseDamage(double damage)
        {
            myHero.currentState.damagePerHit = Math.Min(myHero.attributes.damagePerHit, myHero.currentState.damagePerHit + damage);
        }

        public static void increaseArmor(double armor)
        {
            myHero.currentState.armor = Math.Min(myHero.attributes.armor, myHero.currentState.armor + armor);
        }
    }
}