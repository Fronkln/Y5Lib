using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public class HumanModel : UnmanagedObject
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HUMANMODEL_GETTER_MODELNAME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_HumanModel_Getter_Name(IntPtr model);

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
    }
}
