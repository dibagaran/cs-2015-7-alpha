using System;

namespace Project
{
    public class Vector
    {
        public float X { get; set; }

        public float Y { get; set; }

        public Vector (float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Vector operator+ (Vector v1, Vector v2)
        {
            return new Vector (v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector operator* (Vector v, float r)
        {
            return new Vector (v.X * r, v.Y * r);
        }
    }
}

