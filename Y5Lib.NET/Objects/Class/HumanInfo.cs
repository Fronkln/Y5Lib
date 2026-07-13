using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public class HumanInfo : UnmanagedObject
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HUMANINFO_GET", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_HumanInfo_Get(ref ChecksumString name);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HUMANINFO_GETTER_CHARACTER_NAME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_HumanInfo_Getter_CharacterName(IntPtr cHumanInfo);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HUMANINFO_GETTER_DATA", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_HumanInfo_Getter_Data(IntPtr cHumanInfo);

        public string CharacterName => Marshal.PtrToStringAnsi(Y5Lib_HumanInfo_Getter_CharacterName(Pointer));
        public HumanInfoData Data 
        {
            get
            {
                IntPtr dataPtr = Y5Lib_HumanInfo_Getter_Data(Pointer);

                if (dataPtr == IntPtr.Zero)
                    return new HumanInfoData();

                return Marshal.PtrToStructure<HumanInfoData>(dataPtr);
            }
        } 

        public static HumanInfo Get(string characterName)
        {
            ChecksumString hash = new ChecksumString(characterName);

            return new HumanInfo() { Pointer = Y5Lib_HumanInfo_Get(ref hash)};
        }
    }

    [StructLayout(LayoutKind.Sequential, Size = 40)]
    public struct HumanInfoData
    {
        public short InfoID; //0x0000
        public short FaceModel; //0x0002
        public short TopModel; //0x0004
        public short BottomModel; //0x0006
        public short HairModel; //0x0008
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public char[] pad_000A; //0x000A
        public byte HeightIndex; //0x0010
        public byte Type; //0x0011
        public byte CharaID; //0x0012
        public byte MotionSet; //0x0013
        public byte Unk;
        public byte Voicer;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
        public char[] pad_0014; //0x0014
    }
}
