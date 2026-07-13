using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public class Human : Entity
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HUMAN_GETTER_MOTION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_Human_Getter_Motion(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HUMAN_GETTER_MODEL", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_Human_Getter_Model(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HUMAN_GETTER_FIGHTER_INDEX", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_Human_Getter_Fighter_Index(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HUMAN_GETTER_VOICER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_Human_Getter_Voicer(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HUMAN_IS_PLAYER", CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.U1)]
        internal static extern bool Y5Lib_Human_IsPlayer(IntPtr fighter);

        public HumanDraw Model { get { return new HumanDraw() { Pointer = Y5Lib_Human_Getter_Model(Pointer) }; } }
        public HumanMotion HumanMotion { get { return new HumanMotion() { Pointer = Y5Lib_Human_Getter_Motion(Pointer) }; } }

        public int fighterIndex => Y5Lib_Human_Getter_Fighter_Index(Pointer);
        public VoicerID Voicer => (VoicerID)Y5Lib_Human_Getter_Voicer(Pointer);

        public bool IsPlayer() => Y5Lib_Human_IsPlayer(Pointer);

    }
}
