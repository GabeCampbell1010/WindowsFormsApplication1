using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillrGame_GabeCampbell
{
    class Shape
    {




        
        private Vector2[] array;
        

        public Shape(Vector2[] array)
        {
            this.array = array;   
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
