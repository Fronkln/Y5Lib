using System;
using System.Collections.Generic;
using System.Text;
using Y5Lib.Unsafe;

namespace Y5Lib.NativeFunctions
{
    internal unsafe static class CActionDriveUIManagerNativeFunctions
    {
        private const int ACTION_ID = 203;

        private static delegate* unmanaged<IntPtr, int, int, void> m_selectMission;

        internal static void Init()
        {
            m_selectMission = (delegate* unmanaged<IntPtr, int, int, void>)CPP.PatternSearch("48 89 5C 24 ? 48 89 6C 24 ? 48 89 74 24 ? 48 89 7C 24 ? 41 56 48 83 EC ? 48 8B 0D ? ? ? ? 41 8B E8");
        }

        public static void SelectMission(int missionID, int unk)
        {
            IntPtr action = ActionManager.GetAction(ACTION_ID);

            if (action == IntPtr.Zero)
                return;


            m_selectMission(action, missionID, unk);
        }
    }
}
