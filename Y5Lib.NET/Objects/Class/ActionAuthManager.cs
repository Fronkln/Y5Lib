using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public static class ActionAuthManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONAUTHMANAGER_GETTER_FLAGS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_ActionAuthManager_Getter_Flags();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONAUTHMANAGER_SETTER_FLAGS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_ActionAuthManager_Setter_Flags(int flags);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONAUTHMANAGER_GETTER_FLAGS2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_ActionAuthManager_Getter_Flags2();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONAUTHMANAGER_SETTER_FLAGS2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_ActionAuthManager_Setter_Flags2(int flags);

        public static int Flags
        {
            get => Y5Lib_ActionAuthManager_Getter_Flags();
            set => Y5Lib_ActionAuthManager_Setter_Flags(value);
        }

        public static int Flags2
        {
            get => Y5Lib_ActionAuthManager_Getter_Flags2();
            set => Y5Lib_ActionAuthManager_Setter_Flags2(value);
        }
    }
}
