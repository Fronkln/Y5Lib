using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public class HumanMotion : BoneMotion
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HUMANMOTION_GET_POSITION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Vector3 Y5Lib_Motion_GetPosition(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HUMANMOTION_GET_ANGLE_Y", CallingConvention = CallingConvention.Cdecl)]
        internal static extern short Y5Lib_Motion_GetAngleY(IntPtr ent);
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HUMANMOTION_SET_ANGLE_Y", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Motion_SetAngleY(IntPtr ent, short angle);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HUMANMOTION_GETTER_FLAGS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Y5Lib_HumanMotion_Getter_Flags(IntPtr ent);
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HUMANMOTION_SETTER_FLAGS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_HumanMotion_Setter_Flags(IntPtr ent, uint flags);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HUMANMOTION_GETTER_MODE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Y5Lib_HumanMotion_Getter_Mode(IntPtr ent);
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HUMANMOTION_SETTER_MODE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_HumanMotion_Setter_Mode(IntPtr ent, uint mode);


        public uint Flags
        {
            get { return Y5Lib_HumanMotion_Getter_Flags(Pointer); }
            set { Y5Lib_HumanMotion_Setter_Flags(Pointer, value); }
        }

        public uint Mode
        {
            get { return Y5Lib_HumanMotion_Getter_Mode(Pointer); }
            set { Y5Lib_HumanMotion_Setter_Mode(Pointer, value); }
        }

        public Vector3 GetPosition() { return Y5Lib_Motion_GetPosition(Pointer); }

        public short GetAngleY() { return Y5Lib_Motion_GetAngleY(Pointer); }
        public void SetAngleY(short angle) => Y5Lib_Motion_SetAngleY(Pointer, angle);      
    }
}
