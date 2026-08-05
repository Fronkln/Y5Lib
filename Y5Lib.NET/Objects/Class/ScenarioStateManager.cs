using System;
using System.Runtime.InteropServices;
using Y5Lib.Unsafe;

namespace Y5Lib
{
    public static class ScenarioStateManager
    {
        public static IntPtr ActiveStateBuffer = CPP.ResolveRelativeAddress(CPP.PatternSearch("48 8D 0D ? ? ? ? 42 8B 14 91"), 7);

        public static byte[] GetActiveStateBuffer()
        {
            //We believe the full buffer for Yakuza 5 scenario state is 0x6400 bytes.
            byte[] buffer = new byte[0x6400];

            Marshal.Copy(ActiveStateBuffer, buffer, 0, buffer.Length);

            return buffer;
        }

        public static void SetActiveStateBuffer(byte[] buffer)
        {
            Marshal.Copy(buffer, 0, ActiveStateBuffer, buffer.Length);
        }

        public static bool CheckState(int stateGroup, int state, bool unknown = true)
        {
            return false;
        }
    }
}
