using System;
using System.Runtime.InteropServices;


namespace Y5Lib
{
    public class FighterModeManager : UnmanagedObject
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODEMANAGER_GETTER_CURRENT_MODE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_FighterModeManager_Getter_CurrentMode(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODEMANAGER_SET_COMMANDSET", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_FighterModeManager_Set_Commandset(IntPtr fighter, string commandset);

        public FighterMode Current
        {
            get
            {
                return new FighterMode() { Pointer = Y5Lib_FighterModeManager_Getter_CurrentMode(Pointer) };
            }
        }

        public void SetCommandset(string commandset)
        {
            Y5Lib_FighterModeManager_Set_Commandset(Pointer, commandset);
        }
    }
}
