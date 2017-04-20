using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDriver
{
    public class spirit
    {
        private int lv;
        private int aStr;
        private int aDex;
        private int aInt;
        private int aVil;
        private static Random r = new Random();

        public spirit(int level)
        {
            lv = level;
            aStr = 0;
            aDex = 0;
            aInt = 0;
            aVil = 0;
        }

        public int getLv()
        {
            return lv;
        }

        public int getStr()
        {
            return aStr + (int)(lv * 1.2);
        }
        public int getDex()
        {
            return aDex + (int)(lv * 1.2);
        }
        public int getInt()
        {
            return aInt + (int)(lv * 1.2);
        }
        public int getVil()
        {
            return aVil + (int)(lv * 2);
        }

        public int getMaxHealth()
        {
            return lv * 20 + getVil() * 10;
        }
        public int getAtk()
        {
            return (int)(getStr() * 2);
        }
        public int getAmr()
        {
            return (int)(getDex() * 1.3);
        }
        public int getDod()
        {
            return (int)(getInt() * 1.3);
        }
        public double getSpd()  // 正整数，一般为4~11，表示多少周期（100ms）攻击一次
        {
            return Math.Round(10.0 / (Math.Log((double)getDex() / (double)lv + 1.0) + 0.17));
        }

        public int compDmg(spirit tg)
        {
            double adj = Math.Exp(0.03 * (lv - tg.lv));
            double luk = r.NextDouble() / 3.5 + 0.86;
            int dmg = (int)((getAtk() - tg.getAmr()) * adj * luk);
            if (dmg < 1) dmg = 1;
            return dmg;
        }
    }
}
