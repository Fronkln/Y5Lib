using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y5Lib.Unsafe;

namespace Y5Lib
{
    public unsafe static class SaveData
    {
        public static IntPtr RawData = CPP.ResolveRelativeAddress(CPP.PatternSearch("48 8D 05 ? ? ? ? 48 83 C3 ? 83 FE"), 7);
    }
}
