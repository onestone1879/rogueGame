using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class drawHealth
    {
        private static System.Drawing.Font f = new System.Drawing.Font("Times New Roman", (float)12, System.Drawing.FontStyle.Regular);
        public static void dh(ProgressBar pb, string s)
        {
            System.Drawing.PointF pf = new System.Drawing.PointF(pb.Width / 2 - s.Length * 6, pb.Height / 2 - 6);
            pb.CreateGraphics().DrawString(s, f, System.Drawing.Brushes.Black, pf);
        }
    }
}
