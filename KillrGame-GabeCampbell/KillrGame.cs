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
        //part2
        //private EnemyShip eShip;
        private EnemyArmy army;

        public KillrGame()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            ship = new SpaceShip(shapePoints, new Vector2(this.ClientRectangle.Width / 2, this.ClientRectangle.Height / 2));
            //part2
            //eShip = new EnemyShip(shapePoints, new Vector2(this.ClientRectangle.Width / 2 + 20, this.ClientRectangle.Height / 2 + 20));
            army = new EnemyArmy(this.ClientRectangle.Width / 2, this.ClientRectangle.Height / 2);

            timer1.Start();
        }

       

        private Vector2[] shapePoints =
        {
            new Vector2(-10,-23), new Vector2(-10,10),
            new Vector2(-10,13), new Vector2(10,14),
            new Vector2(50,10), new Vector2(12,-10),
            new Vector2(10,-10), new Vector2(-19,-10)
        };


        Random rand = new Random();

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            ship.Draw(e.Graphics, /*new Vector2(this.ClientRectangle.Width / 2, this.ClientRectangle.Height / 2)*/ship.location);//this needs to be called at the ship location
            //part2
            //eShip.Draw(e.Graphics, /*new Vector2(this.ClientRectangle.Width / 2, this.ClientRectangle.Height / 2)*/eShip.location);//this needs to be called at the ship location
            army.Draw(e.Graphics, new Vector2(rand.Next(1, 3), rand.Next(1, 3))/*new Vector2(this.ClientRectangle.Width / 2, this.ClientRectangle.Height / 2)*/);
        }

  
        private void timer1_Tick(object sender, EventArgs e)
        {
            ship.Update();
            //part2
            //eShip.Update();
            army.Update();
            this.Invalidate();
        }
    }
}
