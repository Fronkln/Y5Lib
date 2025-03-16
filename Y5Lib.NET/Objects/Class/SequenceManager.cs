using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public static class SequenceManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SEQUENCEMANAGER_GETTER_CURRENT_MISSION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Y5Lib_ActionSequenceManager_Getter_CurrentMission();

        public static uint MissionID { get { return Y5Lib_ActionSequenceManager_Getter_CurrentMission(); } }
    }
}
