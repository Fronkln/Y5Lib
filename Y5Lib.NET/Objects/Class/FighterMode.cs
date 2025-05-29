using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public class FighterMode : UnmanagedObject
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODE_GETTER_NAME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_FighterMode_Getter_Name(IntPtr fighterMode);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODE_GETTER_FIGHTER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_FighterMode_Getter_Fighter(IntPtr fighterMode);


        public Fighter Fighter
        {
            get
            {
                return new Fighter() { Pointer = Y5Lib_FighterMode_Getter_Fighter(Pointer) };
            }
        }

        public string Name
        {
            get
            {
                IntPtr namePtr = Y5Lib_FighterMode_Getter_Name(Pointer);

                if (namePtr == IntPtr.Zero)
                    return "";

                return Marshal.PtrToStringAnsi(namePtr);
            }
        }
    }
}
