using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rogueGame
{
    public partial class Form1 : Form
    {
        private GameDriver.gamePanel gp;

        public Form1()
        {
            InitializeComponent();
            gp = new GameDriver.gamePanel();
            refreshIF();
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            tableLayoutPanel1.Width = flowLayoutPanel1.Width;
            tableLayoutPanel2.Width = flowLayoutPanel1.Width;
        }

        private void refreshIF()
        {
            label1.Text = "LV. " + gp.pl.getLv().ToString();
            progressBar1.Maximum = gp.pl.getElu();
            progressBar1.Value = gp.pl.getExp();
        }

        private void giveExp_Click(object sender, EventArgs e)
        {
            gp.pl.addExp(gp.pl.getLv() * 100);
            refreshIF();
        }
    }
}
