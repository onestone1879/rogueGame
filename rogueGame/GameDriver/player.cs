using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDriver
{
    class player
    {
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
            exp += add;
            return exp;
        }

        // exp to lv up
        private int elu;
        public int getElu()
        {
            return elu;
        }

        // lv
        private int lv;
        public int getLv()
        {
            return lv;
        }       
    }
}
