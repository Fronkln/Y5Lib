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
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONFIGHTERSYNCMANAGER_START_SYNC", CallingConvention = CallingConvention.Cdecl)]
        public static extern int StartSync(FighterCommandID command, int initiatorFighterIndex, int targetIndex);

     
        public static int StartSync(FighterCommandID command, Fighter initiator, Fighter target)
        {
            return StartSync(command, initiator.Index, target.Index);
        }

    }
}
