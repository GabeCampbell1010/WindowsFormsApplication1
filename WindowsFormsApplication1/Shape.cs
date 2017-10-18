using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Shape
    {

        public Vector2[] shapePoints =
        {
            new Vector2(10,10), new Vector2(10,20),
            new Vector2(10,20), new Vector2(20,20),
            new Vector2(20,20), new Vector2(20,10),
            new Vector2(20,10), new Vector2(10,20)
        };
        //adfg
        public void DrawStuff(Graphics g, Vector2 location)
        {
            for (int i = 0; i < shapePoints.Length; i+=2)
            {
                Vector2 start = location + shapePoints[i];
                Vector2 end = location + shapePoints[i+1];

                g.DrawLine(Pens.Red, start.GetX(), start.GetY(), end.GetX(), end.GetY());
            }

            //Font drawFont = new Font("Arial", 16);
            //g.DrawString("Mittens", drawFont, Brushes.DeepPink, location.GetX(), location.GetY());
            //hellosdf
        }
    }
}
