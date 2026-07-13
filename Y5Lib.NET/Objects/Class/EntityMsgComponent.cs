using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public unsafe class EntityMsgComponent
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENTITY_GETTER_MSG_DATA", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_Entity_Getter_MsgData(IntPtr ent);


        internal Entity Owner { get; set; }


        public bool HaveMsgData()
        {
            return Y5Lib_Entity_Getter_MsgData(Owner.Pointer) != IntPtr.Zero;
        }

        public MsgEntityEntry* Data
        {
            get
            {
                return (MsgEntityEntry*)Y5Lib_Entity_Getter_MsgData(Owner.Pointer);
            }
        }

        public MsgHeader* Header
        {
            get
            {
                if (!HaveMsgData())
                    return null;

                var header = Data->header;

                return (MsgHeader*)((long)header + header->msgDataRelPointer + 4);
            }
        }
    }
}
