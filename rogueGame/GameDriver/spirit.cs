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
        private int aAgi;
        private int aInt;
        private static Random r = new Random();

        public spirit(int level)
        {
            lv = level;
            aStr = 0;
            aAgi = 0;
            aInt = 0;
        }

        public int getLv()
        {
            return lv;
        }

        public int getStr()
        {
            return aStr + lv * 2;
        }
        public int getAgi()
        {
            return aAgi + (int)(lv * 1.2);
        }
        public int getInt()
        {
            return aInt + (int)(lv * 1.3);
        }

        public int getMaxHealth()
        {
            return lv * 10 + getStr() * 5;
        }

        public int getAtk()
        {
            return getStr() * 2;
        }
        public int getAmr()
        {
            return getAgi() * 1;
        }
        public int getDod()
        {
            return getInt() * 1;
        }
        public double getSpd()  // 正整数，一般为4~11，表示多少周期（100ms）攻击一次
        {
            return Math.Round(10.0 / (Math.Log((double)getAgi() / (double)lv + 1.0) + 0.17));
        }

        public int compDmg(spirit tg)
        {
            double adj = Math.Exp(0.035 * (lv + getDod() - tg.lv - tg.getDod()));
            double luk = r.NextDouble() / 5.0 + 0.9;
            return (int)((getAtk() - tg.getAmr()) * adj * luk);
        }
    }
}
