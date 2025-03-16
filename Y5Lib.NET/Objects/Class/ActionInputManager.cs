using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public static class ActionInputManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONPUTDEVICEMANAGER_GET_SLOT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_ActionInputDeviceManager_Get_Slot(InputDeviceType type);

        public static InputDeviceSlot GetInputDeviceSlot(InputDeviceType type)
        {
            return new InputDeviceSlot() { Pointer = Y5Lib_ActionInputDeviceManager_Get_Slot(type) }; 
        }
    }
}
