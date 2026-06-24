using System;
using System.Runtime.InteropServices;


namespace Y5Lib
{
    public class FighterModeManager : UnmanagedObject
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODEMANAGER_TODEADBYDAMAGE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_FighterModeManager_ToDeadByDamage(IntPtr fmManager, ref DamageInfo damage);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODEMANAGER_TOATTACK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_FighterModeManager_ToAttack(IntPtr fmManager, FighterCommandID attack);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODEMANAGER_GETTER_CURRENT_MODE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_FighterModeManager_Getter_CurrentMode(IntPtr fmManager);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODEMANAGER_SET_COMMANDSET", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_FighterModeManager_Set_Commandset(IntPtr fmManager, string commandset);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODEMANAGER_GETTER_OWNER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_FighterModeManager_Getter_Owner(IntPtr fmManager);

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


        public void ToAttack(FighterCommandID attack)
        {
            Y5Lib_FighterModeManager_ToAttack(Pointer, attack);
        }

        public void ToDeadByDamage(DamageInfo damage)
        {
            Y5Lib_FighterModeManager_ToDeadByDamage(Pointer, ref damage);
        }

        public void SetCommandset(string commandset)
        {
            Y5Lib_FighterModeManager_Set_Commandset(Pointer, commandset);
        }
    }
}
