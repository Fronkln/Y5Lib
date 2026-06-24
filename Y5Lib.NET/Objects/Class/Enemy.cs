using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public class Enemy : Fighter
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENEMY_GETTER_ISUNKILLABLE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool Y5Lib_Enemy_Getter_IsUnkillable(IntPtr enemy);
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENEMY_SETTER_ISUNKILLABLE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Enemy_Setter_IsUnkillable(IntPtr enemy, bool unKillable);

        public bool isUnkillable
        {
            get
            {
                return Y5Lib_Enemy_Getter_IsUnkillable(Pointer);
            }
            set
            {
                Y5Lib_Enemy_Setter_IsUnkillable(Pointer, value);
            }
        }

    }
}
