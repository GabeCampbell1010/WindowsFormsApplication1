using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KillrGame_GabeCampbell
{
    public partial class KillrGame : Form
    {



        private float xPos;
        private float yPos;

        private SpaceShip ship;

        public KillrGame()
        {
            InitializeComponent();
            
            ship = new SpaceShip(shapePoints, new Vector2(this.ClientRectangle.Width / 2, this.ClientRectangle.Height / 2));
        }

       

        private Vector2[] shapePoints =
        {
            new Vector2(-10,-23), new Vector2(-10,10),
            new Vector2(-10,13), new Vector2(10,14),
            new Vector2(50,10), new Vector2(12,-10),
            new Vector2(10,-10), new Vector2(-19,-10)
        };


        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            ship.Draw(e.Graphics, new Vector2(this.ClientRectangle.Width / 2, this.ClientRectangle.Height / 2));
        }
    }
}
