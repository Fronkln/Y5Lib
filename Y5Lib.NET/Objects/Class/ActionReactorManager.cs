using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public static class ActionReactorManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONREACTORMANAGER_CREATEREACTOR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_ActionReactorManager_CreateReactor(IntPtr name, Vector4 position, Quaternion rotation);

        public static Entity CreateReactor(IntPtr name, Vector4 position, Quaternion rotation)
        {
            IntPtr result = Y5Lib_ActionReactorManager_CreateReactor(name, position, rotation);
            return new Entity() { Pointer = result };
        }
    }
}
