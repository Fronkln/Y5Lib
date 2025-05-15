using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public class Fighter : Human
    {

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_DISPOSE_INFO", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_Fighter_Getter_DisposeInfo(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_MODEL_NAME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_Fighter_Getter_ModelName(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_FIGHTERMODEMANAGER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_Fighter_Getter_FighterModeManager(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_GETTER_INPUT_FLAGS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_Fighter_Getter_InputFlags(IntPtr fighter);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTER_SETTER_INPUT_FLAGS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Fighter_Setter_InputFlags(IntPtr fighter, int val);

        public unsafe DisposeInfo Dispose
        {
            get
            {
                IntPtr dispInf = Y5Lib_Fighter_Getter_DisposeInfo(Pointer);

                if (dispInf == IntPtr.Zero)
                    return new DisposeInfo();

                DisposeInfo informat = Marshal.PtrToStructure<DisposeInfo>(dispInf);
                return informat;
            }
        }

        public string Model
        {
            get
            {
                IntPtr ptr = Y5Lib_Fighter_Getter_ModelName(Pointer);
                return ptr != IntPtr.Zero ? Marshal.PtrToStringAnsi(ptr) : "invalid";
            }
        }

        public FighterModeManager ModeManager
        {
            get
            {
                return new FighterModeManager() { Pointer = Y5Lib_Fighter_Getter_FighterModeManager(Pointer) };
            }
        }

        public int InputFlags
        {
            get
            {
                return Y5Lib_Fighter_Getter_InputFlags(Pointer);
            }
            set
            {
                Y5Lib_Fighter_Setter_InputFlags(Pointer, value);
            }
        }
    }
}
