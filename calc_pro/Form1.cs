﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.label2.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.label2.Text = "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.label2.Text + "1";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.label2.Text + "2";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.label2.Text + "3";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.label2.Text =this.label2.Text + "4";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.label2.Text + "5";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.label2.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.label2.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.label2.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label2.Text =this.label2.Text+ "9";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.label3.Text = "+";
            if (this.label2.Text!="")
            {
                this.label4.Text = this.label2.Text;
            }
            this.label4.Text = this.label2.Text;
            this.label2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.label3.Text = "-";

            if (this.label2.Text != "")
            {
                this.label4.Text = this.label2.Text;
            }
            this.label4.Text = this.label2.Text;
            this.label2.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.label3.Text = "x";

            if (this.label2.Text != "")
            {
                this.label4.Text = this.label2.Text;
            }
            this.label4.Text = this.label2.Text;
            this.label2.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.label3.Text = "÷";

            if (this.label2.Text != "")
            {
                this.label4.Text = this.label2.Text;
            }
            this.label4.Text = this.label2.Text;
            this.label2.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double fn;
            double sn;
            double r;
            //-------------------------------------
            double.TryParse(this.label4.Text, out fn);
            double.TryParse(this.label2.Text, out sn);
            r = 0;
            //-------------------------------------
            if (this.label3.Text=="+")
            {
                r = fn + sn;
            }
            //-------------------------------------
            if (this.label3.Text == "-")
            {
                r = fn - sn;
            }
            //-------------------------------------
            if (this.label3.Text == "x")
            {
                r = fn * sn;
            }
            //-------------------------------------
            if (this.label3.Text == "÷")
            {
                r = fn / sn;
            }
            //-------------------------------------
            this.label2.Text= r.ToString();
            this.label3.Text = "";
            this.label4.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
