using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDriver
{
    public class spirit : spiritAb
    {
        public spirit(int level) : base(level) { }
        public spirit(int level, int str, int dex, int inte, int vil) : base(level, str, dex, inte, vil) { }

        public override int getStr()
        {
            return aStr + (int)(lv * 1.2);
        }
        public override int getDex()
        {
            return aDex + (int)(lv * 1.2);
        }
        public override int getInt()
        {
            return aInt + (int)(lv * 1.2);
        }
        public override int getVil()
        {
            return aVil + (int)(lv * 2);
        }
        public override int getMaxHealth()
        {
            return lv * 20 + getVil() * 10;
        }
        public override int getAtk()
        {
            return (int)(getStr() * 2);
        }
        public override int getAmr()
        {
            return (int)(getDex() * 1.3);
        }
        public override int getDod()
        {
            return (int)(getInt() * 1.3);
        }
        public override double getSpd()  // 正整数，一般为4~11，表示多少周期（100ms）攻击一次
        {
            return Math.Round(10.0 / (Math.Log((double)getDex() / (double)lv + 1.0) + 0.17));
        }
    }
}
