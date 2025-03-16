using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public class BoneMotion : EntityMotion
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_BONEMOTION_GETTER_MATRIX", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Matrix4x4 Y5Lib_Motion_Getter_Matrix(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_BONEMOTION_GETTER_CURRENT_ANIMATION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Y5Lib_Motion_Getter_CurrentAnimation(IntPtr ent);


        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_BONEMOTION_GETTER_NEXT_ANIMATION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Y5Lib_Motion_Getter_NextAnimation(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_BONEMOTION_SETTER_NEXT_ANIMATION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Y5Lib_Motion_Setter_NextAnimation(IntPtr ent, uint anim);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_BONEMOTION_GETTER_ANIMATION_TIME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern float Y5Lib_Motion_Getter_CurrentAnimationTime(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_BONEMOTION_SETTER_ANIMATION_TIME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Motion_Setter_CurrentAnimationTime(IntPtr ent, float time);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_BONEMOTION_GETTER_PREVIOUS_ANIMATION_TIME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern float Y5Lib_Motion_Getter_PreviousAnimationTime(IntPtr ent);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_BONEMOTION_SETTER_PREVIOUS_ANIMATION_TIME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Motion_Setter_PreviousAnimationTime(IntPtr ent, float time);

        public Matrix4x4 Matrix
        {
            get
            {
                return Y5Lib_Motion_Getter_Matrix(Pointer);
            }
        }

        public MotionID CurrentAnimation { get { return (MotionID)Y5Lib_Motion_Getter_CurrentAnimation(Pointer); } }
        public float AnimationTime 
        { 
            get 
            { 
                return Y5Lib_Motion_Getter_CurrentAnimationTime(Pointer);
            }
            set
            {
                Y5Lib_Motion_Setter_CurrentAnimationTime(Pointer, value);
            }
        }
        public float PreviousAnimationTime 
        {
            get 
            { 
                return Y5Lib_Motion_Getter_PreviousAnimationTime(Pointer); 
            }
            set
            {
                Y5Lib_Motion_Setter_PreviousAnimationTime (Pointer, value);
            }
        }

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
    }
}
