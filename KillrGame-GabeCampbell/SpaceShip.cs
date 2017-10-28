using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillrGame_GabeCampbell
{
    class SpaceShip
    {
        private Vector2 location;
        private Shape shape;
        private Vector2[] array;

        public SpaceShip(Vector2[] pointsArray, Vector2 location)
        {
            array = pointsArray;
            this.location = location;
        }

        public void Draw(Graphics g, Vector2 location)
        {
            for (int i = 0; i < array.Length; i += 2)
            {
                Vector2 start = location + array[i];
                Vector2 end = location + array[i + 1];

                g.DrawLine(Pens.Red, start.GetX(), start.GetY(), end.GetX(), end.GetY());
            }

           
        }
    }
}
