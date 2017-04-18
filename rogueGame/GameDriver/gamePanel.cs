using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDriver
{
    public class gamePanel
    {
        private player ply;
        public playerInter pl;

        public gamePanel()
        {
            ply = new player();
            pl = (playerInter)ply;
        }
    }
}
