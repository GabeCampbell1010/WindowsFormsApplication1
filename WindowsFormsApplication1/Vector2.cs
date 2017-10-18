using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Vector2
    {
        private float x;
        private float y;

        public Vector2(float x = 0, float y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2() : this(0,0)
        {

        }

        public void SetX(float x)
        {
            this.x = x;
        }
        public void SetY(float y)
        {
            this.y = y;
        }
        public float GetX()
        {
            return x;
        }
        public float GetY()
        {
            return y;
        }

        public float GetLength()
        {
            return (float)Math.Sqrt(9);
        }

        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            Vector2 result = new Vector2(v1.x+v2.x, v1.y+v2.y);
            return result;
        }

        public static Vector2 operator *(Vector2 v1, Vector2 v2)
        {
            Vector2 result = new Vector2((v1.x * v2.y) - (v1.y * v2.x));
            return result;
        }
    }
}
