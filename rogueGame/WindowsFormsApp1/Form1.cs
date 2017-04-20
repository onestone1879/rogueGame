﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static Random r = new Random();
        private GameDriver.spirit s1, s2;
        private int s1Hth, s2Hth;
        private int counter;

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++counter;
            if (counter % s1.getSpd() == 0)
            {
                int dmg = s1.compDmg(s2);
                s2Hth -= dmg;
                if (s2Hth <= 0)
                {
                    s2Hth = 0;
                }
                progressBar2.Value = s2Hth;
                logOut("s 1 attack s 2 with dmg " + dmg.ToString());
            }

            if (counter % s2.getSpd() == 0)
            {
                int dmg = s2.compDmg(s1);
                s1Hth -= dmg;
                if (s1Hth <= 0)
                {
                    s1Hth = 0;
                }
                progressBar1.Value = s1Hth;
                logOut("s 2 attack s 1 with dmg " + dmg.ToString());
            }

            if ( s1Hth <= 0 || s2Hth <= 0)
            {
                timer1.Enabled = false;
                counter = 0;
                logOut("end!");
            }

            refreshHealth();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s1 = new GameDriver.spirit(r.Next(15, 19));
            s2 = new GameDriver.spirit(r.Next(15, 19));

            label3.Text = "LV. " + s1.getLv().ToString();
            label4.Text = "ATK " + s1.getAtk().ToString();
            label5.Text = "AMR " + s1.getAmr().ToString();
            label6.Text = "SPD " + s1.getSpd().ToString();
            s1Hth = s1.getMaxHealth();
            progressBar1.Maximum = s1Hth;
            progressBar1.Value = s1Hth;

            label10.Text = "LV. " + s2.getLv().ToString();
            label9.Text = "ATK " + s2.getAtk().ToString();
            label8.Text = "AMR " + s2.getAmr().ToString();
            label7.Text = "SPD " + s2.getSpd().ToString();
            s2Hth = s2.getMaxHealth();
            progressBar2.Maximum = s2Hth;
            progressBar2.Value = s2Hth;

            logOut("Create spirit 1 with lv " + s1.getLv().ToString());
            logOut("Create spirit 2 with lv " + s2.getLv().ToString());

            refreshHealth();

            counter = 0;
            timer1.Enabled = true;
        }

        private void logOut(String s)
        {
            textBox1.Text += s;
            textBox1.Text += System.Environment.NewLine;
            textBox1.Select(textBox1.Text.Length - 1, 1);
            textBox1.ScrollToCaret();
        }

        private void refreshHealth()
        {
            string s1h = s1Hth.ToString() + " / " + s1.getMaxHealth().ToString();
            string s2h = s2Hth.ToString() + " / " + s2.getMaxHealth().ToString();
            //drawHealth.dh(progressBar1, s1h);
            //drawHealth.dh(progressBar2, s2h);
            label11.Text = s1h;
            label12.Text = s2h;
        }
    }
}
