using System;
using System.Runtime.InteropServices;
using Y5Lib.Unsafe;

namespace Y5Lib
{
    public unsafe static class FileExp
    {
        private static IntPtr* m_fileExp;

        private delegate void FileExpGetScenarioStateForSkill(IntPtr a1, PlayerID playerID, int skillID, ref short in_state_group, ref short in_state);

        static FileExp()
        {
            m_fileExp = (IntPtr*)CPP.ResolveRelativeAddress(CPP.PatternSearch("48 8B 0D ? ? ? ? E8 ? ? ? ? 89 03 0F B7 45"), 7);
            _FGetScenarioStateForSkill = Marshal.GetDelegateForFunctionPointer<FileExpGetScenarioStateForSkill>(CPP.PatternSearch("48 8B 81 ? ? ? ? 33 C9 48 83 C0 ? 44 8B D1"));
        }

        private static FileExpGetScenarioStateForSkill _FGetScenarioStateForSkill;
        public static (short, short) GetScenarioStateForSkill(int skillID, PlayerID playerID)
        {
            IntPtr fileExp = *m_fileExp;

            if (fileExp == IntPtr.Zero)
                return (-1, -1);

            short stateGroup = -1;
            short state = -1;

            _FGetScenarioStateForSkill(fileExp, playerID + 1, skillID, ref stateGroup, ref state);

            return (stateGroup, state);
        }

        public static bool CheckSkill(int skillID, PlayerID playerID)
        {
            var state = GetScenarioStateForSkill(skillID, playerID);

            if (state.Item1 == -1 || state.Item2 == -1)
                return false;

            return ScenarioStateManager.CheckState(state.Item1, state.Item2, true);
        }
    }

}
