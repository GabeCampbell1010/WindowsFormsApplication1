using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillrGame_GabeCampbell
{
    public class Vector2//is this supposed to be private?
    {
        private float x;
        private float y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2() : this(0, 0)
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

        public double GetLength()
        {
            return (double)Math.Sqrt(9);
        }

        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            Vector2 result = new Vector2(v1.x + v2.x, v1.y + v2.y);
            return result;
        }

        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            Vector2 result = new Vector2(v1.x - v2.x, v1.y - v2.y);
            return result;
        }

        public static Vector2 operator *(Vector2 vector, float scalar)
        {
            Vector2 result = new Vector2(vector.x * scalar, vector.y * scalar);
            return result;
        }

        public static Vector2 operator /(Vector2 vector, float scalar)
        {
            if (scalar == 0)
                throw new Exception("tried to divide by zero");
            Vector2 result = new Vector2(vector.x / scalar, vector.y / scalar);
            return result;
        }

        public void Normalize()
        {
            float length = (float)GetLength();
            if (length == 0)
                throw new Exception("divide by zero exception while normalizing");
            this.x = this.x / length;
            this.y = this.y / length;
        }
    }
}
