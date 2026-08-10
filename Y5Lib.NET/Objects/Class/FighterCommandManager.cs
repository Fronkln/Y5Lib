using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public static class FighterCommandManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERCOMMANDMANAGER_GET_COMMAND_INFO", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr Y5Lib_FighterCommandManager_GetCommandInfo(FighterCommandID command);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERCOMMANDMANAGER_FIND_COMMANDSET_ID", CallingConvention = CallingConvention.Cdecl)]
        public static extern int FindCommandsetID(string commandsetName);

        public static CFCMove GetCommandInfo(FighterCommandID command)
        {
            IntPtr commandDataPtr = Y5Lib_FighterCommandManager_GetCommandInfo(command);
            return Marshal.PtrToStructure<CFCMove>(commandDataPtr);
        }

        public static bool DoesCommandsetExist(string commandsetName)
        {
            int commandsetID  = FindCommandsetID(commandsetName);
            int defaultID = FindCommandsetID("default");

            return commandsetID != defaultID;
        }
    }
}
