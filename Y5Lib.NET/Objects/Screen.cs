using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Y5Lib.Unsafe;

namespace Y5Lib
{
    public unsafe static class Screen
    {

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SCREEN_WORLDTOSCREENRATIO", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Screen_WorldToScreenRatio(ref Vector4 vec, out Vector4 result);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SCREEN_SCREENRATIOTOPIXELS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Screen_ScreenRatioToPixels(ref Vector4 vec, out Vector4 result);


        public static Vector2 WorldToScreenPixels(Vector3 world)
        {
            return ScreenRatioToPixels(WorldToScreenRatio(world));
        }

        public static Vector2 WorldToScreenRatio(Vector3 world)
        {
            Vector4 world4 = (Vector4)world;
            Vector4 ratio;

            Y5Lib_Screen_WorldToScreenRatio(ref world4, out ratio);

            return new Vector2(ratio.x, ratio.y);
        }

        public static Vector2 ScreenRatioToPixels(Vector2 screenRatio)
        {
            Vector4 pixels;
            Vector4 ratio = new Vector4(screenRatio.x, screenRatio.y, 0, 0);
            Y5Lib_Screen_ScreenRatioToPixels(ref ratio, out pixels);

            return new Vector2(pixels.x, pixels.y);
        }
    }
}
