using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public class Human : Entity
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HUMAN_GETTER_MOTION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_Human_Getter_Motion(IntPtr ent);

        public HumanMotion HumanMotion { get { return new HumanMotion() { Pointer = Y5Lib_Human_Getter_Motion(Pointer) }; } }
    }
}
