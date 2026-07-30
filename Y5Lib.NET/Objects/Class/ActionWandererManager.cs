using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public unsafe static class ActionWandererManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONWANDERERMANAGER_CREATE_WANDERER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr OELib_ActionWandererManager_CreateWanderer(MsgEntityEntry* wandererEntry);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONWANDERERMANAGER_DESTROY_WANDERER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern bool OELib_ActionWandererManager_DestroyWanderer(IntPtr wanderer);


        public static Wanderer SpawnWanderer(MsgEntityEntry* wandererEntry)
        {
            IntPtr result = OELib_ActionWandererManager_CreateWanderer(wandererEntry);

            return new Wanderer() { Pointer = result };
        }

        public static bool DestroyWanderer(Wanderer wanderer)
        {
            return OELib_ActionWandererManager_DestroyWanderer(wanderer.Pointer);   
        }
    }
}
