using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightCraft
{
    public class GameConstants
    {
        public const double manaCost = 100;
        public const double healHealth = 50;
        public const int healCost = 2;
        public const double armorBasic = 2;
        public const double armorUltimate = 8;
        public const int armorBasicCost = 3;
        public const int armorUltimateCost = 8;
        public const double damageBasic = 6;
        public const double damageUltimate = 15;
        public const int damageBasicCost = 4;
        public const int damageUltraCost = 8;

        public Hero MyHero
        {
            get {
                return new Hero()
                {
                    attributes = new Attributes()
                    {
                        health = 500,
                        mana = 200,
                        armor = 30,
                        damagePerHit = 250
                    },
                    currentState = new Attributes()
                    {
                        health = 500,
                        mana = 200,
                        armor = 2,
                        damagePerHit = 50
                    },
                    gold = 10,
                    imagePath = "Images\\me.jpg",
                    level = 1
                };
            }
        }

        public Hero Lvl1Enemy
        {
            get
            {
                return new Hero()
                {
                    attributes = new Attributes()
                    {
                        health = 500,
                        mana = 200,
                        armor = 30,
                        damagePerHit = 250
                    },
                    currentState = new Attributes()
                    {
                        health = 500,
                        mana = 200,
                        armor = 2,
                        damagePerHit = 50
                    },
                    gold = 10,
                    imagePath = "Images\\lvl1boss.png",
                    level = 1
                };
            }
        }

        public Hero Lvl2Enemy
        {
            get
            {
                return new Hero()
                {
                    attributes = new Attributes()
                    {
                        health = 600,
                        mana = 220,
                        armor = 30,
                        damagePerHit = 250
                    },
                    currentState = new Attributes()
                    {
                        health = 600,
                        mana = 220,
                        armor = 3,
                        damagePerHit = 55
                    },
                    gold = 10,
                    imagePath = "Images\\lvl2boss.png",
                    level = 2
                };
            }
        }

        public Hero Lvl3Enemy
        {
            get
            {
                return new Hero()
                {
                    attributes = new Attributes()
                    {
                        health = 750,
                        mana = 250,
                        armor = 30,
                        damagePerHit = 250
                    },
                    currentState = new Attributes()
                    {
                        health = 750,
                        mana = 250,
                        armor = 5,
                        damagePerHit = 60
                    },
                    gold = 10,
                    imagePath = "Images\\lvl3boss.png",
                    level = 3
                };
            }
        }
    }
}