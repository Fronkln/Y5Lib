using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public static class InputDeviceData
    {
        /// <summary>
        /// Get raw input data from device
        /// </summary>
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_INPUT_GET_RAW_DATA", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetRawData(InputDeviceType type);
    }
}
