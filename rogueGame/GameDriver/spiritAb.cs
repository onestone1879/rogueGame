using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDriver
{
    public abstract class spiritAb
    {
        protected int lv = 1;
        protected int aStr = 0;
        protected int aDex = 0;
        protected int aInt = 0;
        protected int aVil = 0;
        protected int health;
        protected static Random r = new Random();

        public spiritAb(int level)
        {
            lv = level;
            health = getMaxHealth();
        }
        public spiritAb(int level, int str, int dex, int inte, int vil)
        {
            aStr = str;
            aDex = dex;
            aInt = inte;
            aVil = vil;
            lv = level;
            health = getMaxHealth();
        }

        public int getLv()
        {
            return lv;
        }
        public int lvUP()
        {
            return ++lv;
        }
        public int getHealth()
        {
            return health;
        }
        public int getDmg(int dmg)
        {
            if (dmg < 0)
                return health;
            health -= dmg;
            if (health < 0)
                health = 0;
            return health;
        }
        public int getHeal(int heal)
        {
            if (heal < 0)
            {
                return health;
            }
            health += heal;
            if (health > getMaxHealth())
            {
                health = getMaxHealth();
            }
            return health;
        }

        public abstract int getStr();
        public abstract int getDex();
        public abstract int getInt();
        public abstract int getVil();
        public abstract int getMaxHealth();
        public abstract int getAtk();
        public abstract int getAmr();
        public abstract int getDod();
        public abstract double getSpd();

        public int compDmg(spiritAb tg)
        {
            double adj = Math.Exp(0.03 * (lv - tg.lv));
            double luk = r.NextDouble() * 0.4 + 0.8;
            int dmg = (int)((getAtk() - tg.getAmr()) * adj * luk);
            if (dmg < 1) dmg = 1;
            return dmg;
        }
    }
}
