using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        Shape myShape = new Shape();


        public Form1()
        {
            InitializeComponent();
            
        }


        bool swap = false;
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            swap = !swap;
            if(swap)
                label1.Text = "Kitty";
            else
                label1.Text = "Hello";
            count++;
            if (count == 10)
            {
                label1.Text = "Ten Presses!";
            }
        }

        private void DrawStuff(Graphics g, Vector2 location)
        {
            g.DrawString("Mittens", DefaultFont, Brushes.DeepPink, location.GetX(), location.GetY());
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           Vector2 loc = new Vector2(this.ClientRectangle.Width / 2, this.ClientRectangle.Height / 2);
            DrawStuff(e.Graphics, loc);


        }
    }
}
