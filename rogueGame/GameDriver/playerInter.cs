using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDriver
{
    public interface playerInter
    {
        int getGold();
        int addGold(int g);
        bool spentGold(int sg);
        int getExp();
        int addExp(int e);
        int getElu();
        int getLv();
    }
}
