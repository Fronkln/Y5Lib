using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public class LbdSheetHandler : UnmanagedObject
    {
        public LbdData GetLbdData()
        {
            IntPtr lbdDataPtr = Marshal.ReadIntPtr(Pointer + 0x10);

            if (lbdDataPtr == IntPtr.Zero)
                return new LbdData();
            
            return new LbdData() { Pointer = lbdDataPtr };
        }
    }
}
