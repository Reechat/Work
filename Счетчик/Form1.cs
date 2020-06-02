using System;
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

        private void button2_Click(object sender, EventArgs e)
        {
            var Excel = new Microsoft.Office.Interop.Excel.Application();
            var xlWB = Excel.Workbooks.Open(@"C:\test\test.xlsx");
            var xlSht = xlWB.Worksheets[1];
            int iLastRow = xlSht.Cells[xlSht.Rows.Count, "C"].End[Microsoft.Office.Interop.Excel.XlDirection.xlUp].Row + 1;
            xlSht.Cells[iLastRow, 3] = Sum.Text;
            int iLastR = xlSht.Cells[xlSht.Rows.Count, "B"].End[Microsoft.Office.Interop.Excel.XlDirection.xlUp].Row + 1;
            xlSht.Cells[iLastR, 2] = date.Text;
            Excel.Visible = true;
        }

        private void Value2_TextChanged(object sender, EventArgs e)
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
            h3 = 0.0;
            m3 = 0.0;
            s3 = 0.0;
            time3.Text = "0 : 0 : 0";
            x3 = 0.0;
            Value4.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            h4 = 0.0;
            m4 = 0.0;
            s4 = 0.0;
            time2.Text = "0 : 0 : 0";
            x4 = 0.0;
            Value3.Text = "0";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            h2 = 0.0;
            m2 = 0.0;
            s2 = 0.0;
            time1.Text = "0 : 0 : 0";
            x2 = 0.0;
            Value2.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            Value.Text = text1.Text;
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
                Value2.Text = String.Format("{0:0.00}", x2);
                 
            }
            if (m2 == 60.0)
            {
                m2 = 0.0;
                ++h2;
            }
            double num2 = Convert.ToDouble(Value.Text);
            double num3 = Convert.ToDouble(Value2.Text);
            double num4 = Convert.ToDouble(Value3.Text);
            double num5 = Convert.ToDouble(Value4.Text);
            z = num2;
            c = num3;
            v = num4;
            b = num5;
            Sum.Text = (z + c + v + b).ToString();
            time1.Text = h2.ToString() + " : " + m2.ToString() + " : " + s2.ToString();
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
                    Value3.Text = String.Format("{0:0.00}", x4);
                }
                if (m4 == 60.0)
                {
                    m4 = 0.0;
                    ++h4;
                }
                double num2 = Convert.ToDouble(Value.Text);
                double num3 = Convert.ToDouble(Value2.Text);
                double num4 = Convert.ToDouble(Value3.Text);
                double num5 = Convert.ToDouble(Value4.Text);
                z = num2;
                c = num3;
                v = num4;
                b = num5;
                Sum.Text = (z + c + v + b).ToString();
                time2.Text = h4.ToString() + " : " + m4.ToString() + " : " + s4.ToString();

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
                Value4.Text = String.Format("{0:0.00}", x3);
            }
            if (m3 == 60.0)
            {
                m3 = 0.0;
                ++h3;
            }
            double num2 = Convert.ToDouble(Value.Text);
            double num3 = Convert.ToDouble(Value2.Text);
            double num4 = Convert.ToDouble(Value3.Text);
            double num5 = Convert.ToDouble(Value4.Text);
            z = num2;
            c = num3;
            v = num4;
            b = num5;
            Sum.Text = (z + c + v + b).ToString();
            time3.Text = h3.ToString() + " : " + m3.ToString() + " : " + s3.ToString();
        }
    }
}

