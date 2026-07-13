using System;
using System.Runtime.InteropServices;
using Y5Lib.Unsafe;

namespace Y5Lib
{
    public static unsafe class Physics
    {
        [DllImport("Y5Lib.dll", EntryPoint = "LIB_TEST", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Vector4 Y5Lib_DanceBattleManager_GetDancer(out bool hit, ref Vector4 start, ref Vector4 end, long mask);

        public static bool Raycast(Vector4 start, Vector4 end, out Vector4 position, long mask, int unknown2 = 0)
        {
            bool hit = false;

            Y5Lib_DanceBattleManager_GetDancer(out hit, ref start, ref end, mask);

            // position = result;

            position = new Vector4(); // result;

            return hit;
        }
    }
}
