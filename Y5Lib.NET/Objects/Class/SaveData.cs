using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y5Lib.Unsafe;

namespace Y5Lib
{
    public enum SaveChunkType
    {
        General,
        ScenarioState,
        Mission,
        KiryuFighter,
        SaejimaFighter,
        AkiyamaFighter,
        ShinadaFighter,
        Items,
        HarukaFighter,
        PlayerPoints
    }

    public unsafe static class SaveData
    {
        public static int* RawData = (int*)CPP.ResolveRelativeAddress(CPP.PatternSearch("48 8D 05 ? ? ? ? 48 83 C3 ? 83 FE"), 7);

        public static IntPtr GetSaveChunk(SaveChunkType type)
        {
            int offset = RawData[(int)type];

            return ((IntPtr)RawData) + offset;
        }

        public static void CopyDataToSaveChunk(SaveChunkType type, byte[] data)
        {
            IntPtr chunk = GetSaveChunk(type);

            Marshal.Copy(data, 0, chunk, data.Length);
        }
    }
}
