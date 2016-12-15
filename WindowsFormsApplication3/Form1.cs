using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Height = this.Height;
            pictureBox1.Width = this.Width;
            bmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmap;
            
            g = Graphics.FromImage(this.pictureBox1.Image);
            penSize = 1;
            curColour = Color.Black;
            rnd = new Random();
            Settings sets = new Settings();
            sets.Show();

        }
        Graphics g;
        Bitmap bmap;
        Color curColour;
        int penSize;
        Random rnd;
        Pen cPen;
        
        int Round(double num)
        {
            if (num - (int)num >= 0.5)
                return (int)num + 1;
            else return (int)num;
        }
       
        void Tree(int x, int y, double angle, int length, int width)
        {
            int x1, y1;
            int p, brenchOffset, width_1;
            double angle_1;
            if (length < Options.MinLeaf)
                return;
            x1 = Round(x + length * Math.Cos(angle));
            y1 = Round(y + length * Math.Sin(-angle));
            
            if (length > Options.Lushness)
                p = Options.Lushness;
            else
                p = length;
            if (length > Options.LeafQuantity)//BRENCH
            {
                
                curColour = Color.Brown;
                cPen = new Pen(curColour, penSize);
                for (int i = -width/2; i <= width/2; i++)
                {
                    g.DrawLine(cPen, x + i, y, x1+i/Options.BrebchWidthchangr, y1);

                    
                }
            }
            else//LEAF
            {
                
                switch (rnd.Next(0, 5))
                {
                    case 0: curColour = Color.FromArgb(30, 130, 9); break;
                    case 1: curColour = Color.FromArgb(30, 140, 9); break;
                    case 2: curColour = Color.FromArgb(30, 150, 9); break;
                    case 3: curColour = Color.FromArgb(30, 160, 9); break;
                    case 4: curColour = Color.FromArgb(30, 170, 9); break;

                }
                cPen = new Pen(curColour, penSize);
                for (int i = 0; i <= 3; i++)
                {
                    g.DrawLine(cPen, x + i, y, x1, y1);
                    
                    //pictureBox1.Refresh();
                }
            }
            cPen.Dispose();
            
            
            for (int i=0; i<= Options.BrenchFrequency-rnd.Next(0, Options.BrenchFrequency); i++)
            {
                brenchOffset = rnd.Next(0, length - length *Options.SpawnOffsetFromTop/100) + (length *Options.SpawnOffsetFromTop / 100);
                angle_1 = angle + (Math.PI/2) * (0.5 - (double)rnd.Next(0, 1000) / 1000);
                x1 = Round(x + brenchOffset * Math.Cos(angle));
                y1 = Round(y + brenchOffset * Math.Sin(-angle));
                
                Tree(x1, y1, angle_1, p -5- rnd.Next(0, Options.brenchWeaking), width*(p - rnd.Next(0, Options.brenchWeaking)) /length);
                
            }
            


        }
        private  void  button1_Click(object sender, EventArgs e)
        {
            Tree(pictureBox1.Width / 2, pictureBox1.Height,  Math.PI/2, Options.TreeSize, Options.BrenchWidth);
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmap;

            g = Graphics.FromImage(this.pictureBox1.Image);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Height = this.Height;
            pictureBox1.Width = this.Width;
            bmap = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmap;

            g = Graphics.FromImage(this.pictureBox1.Image);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
