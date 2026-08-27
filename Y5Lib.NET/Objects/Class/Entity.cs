using System;
using System.Runtime.InteropServices;

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

        public EntityUID(ushort serial, ushort kind)
        {
            UID = (kind << 16) | serial;
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
        internal static extern void Y5Lib_Entity_GetPosition(IntPtr ent, out Vector4 pos);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENTITY_GET_CROWN_POSITION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Entity_GetCrownPosition(IntPtr ent, out Vector4 pos);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENTITY_SET_POSITION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Entity_SetPosition(IntPtr ent, Vector4 pos);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENTITY_SET_VISIBILITY", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Entity_SetVisibility(IntPtr ent, bool visible);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENTITY_IS_VISIBLE", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        internal static extern bool Y5Lib_Entity_IsVisible(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENTITY_WARP_TO_POSITION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Entity_WarpToPosition(IntPtr ent, Vector4 pos);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENTITY_GETTER_ROTATION_Y", CallingConvention = CallingConvention.Cdecl)]
        internal static extern ushort Y5Lib_Entity_Getter_RotationY(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENTITY_GETTER_UID", CallingConvention = CallingConvention.Cdecl)]
        internal static extern EntityUID Y5Lib_Entity_Getter_UID(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENTITY_GETTER_INPUT_CONTROLLER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_Entity_Getter_Input_Controller(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ENTITY_CAN_SHOW_TEXT_BUBBLE", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        internal static extern bool Y5Lib_Entity_CanShowTextBubble(IntPtr ent);

        public EntityUID UID { get { return Y5Lib_Entity_Getter_UID(Pointer); } }
        public Vector3 Position
        {
            get
            {
                Vector4 pos;
                Y5Lib_Entity_GetPosition(Pointer, out pos);
                return pos;
            }
            set
            {
                Y5Lib_Entity_SetPosition(Pointer, value);
            }
        }
        public ushort RotationY { get { return Y5Lib_Entity_Getter_RotationY(Pointer); } }

        public EntityMsgComponent MSG { get; private set; }

        public Entity() : base()
        {
            MSG = new EntityMsgComponent() { Owner = this };
        }

        public InputDeviceListener InputController
        {
            get
            {
                return new InputDeviceListener() { Pointer = Y5Lib_Entity_Getter_Input_Controller(Pointer) };
            }
        }

        public void Initialize()
        {
            unsafe
            {
                if (Pointer == IntPtr.Zero)
                    return;
                ((delegate* unmanaged<IntPtr, void>)GetVirtualFunctionAtIndex(1))(Pointer);
            }
        }

        public void SetUID(int uid)
        {
            unsafe
            {
                if (Pointer == IntPtr.Zero)
                    return;

                NativeFunctions.EntityNativeFunctions.SetUID(Pointer, ref uid);
            }
        }

        public void WarpToPosition(Vector3 pos)
        {
            Y5Lib_Entity_WarpToPosition(Pointer, pos);
        }

        public Vector3 GetCrownPosition()
        {
            Vector4 result;
            Y5Lib_Entity_GetCrownPosition(Pointer, out result);

            return result;
        }

        public bool CanShowTextBubble()
        {
            return Y5Lib_Entity_CanShowTextBubble(Pointer);
        }

        public void SetVisible(bool visible)
        {
            Y5Lib_Entity_SetVisibility(Pointer, visible);
        }

        public bool IsVisible()
        {
            return Y5Lib_Entity_IsVisible(Pointer);
        }

        public void RegisterClass(string className)
        {
            unsafe
            {
                if (Pointer == IntPtr.Zero)
                    return;

                NativeFunctions.EntityNativeFunctions.RegisterClass(Pointer, className);
            }
        }
    }
}
