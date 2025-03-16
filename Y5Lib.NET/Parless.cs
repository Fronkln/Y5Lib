using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    internal class Parless
    {
        [DllImport("YakuzaParless.asi", EntryPoint = "YP_GET_NUM_MODS", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetModCount();

        [DllImport("YakuzaParless.asi", EntryPoint = "YP_GET_MOD_NAME", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetModName(int idx);
    }
}
