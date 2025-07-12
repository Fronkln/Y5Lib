using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public class HAct : UnmanagedObject
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HACT_GET_NAME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_HAct_GetName(IntPtr hact);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HACT_GET_CURRENT_FRAME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern float Y5Lib_HAct_GetCurrentFrame(IntPtr hact);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HACT_SET_CURRENT_FRAME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_HAct_SetCurrentFrame(IntPtr hact, float frame);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HACT_GET_END_FRAME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern float Y5Lib_HAct_GetEndFrame(IntPtr hact);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HACT_GET_FLAGS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_HAct_GetFlags(IntPtr hact);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HACT_SET_FLAGS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_HAct_SetFlags(IntPtr hact, int flags);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HACT_GET_TRANSFORM", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Matrix4x4 Y5Lib_HAct_GetTransform(IntPtr hact);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HACT_SET_TRANSFORM", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_HAct_SetTransform(IntPtr hact, Matrix4x4 mtx);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HACT_GETTER_PHASE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_HAct_Getter_Phase(IntPtr hact);

        public string Name
        {
            get
            {
                IntPtr namePtr = Y5Lib_HAct_GetName(Pointer);

                if (namePtr == IntPtr.Zero)
                    return "";
                else
                    return Marshal.PtrToStringAnsi(namePtr);
            }
        }

        public float CurrentFrame
        {
            get
            {
                return Y5Lib_HAct_GetCurrentFrame(Pointer);
            }
            set
            {
                Y5Lib_HAct_SetCurrentFrame(Pointer, value);
            }
        }

        public float EndFrame
        {
            get
            {
                return Y5Lib_HAct_GetEndFrame(Pointer);
            }
        }

        public int Phase
        {
            get
            {
                return Y5Lib_HAct_Getter_Phase(Pointer);
            }
        }


        public int Flags
        {
            get
            {
                return Y5Lib_HAct_GetFlags(Pointer);
            }
            set
            {
                Y5Lib_HAct_SetFlags(Pointer, value);
            }
        }

        public Matrix4x4 Transform
        {
            get
            {
                return Y5Lib_HAct_GetTransform(Pointer);
            }
            set
            {
                Y5Lib_HAct_SetTransform(Pointer, value);
            }
        }
    }
}
