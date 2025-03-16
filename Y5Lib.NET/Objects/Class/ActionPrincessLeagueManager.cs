using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public static class ActionPrincessLeagueManager
    {

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_PRINCESSLEAGUEMANAGER_GET_PLAYER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_PrincessLeagueManager_GetPlayer();


        public static Human Player
        {
            get
            {
                return new Human() { Pointer = Y5Lib_PrincessLeagueManager_GetPlayer() };
            }
        }
    }
}
