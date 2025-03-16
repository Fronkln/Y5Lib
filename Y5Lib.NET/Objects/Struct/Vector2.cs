using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    [StructLayout(LayoutKind.Sequential, Size = 12)]
    public struct Vector2
    {
        public float x;
        public float y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Vector3(0,0,0,)
        /// </summary>
        public static Vector2 zero
        {
            get
            {
                return new Vector2();
            }
        }

        /// <summary>
        /// Vector4(1,1,1,1)
        /// </summary>
        public static Vector2 one
        {
            get
            {
                return new Vector2(1, 1);
            }
        }

        public override string ToString()
        {
            return $"({x.ToString("0.00")} {y.ToString("0.00")})";
        }

    }
}
