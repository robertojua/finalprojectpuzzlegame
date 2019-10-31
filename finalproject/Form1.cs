using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        int f = 0;
        int g = 0;
        int h = 0;
        int i = 0;
        int j = 0;
        int pic = 0;

        Random rand = new Random();

        private void button1_Click(object sender, EventArgs e)
        {

            Point p = new Point(667, 192);
            pictureBox11.Location = p;



            a = rand.Next(1, 10);
            b = rand.Next(1, 10);
            c = rand.Next(1, 10);
            d = rand.Next(1, 10);
            f = rand.Next(1, 10);
            g = rand.Next(1, 10);
            h = rand.Next(1, 10);
            i = rand.Next(1, 10);
            j = rand.Next(1, 10);
            while (a == b || a == c || a == d || a == f || a == g || a == h || a == i || a == j || b == c || b == d || b == f || b == g || b == h || b == i || b == j || c == d || c == f || c == g || c == h || c == i || c == j || d == f || d == g || d == h || d == i || d == j || f == g || f == h || f == i || f == j || g == h || g == i || g == j || h == i || h == j || i == j)
            { 
            a = rand.Next(1, 10);
            b = rand.Next(1, 10);
            c = rand.Next(1, 10);
            d = rand.Next(1, 10);
            f = rand.Next(1, 10);
            g = rand.Next(1, 10);
            h = rand.Next(1, 10);
            i = rand.Next(1, 10);
            j = rand.Next(1, 10);
            }

            picChange(a, pictureBox1);
            picChange(b, pictureBox2);
            picChange(c, pictureBox3);
            picChange(d, pictureBox4);
            picChange(f, pictureBox5);
            picChange(g, pictureBox6);
            picChange(h, pictureBox7);
            picChange(i, pictureBox8);
            picChange(j, pictureBox9);

            timer1.Start();
    
        }



        public void picChange(int x, PictureBox p)
        {
            if (x == 1)
            {
                p.Image = Properties.Resources.penguins12;
            }
            if (x == 2)
            {
                p.Image = Properties.Resources.penguins21;
            }
            if (x == 3)
            {
                p.Image = Properties.Resources.penguins31;
            }
            if (x == 4)
            {
                p.Image = Properties.Resources.penguins42;
            }
            if (x == 5)
            {
                p.Image = Properties.Resources.penguins51;
            }
            if (x == 6)
            {
                p.Image = Properties.Resources.penguins61;
            }
            if (x == 7)
            {
                p.Image = Properties.Resources.penguins71;
            }
            if (x == 8)
            {
                p.Image = Properties.Resources.penguins82;
            }
            if (x == 9)
            {
                p.Image = Properties.Resources.penguins91;
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p = new Point(171, 79);
            pictureBox11.Location = p;
            pic = 1;

            timer1.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pic == 2 || pic == 4)
            {
                Point p = new Point(173, 79);
                pictureBox11.Location = p;
                pic = 1;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pic == 1 || pic == 3 || pic == 5)
            {
                Point p = new Point(307, 79);
                pictureBox11.Location = p;
                pic = 2;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pic == 2 || pic == 6)
            {
                Point p = new Point(441, 79);
                pictureBox11.Location = p;
                pic = 3;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(pic == 1 || pic == 5 || pic == 7)
            {
                Point p = new Point(173, 214);
                pictureBox11.Location = p;
                pic = 4;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if(pic == 2 || pic == 4 || pic == 6 || pic == 8)
            {
                Point p = new Point(307, 214);
                pictureBox11.Location = p;
                pic = 5;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Point p = new Point(441, 214);
            pictureBox11.Location = p;
            pic = 6;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Point p = new Point(441, 214);
            pictureBox11.Location = p;
            pic = 6;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Point p = new Point(441, 214);
            pictureBox11.Location = p;
            pic = 6;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Point p = new Point(441, 214);
            pictureBox11.Location = p;
            pic = 6;
        }
    }
}
