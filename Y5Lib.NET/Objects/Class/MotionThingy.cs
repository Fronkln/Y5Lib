using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public class MotionThingy
    {
        public IntPtr Pointer;

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_MOTION_SET_POSITION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Motion_SetPosition(IntPtr ent, Vector4 pos);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_MOTION_GET_ANGLE_Y", CallingConvention = CallingConvention.Cdecl)]
        internal static extern short Y5Lib_Motion_GetAngleY(IntPtr ent);
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_MOTION_SET_ANGLE_Y", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Motion_SetAngleY(IntPtr ent, short angle);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_MOTION_GET_ROOT_MATRIX", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Matrix4x4 Y5Lib_Motion_Get_Root_Matrix(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_MOTION_GETTER_CURRENT_ANIMATION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Y5Lib_Motion_Getter_CurrentAnimation(IntPtr ent);


        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_MOTION_GETTER_NEXT_ANIMATION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Y5Lib_Motion_Getter_NextAnimation(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_MOTION_SETTER_NEXT_ANIMATION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Y5Lib_Motion_Setter_NextAnimation(IntPtr ent, uint anim);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_MOTION_GETTER_ANIMATION_TIME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern float Y5Lib_Motion_Getter_CurrentAnimationTime(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_MOTION_GETTER_PREVIOUS_ANIMATION_TIME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern float Y5Lib_Motion_Getter_PreviousAnimationTime(IntPtr ent);


        public Matrix4x4 GetRootMatrix()
        {
            return Y5Lib_Motion_Get_Root_Matrix(Pointer);
        }


        public MotionID CurrentAnimation { get { return (MotionID)Y5Lib_Motion_Getter_CurrentAnimation(Pointer); } }
        public float AnimationTime { get { return Y5Lib_Motion_Getter_CurrentAnimationTime(Pointer); } }
        public float PreviousAnimationTime { get { return Y5Lib_Motion_Getter_PreviousAnimationTime(Pointer); } }

        public MotionID NextAnimation
        {
            get
            {
                return (MotionID)Y5Lib_Motion_Getter_NextAnimation(Pointer);
            }
            set 
            { 
                Y5Lib_Motion_Setter_NextAnimation(Pointer, (uint)value);
            } 
        }

        public short GetAngleY() { return Y5Lib_Motion_GetAngleY(Pointer); }
        public void SetAngleY(short angle) => Y5Lib_Motion_SetAngleY(Pointer, angle);
        public void SetPosition(Vector3 position) => Y5Lib_Motion_SetPosition(Pointer, position);
    }
}
