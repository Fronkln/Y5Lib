using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    [StructLayout(LayoutKind.Sequential, Size = 24)]
    internal unsafe struct EntityBucketNode
    {
        public IntPtr Next;
        public IntPtr Prev;
        public MsgEntityEntry* Entity;
    }
}
