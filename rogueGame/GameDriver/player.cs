using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDriver
{
    public class player : playerInter
    {
        public player()
        {
            gold = 0;
            exp = 0;
            lv = 1;
        }

        // gold
        private int gold;
        public int getGold()
        {
            return gold;
        }
        public int addGold(int add)
        {
            gold += add;
            return gold;
        }
        public bool spentGold(int sp)
        {
            if (gold < sp)
                return false;
            gold -= sp;
            return true;
        }

        // exp
        private int exp;
        public int getExp()
        {
            return exp;
        }
        public int addExp(int add)
        {
            // TODO : lv up
            exp += add;
            if (exp > getElu())
                lvup();
            return exp;
        }

        // exp to lv up
        //private int elu;
        public int getElu()
        {
            return compLv.getNeedExp(lv);
        }

        // lv
        private int lv;
        public int getLv()
        {
            return lv;
        }
        private int lvup()
        {
            int up = 0;
            while (exp > getElu())
            {
                ++up;
                exp -= getElu();
                ++lv;
            }
            return up;
        }
    }
}
