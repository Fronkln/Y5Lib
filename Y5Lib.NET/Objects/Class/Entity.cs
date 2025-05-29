using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace Y5Lib
{
    [StructLayout(LayoutKind.Sequential, Size = 0x4)]
    public struct EntityUID
    {
        public int UID;

        public ushort Serial
        {
            get
            {
                return (ushort)(UID & 0xFFFF);
            }
            set
            {
                UID = (int)((UID & 0xFFFF0000) | value);
            }
        }

        public ushort Kind
        {
            get
            {
                return (ushort)((UID >> 16) & 0xFFFF);
            }
        }


        public override bool Equals(object obj) => obj != null && obj is EntityUID other && Equals(other);

        public bool Equals(EntityUID uid) => UID == uid.Serial;

        public override int GetHashCode() => UID.GetHashCode();

        public static bool operator ==(EntityUID lhs, EntityUID rhs) => lhs.Equals(rhs);

        public static bool operator !=(EntityUID lhs, EntityUID rhs) => !(lhs == rhs);

        public override string ToString()
        {
            return UID.ToString();
        }

        public static implicit operator int(EntityUID obj)
        {
            return obj.UID;
        }
    }

    public class Entity : EntityBase
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENTITY_GET_POSITION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Vector4 Y5Lib_Entity_GetPosition(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENTITY_SET_POSITION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Entity_SetPosition(IntPtr ent, Vector4 pos);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENTITY_GETTER_ROTATION_Y", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ushort Y5Lib_Entity_Getter_RotationY(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENTITY_GETTER_UID", CallingConvention = CallingConvention.Cdecl)]
        internal static extern EntityUID Y5Lib_Entity_Getter_UID(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENTITY_GETTER_INPUT_CONTROLLER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_Entity_Getter_Input_Controller(IntPtr ent);

        public EntityUID UID { get { return Y5Lib_Entity_Getter_UID(Pointer); } }
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
