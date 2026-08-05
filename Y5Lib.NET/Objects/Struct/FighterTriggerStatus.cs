using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    [StructLayout(LayoutKind.Sequential, Size = 0x168)]
    public struct FighterTriggerStatus
    {
        public ChecksumString hactName;
        public IntPtr hactRange; //0x0020
        public long pad_0028; //0x0028
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public int[] hactRegisters; //0x0030
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 176)]
        public char[] pad_00B0; //0x00B0
        public int pairUID; //0x0160
        public int pad_0164; //0x0164

        public static FighterTriggerStatus Default
        {
            get
            {
                FighterTriggerStatus status = new FighterTriggerStatus();
                status.hactName = new ChecksumString();
                status.hactRange = IntPtr.Zero;
                status.pad_0028 = 0;
                status.hactRegisters = new int[32];
                status.pad_00B0 = new char[176];
                status.pairUID = -1;
                status.pad_0164 = 0;

                for(int i = 0; i < status.hactRegisters.Length; i++)
                    status.hactRegisters[i] = -1;

                return status;
            }
        }

        public void SetHAct(string hact)
        {
            hactName.Set(hact);
        }

        public void RegisterHActFighter(HActReplaceID registerID, Fighter fighter)
        {
            hactRegisters[(int)registerID] = fighter.fighterIndex;
        }
    }
}
