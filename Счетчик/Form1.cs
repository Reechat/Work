﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Счетчик.Properties;

namespace Счетчик
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double s2, s3, s4, m2, m3, m4, h2, h3, h4, x2, x3, x4, z, c, v, b;

        private void time3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Start1_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer3.Stop();
            if (timer1.Enabled)
                timer1.Enabled = false;
            else
                timer1.Enabled = true;

        }

        private void start3_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Stop();
            if (timer3.Enabled)
                timer3.Enabled = false;
            else
                timer3.Enabled = true;
        }

        private void start2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer3.Stop();
            if (timer2.Enabled)
                timer2.Enabled = false;
            else
                timer2.Enabled = true;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void label5_Click(object sender, EventArgs e)
        {

        }



        public void timer1_Tick(object sender, EventArgs e)
        {
            ++s2;
            if (s2 == 60.0)
            {
                s2 = 0.0;
                ++m2;
            }
            double num1 = Convert.ToDouble(text2.Text);
            if (s2 > 0.0)
            {
                x2 += num1 / 3600.0;
                Value2.Text = x2.ToString();
            }
            if (m2 == 60.0)
            {
                m2 = 0.0;
                ++h2;
            }



        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            {
                ++s4;
                if (s4 == 60.0)
                {
                    s4 = 0.0;
                    ++m4;
                }
                double num1 = Convert.ToDouble(text4.Text);
                if (s4 > 0.0)
                {
                    x4 += num1 / 3600.0;
                    Value3.Text = Convert.ToString(x4);
                }
                if (m4 == 60.0)
                {
                    m4 = 0.0;
                    ++h4;
                }

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            ++s3;
            if (s3 == 60.0)
            {
                s3 = 0.0;
                ++m3;
            }
            double num1 = Convert.ToDouble(text3.Text);
            if (s3 > 0.0)
            {
                x3 += num1 / 3600.0;
                Value4.Text = x3.ToString();
            }
            if (m3 == 60.0)
            {
                m3 = 0.0;
                ++h3;
            }

        }
    }
}

