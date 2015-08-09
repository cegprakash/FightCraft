﻿using System;
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
        bool isMyTurn;
        Hero myHero, enemyHero;
        GameConstants constants = new GameConstants();
        Random random = new Random();
        public GameScreen()
        {
            level = 1;
            isMyTurn = true;
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
            MyGold.Text = myHero.gold.ToString();
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
                isMyTurn = false;
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
                isMyTurn = false;
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
                isMyTurn = true;
                initMyTurn();
            }

        }

        public bool isGameWon()
        {
            return isEnemyDefeated() && enemyHero.level == 3;
        }
    }
}