using System;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public static class ActionFighterManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONFIGHTERMANAGER_IS_FIGHTER_PRESENT", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        internal static extern bool Y5Lib_ActionFighterManager_IsFighterPresent(int index);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONFIGHTERMANAGER_DESTROY_FIGHTER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_ActionFighterManager_DestroyFighter(int index);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONFIGHTERMANAGER_GET_FIGHTER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_ActionFighterManager_GetFighter(int index);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONFIGHTERMANAGER_GET_PLAYER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_ActionFighterManager_GetPlayer();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONFIGHTERMANAGER_SET_PLAYER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_ActionFighterManager_SetPlayer(int idx);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONFIGHTERMANAGER_ADD_TO_DISPOSE_QUEUE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_ActionFighterManager_AddToDisposeQueue(ref DisposeInfo spawnInf);

        public static Fighter Player { get { return new Fighter() { Pointer = Y5Lib_ActionFighterManager_GetPlayer() }; } }

        public static Fighter GetPlayer()
        {
            return new Fighter() { Pointer = Y5Lib_ActionFighterManager_GetPlayer() };
        }

        public static void SetPlayer(int fighterIdx)
        {
            Y5Lib_ActionFighterManager_SetPlayer(fighterIdx);
        }


        public static bool IsFighterPresent(int index)
        {
            return Y5Lib_ActionFighterManager_IsFighterPresent(index);
        }

        public static void DestroyFighter(int index)
        {
           Y5Lib_ActionFighterManager_DestroyFighter(index);
        }

        public static Fighter GetFighter(int index)
        {
            return new Fighter() { Pointer = Y5Lib_ActionFighterManager_GetFighter(index) };
        }

        public static int SpawnCharacter(DisposeInfo spawnInformation)
        {
            return Y5Lib_ActionFighterManager_AddToDisposeQueue(ref spawnInformation);
        }

        public static async Task<int> SpawnCharacterAsync(DisposeInfo spawnInformation)
        {
            int idx = Y5Lib_ActionFighterManager_AddToDisposeQueue(ref spawnInformation);
            await Task.Delay(60);

            return idx;
        }
    }
}
