using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WinProj_0719
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = Interaction.InputBox("Input a number", "Input", "10", 0, 0);
            int i = Convert.ToInt32(x);
            if (i % 2 == 0)
                MessageBox.Show("Even Number");
            else
                MessageBox.Show("Odd Number");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = Interaction.InputBox("Input a number", "Input", "10", 0, 0);
            int i = Convert.ToInt32(x);
            string m;
            if (i >= 90)
                m = "甲";
            else if (i >= 80)
                m = "乙";
            else if (i >= 70)
                m = "丙";
            else if (i >= 60)
                m = "丁";
            else
                m = "不及格";
            MessageBox.Show(m);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int score = new Random().Next(1, 101);
            
            MessageBox.Show(score.ToString() );
            string m=" ";
            switch (score / 10) 
            {
                case 10:
                case 9:
                    m = "甲";
                    break;
                case 8:
                    m = "乙";
                    break;
                case 7:
                    m = "丙";
                    break;
                case 6:
                    m = "丁";
                    break;
                default:
                    m = "不及格";
                    break;
            }
            MessageBox.Show(m);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls) 
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.BackColor = Color.Blue;
                }
                else if (c.GetType() == typeof(Button))
                {
                    c.BackColor = Color.Red;
                }
                else
                    c.BackColor = Color.Yellow;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int count=1;
            do 
            {
                sum += count;
                count++;
            } while (count <= 1000);
            Console.WriteLine("1+2+3+...+1000={0}", sum);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 1; i <= 1000; i++) 
            {
                sum += i;
            }
            Console.WriteLine("1+2+3+...+1000={0}", sum);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int x = 1; x <= 9; x++) 
            {
                for (int y = 1; y <= 9; y++)
                {
                    Console.WriteLine("{0}X{1}={2}\t", x, y, x * y);
                }
                Console.WriteLine();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int x = 1;
            int y = 1;
            do 
            {
                y = 1;
                do 
                {
                    Console.WriteLine("{0}X{1}={2}\t", x, y, x * y);
                    y++;
                } while (y <= 9);
                x++;
                Console.WriteLine();
            } while (x <= 9);
        }
    }
}
