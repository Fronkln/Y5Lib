using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public class HumanDraw : UnmanagedObject
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CHUMANDRAW_GETTER_OWNER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_HumanModel_Getter_Owner(IntPtr model);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CHUMANDRAW_GETTER_MODELNAME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_HumanModel_Getter_Name(IntPtr model);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CHUMANDRAW_GETTER_FLAGS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_HumanModel_Getter_Flags(IntPtr model);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CHUMANDRAW_SETTER_FLAGS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_HumanModel_Setter_Flags(IntPtr model, int flags);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CHUMANDRAW_SET_EXPRESSION_WEIGHT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_HumanDraw_SetExpressionWeight(IntPtr model, int expression, float weight);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CHUMANDRAW_SET_SINGLE_EXPRESSION_WEIGHT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_HumanDraw_SetSingleExpressionWeight(IntPtr model, int expression, float weight);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CHUMANDRAW_SET_SINGLE_FACE_EXPRESSION_WEIGHT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_HumanDraw_SetSingleExpressionFaceWeight(IntPtr model, int expression, float weight);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CHUMANDRAW_SET_SINGLE_MOUTH_EXPRESSION_WEIGHT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_HumanDraw_SetSingleExpressionMouthWeight(IntPtr model, int expression, float weight);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CHUMANDRAW_GET_FACE_EXPRESSION_WEIGHT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern float Y5Lib_HumanDraw_GetExpressionFaceWeight(IntPtr model, int expression);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CHUMANDRAW_GET_MOUTH_EXPRESSION_WEIGHT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern float Y5Lib_HumanDraw_GetExpressionMouthWeight(IntPtr model, int expression);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CHUMANDRAW_SET_FACE_EXPRESSION_WEIGHT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_HumanDraw_SetFaceExpressionWeight(IntPtr model, int expression, float weight);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CHUMANDRAW_SET_MOUTH_EXPRESSION_WEIGHT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_HumanDraw_SetMouthExpressionWeight(IntPtr model, int expression, float weight);

        public Human Owner => new Human() { Pointer = Y5Lib_HumanModel_Getter_Owner(Pointer) };

        public string Name
        {
            get
            {
                IntPtr namePtr = Y5Lib_HumanModel_Getter_Name(Pointer);

                if (namePtr == IntPtr.Zero)
                    return "";

                return Marshal.PtrToStringAnsi(namePtr);
            }
        }

        public int Flags
        {
            get => Y5Lib_HumanModel_Getter_Flags(Pointer);
            set => Y5Lib_HumanModel_Setter_Flags(Pointer, value);
        }

        public void SetExpressionWeight(int expression, float weight)
        {
            Y5Lib_HumanDraw_SetExpressionWeight(Pointer, expression, weight);
        }

        public void SetFaceExpressionWeight(int expression, float weight)
        {
            Y5Lib_HumanDraw_SetFaceExpressionWeight(Pointer, expression, weight);
        }

        public void SetMouthExpressionWeight(int expression, float weight)
        {
            Y5Lib_HumanDraw_SetMouthExpressionWeight(Pointer, expression, weight);
        }

        /// <summary>
        /// Set weights for only this expression, clear out others
        /// </summary>
        public void SetSingleExpressionWeight(int expression, float weight)
        {
            Y5Lib_HumanDraw_SetSingleExpressionWeight(Pointer, expression, weight);
        }

        /// <summary>
        /// Set face weights for only this expression, clear out others
        /// </summary>
        public void SetSingleExpressionFaceWeight(int expression, float weight)
        {
            Y5Lib_HumanDraw_SetSingleExpressionFaceWeight(Pointer, expression, weight);
        }

        /// <summary>
        /// Set mouth weights for only this expression, clear out others
        /// </summary>
        public void SetSingleExpressionMouthWeight(int expression, float weight)
        {
            Y5Lib_HumanDraw_SetSingleExpressionMouthWeight(Pointer, expression, weight);
        }


        public float GetExpressionFaceWeight(int expression)
        {
            return Y5Lib_HumanDraw_GetExpressionFaceWeight(Pointer, expression);
        }

        public float GetExpressionMouthWeight(int expression)
        {
            return Y5Lib_HumanDraw_GetExpressionMouthWeight(Pointer, expression);
        }
    }
}
