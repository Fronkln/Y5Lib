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

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONCCCMANAGER_GETTER_IS_DYNAMIC_DIALOGUE_ACTIVE", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool Y5Lib_ActionCCCManager_Getter_IsDynamicDialogueActive();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONCCCMANAGER_GETTER_ACTIVE_CCC", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr Y5Lib_ActionCCCManager_Getter_ActiveCCC();


        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONCCCMANAGER_GETTER_MSGCHOICE", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr Y5Lib_ActionCCCManager_Getter_ActiveCCCChoice();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONCCCMANAGER_GETTER_CURRENT_TALKER_UID", CallingConvention = CallingConvention.Cdecl)]
        private static extern int Y5Lib_ActionCCCManager_Getter_CurrentTalkerUID();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONCCCMANAGER_GET_CCC_CHARACTER_BY_UID", CallingConvention = CallingConvention.Cdecl)]
        private static unsafe extern IntPtr Y5Lib_ActionCCCManager_GetCCCCharacterByUID(int uid);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONCCCMANAGER_GET_ENTITY_DATA", CallingConvention = CallingConvention.Cdecl)]
        public static unsafe extern IntPtr GetEntityData(MsgEntityEntry* data);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONCCCMANAGER_PLAY_CCC", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static unsafe extern bool Y5Lib_ActionCCCManager_PlayCCC(TempCCCStruct** nodePtrPtr, int entityUID, short groupID, MsgGroupHeader* msgGroupHeader, int someVar);
        private static unsafe TempCCCStruct* m_tempCCCVar = (TempCCCStruct*)Marshal.AllocHGlobal(24);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONCCCMANAGER_SHOW_POPUP", CallingConvention = CallingConvention.Cdecl)]
        public static unsafe extern void ShowPopUp(ref MsgPopupParams param, int index = 0);


        public static bool isActive => Y5Lib_ActionCCCManager_Getter_IsActive();
        public static bool isDynamicDialogueActive => Y5Lib_ActionCCCManager_Getter_IsDynamicDialogueActive();


        public static MsgPlay ActiveMsg => new MsgPlay() { Pointer = Y5Lib_ActionCCCManager_Getter_ActiveCCC() };
        public static MsgChoice ActiveMsgChoice => new MsgChoice() { Pointer = Y5Lib_ActionCCCManager_Getter_ActiveCCCChoice() };

        public static int CurrentTalkerUID => Y5Lib_ActionCCCManager_Getter_CurrentTalkerUID();

        internal static void Init()
        {

        }


        public static bool IsHumanInMsg(Human human)
        {
            return Y5Lib_ActionCCCManager_GetCCCCharacterByUID(human.UID) != IntPtr.Zero;
        }

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

        public unsafe static bool PlayMSG(MsgEntityEntry* entry, byte groupID)
        {
            if (entry == null)
                return false;

            var msgData = entry;

            var msgHeader = (MsgHeader*)((long)entry->header + entry->header->msgDataRelPointer + 4);

            if (groupID >= msgHeader->groupCount)
                return false;

            var group = msgHeader->GetGroup(groupID);

            m_tempCCCVar->entityEntry = entry;


            fixed (TempCCCStruct** ptr = &m_tempCCCVar)
            {
                return Y5Lib_ActionCCCManager_PlayCCC(ptr, entry->header->entityUID, groupID, group, 0);
            }
        }

        public unsafe static IntPtr GetBucket(EntityBucketID bucketID)
        {
            IntPtr cccMan = ActionManager.GetAction(41);
            IntPtr bucketsContainer  = *(IntPtr*)(cccMan + 0x218);

            if (bucketsContainer == IntPtr.Zero)
                return IntPtr.Zero;

            IntPtr bucketsStart = (bucketsContainer + 8);
            int bucketOffset = (int)bucketID * 24;
            IntPtr bucketAddr = bucketsStart + bucketOffset;

            return bucketAddr;
        }

        public unsafe static MsgEntityEntry[] GetEntityEntriesInBucket(EntityBucketID bucketID)
        {
            IntPtr bucket = GetBucket(bucketID);

            ulong count = (ulong)Marshal.ReadInt64(bucket + 0x10);

            if (count <= 0)
                return new MsgEntityEntry[0];

            EntityBucketNode* current = *(EntityBucketNode**)(bucket);

            List<MsgEntityEntry> entityEntries = new List<MsgEntityEntry>();

            while (true)
            {
                entityEntries.Add(*current->Entity);
                current = (EntityBucketNode*)current->Next;

                if ((IntPtr)current == bucket)
                    break;
            }

            return entityEntries.ToArray();
        }

        public unsafe static MsgEntityEntry*[] GetEntityEntryPointersInBucket(EntityBucketID bucketID)
        {
            IntPtr bucket = GetBucket(bucketID);

            ulong count = (ulong)Marshal.ReadInt64(bucket + 0x10);

            if (count <= 0)
                return new MsgEntityEntry*[0];

            EntityBucketNode* current = *(EntityBucketNode**)(bucket);

            List<IntPtr> entityEntries = new List<IntPtr>();

            while(true)
            {
                entityEntries.Add((IntPtr)current->Entity);
                current = (EntityBucketNode*)current->Next;

                if ((IntPtr)current == bucket)
                    break;
            }

            MsgEntityEntry*[] entities = new MsgEntityEntry*[entityEntries.Count];

            for (int i = 0; i < entityEntries.Count; i++)
                entities[i] = (MsgEntityEntry*)entityEntries[i];

            return entities;
        }

        public unsafe static MsgEntityEntry* FindEntityEntryInBucket(EntityBucketID bucketID, int entityUID)
        {
            IntPtr bucket = GetBucket(bucketID);

            if (bucket == IntPtr.Zero)
                return null;

            ulong count = (ulong)Marshal.ReadInt64(bucket + 0x10);

            if (count <= 0)
                return null;

            EntityBucketNode* current = *(EntityBucketNode**)(bucket);
            List<IntPtr> entityEntries = new List<IntPtr>();

            while (true)
            {
                if (current->Entity->header->entityUID == entityUID)
                    return current->Entity;

                entityEntries.Add((IntPtr)current->Entity);
                current = (EntityBucketNode*)current->Next;

                if ((IntPtr)current == bucket)
                    break;
            }

            return null;
        }

        public unsafe static MsgEntityEntry* FindEntityEntryInBuckets(int entityUID)
        {
            for(int i = 0; i < 134; i++)
            {
                MsgEntityEntry* entry = FindEntityEntryInBucket((EntityBucketID)i, entityUID);

                if (entry != null)
                    return entry;
            }

            return (MsgEntityEntry*)0;
        }
    }
}
