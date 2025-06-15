using System;
using System.Runtime.InteropServices;


namespace Y5Lib
{
    public static class ActionStageManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONSTAGEMANAGER_GETTER_STAGE_ID", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_StageManager_Getter_StageID();

        public static int StageID
        {
            get
            {
                return Y5Lib_StageManager_Getter_StageID();
            }
        }
    }
}
