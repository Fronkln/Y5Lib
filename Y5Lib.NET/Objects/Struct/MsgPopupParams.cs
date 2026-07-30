using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public struct MsgPopupParams
    {
        public int type;
        public int entityUID;
        
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] dat;
    }
}
