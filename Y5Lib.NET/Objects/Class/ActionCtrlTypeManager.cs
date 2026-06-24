using System;
using System.Runtime.InteropServices;


namespace Y5Lib
{
    public static class ActionCtrlTypeManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONCTRLTYPEMANAGER_GETTER_START_TYPE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_ActionCtrlTypeManager_Getter_StartType();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONCTRLTYPEMANAGER_GETTER_BATTLE_PHASE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_ActionCtrlTypeManager_Getter_Battle_Phase();
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONCTRLTYPEMANAGER_GETTER_BATTLE_SUB_PHASE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_ActionCtrlTypeManager_Getter_Battle_Sub_Phase();

        public static int StartType { get { return Y5Lib_ActionCtrlTypeManager_Getter_StartType(); } }
        public static BattlePhase BattlePhase { get { return (BattlePhase)Y5Lib_ActionCtrlTypeManager_Getter_Battle_Phase(); } }
        public static int BattleSubPhase { get { return Y5Lib_ActionCtrlTypeManager_Getter_Battle_Sub_Phase(); } }

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONCTRLTYPEMANAGER_ALLOW_PHASE_PROGRESS", CallingConvention = CallingConvention.Cdecl)]
        public static extern void AllowPhaseProgress();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONCTRLTYPEMANAGER_SET_BATTLE_PHASE", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetBattlePhase(BattlePhase phase);
    }
}
