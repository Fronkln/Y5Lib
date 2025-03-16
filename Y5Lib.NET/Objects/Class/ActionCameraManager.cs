using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public static class ActionCameraManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CACTIONCAMERAMANAGER_GETTER_ACTIVE_CAMERA", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_ActionCameraManager_Getter_ActiveCamera();

        public static CameraBase Active
        {
            get
            {
                return new CameraBase() { Pointer = Y5Lib_ActionCameraManager_Getter_ActiveCamera() };
            }
        }
    }
}
