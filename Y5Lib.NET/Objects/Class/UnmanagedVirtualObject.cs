using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public class UnmanagedVirtualObject : UnmanagedObject
    {
        public IntPtr GetVirtualFunctionAtIndex(int index)
        {
            if (Pointer == IntPtr.Zero)
                return IntPtr.Zero;

            IntPtr vfTable = Marshal.ReadIntPtr(Pointer);
            int offset = (index * 8);
            IntPtr fAddr = vfTable + offset;

            return Marshal.ReadIntPtr(fAddr);
        }

        public IntPtr GetVirtualFunctionAtOffset(int offset)
        {
            if (Pointer == IntPtr.Zero)
                return IntPtr.Zero;

            IntPtr vfTable = Marshal.ReadIntPtr(Pointer);
            IntPtr fAddr = vfTable + offset;

            return Marshal.ReadIntPtr(fAddr);
        }
    }
}
