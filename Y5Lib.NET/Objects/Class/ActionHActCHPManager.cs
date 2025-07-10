using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public static class ActionHActCHPManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_HACTCHPMANAGER_GET_CURRENT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_HActCHPManager_GetCurrent();

        public static string CurrentName
        {
            get
            {
                return Marshal.PtrToStringAnsi(Y5Lib_HActCHPManager_GetCurrent());
            }
        }
    }
}
