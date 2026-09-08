using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public class MsgChoice : UnmanagedVirtualObject
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGCHOICE_SET_CURRENT_CHOICE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_MsgChoice_SetChoice(IntPtr choice, int choiceIdx);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CMSGCHOICE_CONFIRM_CHOICE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_MsgChoice_ConfirmChoice(IntPtr choice);

        public sbyte CurrentChoice
        {
            get
            {
                if (Pointer == IntPtr.Zero)
                    return -1;

                unsafe
                {
                    return *(sbyte*)(Pointer + 0x440);
                }
            }
        }

        public bool IsChoiceMade()
        {
            if (Pointer == IntPtr.Zero)
                return false;

            unsafe
            {
                return *(bool*)(Pointer + 0x680);
            }
        }

        public void SelectAndConfirmChoice(int choice)
        {

        }

        public void ConfirmChoice()
        {
            Y5Lib_MsgChoice_ConfirmChoice(Pointer);
        }
        
        public void SetChoice(int choiceIdx)
        {
            Y5Lib_MsgChoice_SetChoice(Pointer, choiceIdx);
        }
    }
}
