using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public class Player : Fighter
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_PLAYER_GET_CURRENT_ID", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetCurrentID();
        public static bool IsKiryu()
        {
            return GetCurrentID() == 0;
        }

        public static bool IsHaruka()
        {
            return GetCurrentID() == 4;
        }
    }

    public enum PlayerID
    {
        Kiryu = 0,
        Akiyama = 1,
        Saejima = 2,
        Shinada = 3,
        Haruka = 4,
    }
}
