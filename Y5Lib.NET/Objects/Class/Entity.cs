using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public class Entity : EntityBase
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENTITY_GET_POSITION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Vector4 Y5Lib_Entity_GetPosition(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENTITY_SET_POSITION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Entity_SetPosition(IntPtr ent, Vector4 pos);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENTITY_GETTER_ROTATION_Y", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ushort Y5Lib_Entity_Getter_RotationY(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENTITY_GETTER_UID", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_Entity_Getter_UID(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENTITY_GETTER_INPUT_CONTROLLER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_Entity_Getter_Input_Controller(IntPtr ent);

        public int UID { get { return Y5Lib_Entity_Getter_UID(Pointer); } }
        public Vector3 Position { get { return Y5Lib_Entity_GetPosition(Pointer); } set { Y5Lib_Entity_SetPosition(Pointer, value); } }
        public ushort RotationY { get { return Y5Lib_Entity_Getter_RotationY(Pointer); } }

        public InputDeviceListener InputController
        {
            get
            {
                return new InputDeviceListener() { Pointer = Y5Lib_Entity_Getter_Input_Controller(Pointer) };
            }
        }
    }
}
