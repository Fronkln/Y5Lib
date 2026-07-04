using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public static class ActionFighterSyncManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONFIGHTERSYNCMANAGER_GET_DATA_BY_SERIAL", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_ActionFighterSyncManager_GetSyncDataBySerial(int serial);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONFIGHTERSYNCMANAGER_GET_SYNCTOMAKE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_ActionFighterSyncManager_Get_SyncToMake(int index);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONFIGHTERSYNCMANAGER_GETTER_SYNCSTOMAKE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_ActionFighterSyncManager_Getter_SyncsToMake();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONFIGHTERSYNCMANAGER_START_SYNC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int StartSync(FighterCommandID command, int initiatorFighterIndex, int targetIndex);


        public static int syncsToMake
        {
            get
            {
                return Y5Lib_ActionFighterSyncManager_Getter_SyncsToMake();
            }
        }

        public static SyncRegisterData GetSyncDataBySerial(int serial)
        {
            return new SyncRegisterData() { Pointer = Y5Lib_ActionFighterSyncManager_GetSyncDataBySerial(serial) };
        }

        public static SyncRegisterData GetSyncToMake(int index)
        {
            return new SyncRegisterData() { Pointer = Y5Lib_ActionFighterSyncManager_Get_SyncToMake(index) };
        }
     
        public static int StartSync(FighterCommandID command, Fighter initiator, Fighter target)
        {
            return StartSync(command, initiator.Index, target.Index);
        }

    }
}
