using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public static class ScenarioManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CSCENARIOMANAGER_LOAD_PLAYER_POS", CallingConvention = CallingConvention.Cdecl)]
        public static extern void LoadPlayerPos(int id, bool unknown = false);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CSCENARIOMANAGER_LOAD_SCENARIO", CallingConvention = CallingConvention.Cdecl)]
        public static extern void LoadScenario(uint scenarioID);
    }
}
