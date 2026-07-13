using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public class MsgPlay : UnmanagedObject
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGPLAY_GETTER_IS_RUNNING", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        internal static extern bool Y5Lib_MsgPlay_Getter_IsRunning(IntPtr pointer);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGPLAY_SETTER_IS_RUNNING", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_MsgPlay_Setter_IsRunning(IntPtr pointer, bool complete);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGPLAY_GETTER_CURRENT_EVENT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern byte Y5Lib_MsgPlay_Getter_CurrentEvent(IntPtr pointer);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGPLAY_SETTER_CURRENT_EVENT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern byte Y5Lib_MsgPlay_Setter_CurrentEvent(IntPtr pointer, byte value);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGPLAY_GETTER_NEXT_EVENT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern byte Y5Lib_MsgPlay_Getter_NextEvent(IntPtr pointer);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGPLAY_SETTER_NEXT_EVENT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern byte Y5Lib_MsgPlay_Setter_NextEvent(IntPtr pointer, int next);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGPLAY_GETTER_IS_TEXT_COMPLETE", CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.U1)]
        internal static extern bool Y5Lib_MsgPlay_Getter_IsTextComplete(IntPtr pointer);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGPLAY_SETTER_IS_TEXT_COMPLETE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_MsgPlay_Setter_IsTextComplete(IntPtr pointer, bool complete);


        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGPLAY_GETTER_CURRENT_TIME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern float Y5Lib_MsgPlay_Getter_CurrentTime(IntPtr pointer);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGPLAY_SETTER_CURRENT_TIME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_MsgPlay_Setter_CurrentTime(IntPtr pointer, short value);


        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGPLAY_GETTER_EVENT_DURATION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern short Y5Lib_MsgPlay_Getter_Duration(IntPtr pointer);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGPLAY_GETTER_CURRENT_TEXT_INDEX", CallingConvention = CallingConvention.Cdecl)]
        internal static extern float Y5Lib_MsgPlay_Getter_CurrentTextIndex(IntPtr pointer);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGPLAY_SETTER_CURRENT_TEXT_INDEX", CallingConvention = CallingConvention.Cdecl)]
        internal static extern byte Y5Lib_MsgPlay_Setter_CurrentTextIndex(IntPtr pointer, float val);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGPLAY_GETTER_TEXT_LENGTH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern float Y5Lib_MsgPlay_Getter_TextLength(IntPtr pointer);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGPLAY_GETTER_FLAGS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_MsgPlay_Getter_Flags(IntPtr pointer);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGPLAY_GETTER_FLAGS2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_MsgPlay_Getter_Flags2(IntPtr pointer);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGPLAY_SETTER_FLAGS2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_MsgPlay_Setter_Flags2(IntPtr pointer, int flags);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGPLAY_GETTER_STATE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_MsgPlay_Getter_State(IntPtr pointer);


        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGPLAY_TO_NEXT_PAGE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void  Y5Lib_MsgPlay_ToNextPage(IntPtr pointer);

        public bool isRunning
        {
            get => Y5Lib_MsgPlay_Getter_IsRunning(Pointer);
            set => Y5Lib_MsgPlay_Setter_IsRunning(Pointer, value);
        }

        public byte currentEvent
        {
            get => Y5Lib_MsgPlay_Getter_CurrentEvent(Pointer);
            set => Y5Lib_MsgPlay_Setter_CurrentEvent(Pointer, value);
        }
        public byte nextEvent
        {
            get => Y5Lib_MsgPlay_Getter_NextEvent(Pointer);
            set => Y5Lib_MsgPlay_Setter_NextEvent(Pointer, value);
        }


        public int state
        {
            get => Y5Lib_MsgPlay_Getter_State(Pointer);
        }


        public short currentTime
        {
            get => (short)Y5Lib_MsgPlay_Getter_CurrentTime(Pointer);
            set => Y5Lib_MsgPlay_Setter_CurrentTime(Pointer, value);
        }

        public short eventDuration => Y5Lib_MsgPlay_Getter_Duration(Pointer);

        public bool isTextComplete
        {
            get => Y5Lib_MsgPlay_Getter_IsTextComplete(Pointer);
            set => Y5Lib_MsgPlay_Setter_IsTextComplete(Pointer, value);
        }

        public float currentTextIndex
        {
            get => Y5Lib_MsgPlay_Getter_CurrentTextIndex(Pointer);
            set => Y5Lib_MsgPlay_Setter_CurrentTextIndex(Pointer, value);
        }

        public float currentTextLength
        {
            get => Y5Lib_MsgPlay_Getter_TextLength(Pointer);
        }

        public int flags
        {
            get => Y5Lib_MsgPlay_Getter_Flags(Pointer);
        }

        public int flags2
        {
            get => Y5Lib_MsgPlay_Getter_Flags2(Pointer);
            set => Y5Lib_MsgPlay_Setter_Flags2(Pointer, value);
        }

        public void ToNextPage() => Y5Lib_MsgPlay_ToNextPage(Pointer);
    }
}
