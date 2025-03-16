using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    //Dance Battle
    public class LiveBtlPlayer : Human
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_LIVEBTLPLAYER_GET_CURRENT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_LiveBtlPlayer_GetCurrent();


        public static LiveBtlPlayer Current
        {
            get
            {
                return new LiveBtlPlayer() { Pointer = Y5Lib_LiveBtlPlayer_GetCurrent() };
            }
        }
    }
}
