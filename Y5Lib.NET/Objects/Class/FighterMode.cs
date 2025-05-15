using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public class FighterMode : UnmanagedObject
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERMODE_GETTER_NAME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_FighterMode_Getter_Name(IntPtr fighterMode);

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
