using System;
using System.Reflection;
using System.Runtime.InteropServices;


namespace Y5Lib
{
    public class FighterModeManager : UnmanagedObject
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODEMANAGER_TODEADBYDAMAGE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_FighterModeManager_ToDeadByDamage(IntPtr fmManager, ref DamageInfo damage);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODEMANAGER_TOATTACK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_FighterModeManager_ToAttack(IntPtr fmManager, FighterCommandID attack);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODEMANAGER_TOPROVOKE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_FighterModeManager_ToProvoke(IntPtr fmManager, FighterCommandID provoke);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODEMANAGER_TOACTION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_FighterModeManager_ToAction(IntPtr fmManager, FighterCommandID action);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODEMANAGER_GETTER_CURRENT_MODE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_FighterModeManager_Getter_CurrentMode(IntPtr fmManager);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODEMANAGER_TOCOMMAND", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool Y5Lib_FighterModeManager_ToCommand(IntPtr fmManager, FighterCommandID command, ref FighterTriggerStatus triggerStatus);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODEMANAGER_SET_COMMANDSET", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_FighterModeManager_Set_Commandset(IntPtr fmManager, string commandset);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODEMANAGER_GETTER_OWNER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_FighterModeManager_Getter_Owner(IntPtr fmManager);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODEMANAGER_GET_CURRENT_COMMAND", CallingConvention = CallingConvention.Cdecl)]
        internal static extern FighterCommandID Y5Lib_FighterModeManager_GetCurrentCommand(IntPtr fmManager);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODEMANAGER_GET_CURRENT_COMMANDSET", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_FighterModeManager_GetCurrentCommandSet(IntPtr fmManager);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODEMANAGER_GET_COMMANDSET", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_FighterModeManager_GetCommandSet(IntPtr fmManager, int index);


        public Fighter Owner
        {
            get
            {
                return new Fighter() { Pointer = Y5Lib_FighterModeManager_Getter_Owner(Pointer) };
            }
        }

        public FighterMode Current
        {
            get
            {
                return new FighterMode() { Pointer = Y5Lib_FighterModeManager_Getter_CurrentMode(Pointer) };
            }
        }

        public FighterCommandID CurrentCommand
        {
            get
            {
                return Y5Lib_FighterModeManager_GetCurrentCommand(Pointer);
            }
        }

        public int CurrentCommandset => Y5Lib_FighterModeManager_GetCurrentCommandSet(Pointer);


        public bool ToCommand(FighterCommandID command, FighterTriggerStatus status) => Y5Lib_FighterModeManager_ToCommand(Pointer, command, ref status);

        public void ToAttack(FighterCommandID attack) => Y5Lib_FighterModeManager_ToAttack(Pointer, attack);
        public void ToProvoke(FighterCommandID attack) => Y5Lib_FighterModeManager_ToProvoke(Pointer, attack);
        public void ToAction(FighterCommandID action) => Y5Lib_FighterModeManager_ToAction(Pointer, action);


        public void ToDeadByDamage(DamageInfo damage) => Y5Lib_FighterModeManager_ToDeadByDamage(Pointer, ref damage);


        public int GetCommandset(int index) => Y5Lib_FighterModeManager_GetCommandSet(Pointer, index);
        public void SetCommandset(string commandset) => Y5Lib_FighterModeManager_Set_Commandset(Pointer, commandset);
    }
}
