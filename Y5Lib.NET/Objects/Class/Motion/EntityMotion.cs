using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public class EntityMotion
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_MOTION_SET_POSITION", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_Motion_SetPosition(IntPtr ent, Vector4 pos);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_MOTION_GETTER_SCALE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Matrix4x4 Y5Lib_Motion_Getter_Scale(IntPtr ent);

        public IntPtr Pointer;

        public Matrix4x4 Scale
        {
            get
            {
                return Y5Lib_Motion_Getter_Scale(Pointer);
            }
        }

        public void SetPosition(Vector3 position) => Y5Lib_Motion_SetPosition(Pointer, position);
    }
}
