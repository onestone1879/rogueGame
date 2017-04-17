using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDriver
{
    class compLv
    {
        public static int getNeedExp(int lv)
        {
            double p2 = 50.448;
            double p1 = -109.38;
            double p0 = 450;
            int exp = (int)(Math.Round(p2*lv*lv+p1*lv+p0) * 100);
            return exp;
        } 
    }
}
