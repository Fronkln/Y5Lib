using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public unsafe struct PXDLinkedListNode
    {
        public IntPtr Next;
        public IntPtr Prev;
        public IntPtr Value;

        public T Get<T>() where T : UnmanagedObject, new()
        {
            return new T() { Pointer = Value };
        }
    }
}
