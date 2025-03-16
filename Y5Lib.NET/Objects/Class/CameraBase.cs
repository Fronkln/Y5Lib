using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public class CameraBase : Entity
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CCAMERABASE_GETTER_CURRENT_POSITION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Vector4 Y5Lib_CameraBase_Getter_CurrentPosition(IntPtr cam);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CCAMERABASE_SETTER_CURRENT_POSITION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_CameraBase_Setter_CurrentPosition(IntPtr cam, Vector4 pos);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CCAMERABASE_GETTER_FOCUS_POSITION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Vector4 Y5Lib_CameraBase_Getter_FocusPosition(IntPtr cam);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CCAMERABASE_SETTER_FOCUS_POSITION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_CameraBase_Setter_FocusPosition(IntPtr cam, Vector4 pos);


        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CCAMERABASE_GETTER_MATRIX", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Matrix4x4 Y5Lib_CameraBase_Getter_Matrix(IntPtr cam);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CCAMERABASE_GETTER_FOV", CallingConvention = CallingConvention.Cdecl)]
        internal static extern float Y5Lib_CameraBase_Getter_FOV(IntPtr cam);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CCAMERABASE_SETTER_FOV", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_CameraBase_Setter_FOV(IntPtr cam, float fov);

        public new Vector3 Position
        {
            get
            {
                return Y5Lib_CameraBase_Getter_CurrentPosition(Pointer);
            }
            set
            {
                Y5Lib_CameraBase_Setter_CurrentPosition(Pointer, value);
            }
        }

        public Vector3 FocusPosition
        {
            get
            {
                return Y5Lib_CameraBase_Getter_FocusPosition(Pointer);
            }
            set
            {
                Y5Lib_CameraBase_Setter_FocusPosition(Pointer, value);
            }
        }

        public Matrix4x4 Matrix
        {
            get
            {
                return Y5Lib_CameraBase_Getter_Matrix(Pointer);
            }
        }

        public float FieldOfView
        {
            get
            {
                return Y5Lib_CameraBase_Getter_FOV(Pointer);
            }
            set
            {
                Y5Lib_CameraBase_Setter_FOV(Pointer, value);
            }
        }
    }
}
