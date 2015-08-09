using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightCraft
{
    public class Hero
    {
        public string imagePath;
        public Attributes attributes;
        public Attributes currentState;
        public int gold;
        public int level;
        Random random = new Random();


        public double physicalAttack(Hero enemy)
        {
            double damage = currentState.damagePerHit - (currentState.damagePerHit * enemy.currentState.armor / 100);
            enemy.currentState.health = Math.Max(0, enemy.currentState.health - damage);
            return damage;
        }

        public Tuple<double, int> magicalAttack(Hero enemy)
        {
            double damage;
            switch (level) {
                case 1:
                    damage = 75;
                    break;
                case 2:
                    damage = 100;
                    break;
                default:
                    damage = 150;
                    break;
            }
            enemy.currentState.health = Math.Max(0, enemy.currentState.health - damage);
            currentState.mana -= GameConstants.manaCost;
            int randomValue = random.Next() % 2;
            if(randomValue == 0)
            {
                currentState.armor = Math.Min(attributes.armor, currentState.armor + 5);
                return new Tuple<double, int>(damage, 5);
            }
            else
            {
                enemy.currentState.armor = Math.Min(enemy.attributes.armor, enemy.currentState.armor + 5);
                return new Tuple<double, int>(damage, -5);
            }
        }

        void buy_weapon(int weaponId)
        {

        }

        void addGold(int levelTimer)
        {

        }

    };
}
