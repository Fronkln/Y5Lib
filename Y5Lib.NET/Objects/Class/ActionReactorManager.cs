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
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONREACTORMANAGER_FINDREACTORID", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_ActionReactorManager_FindReactorID(IntPtr name);

        private delegate void ReverseStringThing(IntPtr input, string toReverse);
        private static ReverseStringThing m_reverseStringFunc;

        static ActionReactorManager()
        {
           m_reverseStringFunc = Marshal.GetDelegateForFunctionPointer<ReverseStringThing>((IntPtr)0x140055BF0);
        }

        public static Entity CreateReactor(string name, Vector4 position, Quaternion rotation)
        {

            IntPtr input = Marshal.AllocHGlobal(32);
            m_reverseStringFunc(input, name);

            IntPtr result = Y5Lib_ActionReactorManager_CreateReactor(input, position, rotation);
            Marshal.FreeHGlobal(input);
            return new Entity() { Pointer = result };
        }

        public static Entity CreateReactor(IntPtr name, Vector4 position, Quaternion rotation)
        {
            IntPtr result = Y5Lib_ActionReactorManager_CreateReactor(name, position, rotation);
            return new Entity() { Pointer = result };
        }

        public static int FindReactorID(IntPtr name)
        {
            return Y5Lib_ActionReactorManager_FindReactorID(name);
        }
    }
}
