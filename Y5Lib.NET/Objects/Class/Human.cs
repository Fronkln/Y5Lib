using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public class Human : Entity
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HUMAN_GETTER_MOTION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_Human_Getter_Motion(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HUMAN_GETTER_MODEL", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_Human_Getter_Model(IntPtr ent);

        public HumanModel Model { get { return new HumanModel() { Pointer = Y5Lib_Human_Getter_Model(Pointer) }; } }
        public HumanMotion HumanMotion { get { return new HumanMotion() { Pointer = Y5Lib_Human_Getter_Motion(Pointer) }; } }
    }
}
