using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public static class FighterCommandManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERCOMMANDMANAGER_GET_COMMAND_INFO", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr Y5Lib_FighterCommandManager_GetCommandInfo(FighterCommandID command);

        public static CFCMove GetCommandInfo(FighterCommandID command)
        {
            return Marshal.PtrToStructure<CFCMove>(Y5Lib_FighterCommandManager_GetCommandInfo(command));
        }

    }
}
