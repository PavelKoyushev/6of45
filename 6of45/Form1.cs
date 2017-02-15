using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6of45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            const int SIZE = 46;
            int[] balls = new int[SIZE];
            Random r = new Random((int)DateTime.Now.Ticks);
            int j = 1; 
            while (j < SIZE)
            {
                int tmp = r.Next(SIZE);
                if (balls[tmp] == 0)
                {
                    balls[tmp] = j; 
                    j++;
                    balls[0] = '1';
                }
            }
            for (j = 1; j < SIZE; j++)
                textBox2.Text = textBox2.Text + balls[j].ToString() + " ";

            int i;
            Random rnd = new Random((int)DateTime.Now.Ticks);
            for (i = 0; i < 6; i++)
            {
                int value = balls[rnd.Next(1, SIZE)];
                textBox1.Text = textBox1.Text + value.ToString() + " ";
            }
        }
    }
}