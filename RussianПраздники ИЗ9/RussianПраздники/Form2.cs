﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianПраздники
{
    public partial class Form2 : Form
    {
        Form1 form1;
        DateTime diff;
        string ss;

        public Form2(Form1 f1, DateTime dt, string s)
        {
            BackColor = Color.Salmon;
            InitializeComponent();
            form1 = f1;
            timer1.Start();
            diff = dt;
            ss = s;
        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                TimeSpan TimeRemaining = diff - DateTime.Now;
                label2.Text = "До праздника "+ ss +" осталось " + TimeRemaining.Days + " дней " + TimeRemaining.Hours + " часов " + TimeRemaining.Minutes + " минут " + TimeRemaining.Seconds + " секунд.";

            
        }
    }
}
