using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public static class ActionCCCManager
    {
        //Actually linked node type, but we only need to fill entityEntry for PlayCCC to work.
        private unsafe struct TempCCCStruct
        {
            public TempCCCStruct* next; //0x0000
            public TempCCCStruct* prev; //0x0008
            public MsgEntityEntry* entityEntry; //0x0010
        }

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONCCCMANAGER_GETTER_IS_ACTIVE", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool Y5Lib_ActionCCCManager_Getter_IsActive();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONCCCMANAGER_GETTER_ACTIVE_CCC", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr Y5Lib_ActionCCCManager_Getter_ActiveCCC();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONCCCMANAGER_GETTER_CURRENT_TALKER_UID", CallingConvention = CallingConvention.Cdecl)]
        private static extern int Y5Lib_ActionCCCManager_Getter_CurrentTalkerUID();


        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONCCCMANAGER_PLAY_CCC", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static unsafe extern bool Y5Lib_ActionCCCManager_PlayCCC(TempCCCStruct** nodePtrPtr, int entityUID, short groupID, MsgGroupHeader* msgGroupHeader, int someVar);
        private static unsafe TempCCCStruct* m_tempCCCVar = (TempCCCStruct*)Marshal.AllocHGlobal(24);

        public static bool isActive
        {
            get
            {
                return Y5Lib_ActionCCCManager_Getter_IsActive();
            }
        }

        public static MsgPlay ActiveMsg => new MsgPlay() { Pointer = Y5Lib_ActionCCCManager_Getter_ActiveCCC() };

        public static int CurrentTalkerUID => Y5Lib_ActionCCCManager_Getter_CurrentTalkerUID();

        public unsafe static bool PlayMSG(Entity entity, byte groupID)
        {
            if (entity.Pointer == IntPtr.Zero || !entity.MSG.HaveMsgData())
                return false;

            var msgData = entity.MSG.Data;
            var msgHeader = entity.MSG.Header;

            if (groupID >= msgHeader->groupCount)
                return false;

            var group = msgHeader->GetGroup(groupID);

            m_tempCCCVar->entityEntry = entity.MSG.Data;


            fixed (TempCCCStruct** ptr = &m_tempCCCVar)
            {
                return Y5Lib_ActionCCCManager_PlayCCC(ptr, entity.UID, groupID, group, 0);
            }
        }
    }
}
