using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public unsafe struct TempCCCStruct
    {
        public TempCCCStruct *next; //0x0000
        public TempCCCStruct* prev; //0x0008
        public MsgEntityEntry *entityEntry; //0x0010
    }
}
