using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public static class Font
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FONT_PUSH_SETTINGS", CallingConvention = CallingConvention.Cdecl)]
        public static extern void PushSettings(ref FontSettings settings);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FONT_PUSH_TEXT", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DrawText(string text);


        public static void DrawText(string text,  FontSettings settings)
        {
            PushSettings(ref settings);
            DrawText(text);
        }

        public static void DrawText3D(string text, Vector3 position, FontSettings settings)
        {
            Vector2 screen = Screen.WorldToScreenPixels(position);

            settings.xPos = (int)screen.x;
            settings.yPos = (int)screen.y;

            PushSettings(ref settings);
            DrawText(text);
        }
    }
}
