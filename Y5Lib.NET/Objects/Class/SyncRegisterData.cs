using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public class SyncRegisterData : UnmanagedObject
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SYNCREGISTERDATA_GETTER_COMMAND", CallingConvention = CallingConvention.Cdecl)]
        internal static extern FighterCommandID Y5Lib_SyncRegisterData_Getter_Command(IntPtr syncRegDat);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SYNCREGISTERDATA_GETTER_PAIR_COUNT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_SyncRegisterData_Getter_PairCount(IntPtr syncRegDat);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_SYNCREGISTERDATA_GET_PAIR_FIGHTER_INDEX", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_SyncRegisterData_Get_Pair_Fighter_Index(IntPtr syncRegDat, int index);


        public FighterCommandID Command
        {
            get
            {
                return Y5Lib_SyncRegisterData_Getter_Command(Pointer);
            }
        }
        public int pairCount
        {
            get
            {
                return Y5Lib_SyncRegisterData_Getter_PairCount(Pointer);
            }
        }

        public int GetPairFighterIndex(int pairIndex)
        {
            return Y5Lib_SyncRegisterData_Get_Pair_Fighter_Index(Pointer, pairIndex);
        }
    }
}
