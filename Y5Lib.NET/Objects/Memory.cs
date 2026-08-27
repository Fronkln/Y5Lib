using System;
using System.Collections.Generic;
using System.Text;
using Y5Lib.Unsafe;

namespace Y5Lib
{
    public enum HeapCategory
    {
        NULL = 0x0,
        READBUF = 0x1,
        INSTANCE = 0x2,
        RT = 0x3,
        MISSION = 0x4,
        STAGE = 0x5,
        CHARA = 0x6,
        WANDERER = 0x7,
        SOUND = 0x8,
        PHYSICS = 0x9,
        EFFECT = 0xA,
        _2D = 0xB,
        _MSG = 0xC,
        TEMP = 0xD,
        RESOURCE = 0xE,
        DEBUG = 0xF,
        TOOL = 0x10,
    };


    public unsafe static class Memory
    {

        public static void PushAllocCategory(HeapCategory category, int unk1 = 0, int unk2 = 0) => NativeFunctions.MemoryNativeFunctions.PushAllocCategory(category, unk1, unk2);
        public static void PopAllocCategory() => NativeFunctions.MemoryNativeFunctions.PopAllocCategory();
        public static IntPtr Alloc2(int size, string description, int unknown) => NativeFunctions.MemoryNativeFunctions.Alloc2(size, description, unknown);

    }
}
