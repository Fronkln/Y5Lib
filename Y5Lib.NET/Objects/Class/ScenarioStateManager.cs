using System;
using System.Runtime.InteropServices;
using Y5Lib.Unsafe;

namespace Y5Lib
{
    public static class ScenarioStateManager
    {
        public static IntPtr ActiveStateBuffer = CPP.ResolveRelativeAddress(CPP.PatternSearch("48 8D 0D ? ? ? ? 42 8B 14 91"), 7);

        private static IntPtr m_scenarioStateManager;
        private delegate bool ScenarioStateManagerCheckState(IntPtr a1, int stateGroup, int state, bool unknown = true);

        static ScenarioStateManager()
        {
            _FCheckState = Marshal.GetDelegateForFunctionPointer<ScenarioStateManagerCheckState>(CPP.PatternSearch("C1 E2 ? 41 03 D0"));
            m_scenarioStateManager = CPP.ResolveRelativeAddress(CPP.PatternSearch("48 8B 0D ? ? ? ? 44 0F B7 C0 E8 ? ? ? ? 48 8B 5C 24 ? 48 83 C4 ? 5F"), 7);
        }

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

        private static ScenarioStateManagerCheckState _FCheckState;
        public static bool CheckState(int stateGroup, int state, bool unknown = true)
        {
            IntPtr stateManager = Marshal.ReadIntPtr(m_scenarioStateManager);

            if (stateManager == IntPtr.Zero)
                return false;

            return _FCheckState(stateManager, stateGroup, state, unknown);
        }
    }
}
