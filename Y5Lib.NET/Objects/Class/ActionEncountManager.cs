using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public static class ActionEncountManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONENCOUNTMANAGER_ADD_ENEMY_DISPOSE", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AddEnemyDispose(ref EnemyDisposeInfo enemyDispose);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONENCOUNTMANAGER_SET_START_HACT", CallingConvention = CallingConvention.Cdecl)]
        public static extern void SetStartHAct(string hact);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONENCOUNTMANAGER_GET_ENEMY_COUNT", CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetEnemyCount();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONENCOUNTMANAGER_GET_ENEMY_DISPOSE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_ActionEncountManager_Get_Enemy_Dispose(int enemyIndex);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONENCOUNTMANAGER_GET_START_HACT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_ActionEncountManager_GetStartHAct();

        public static string GetStartHAct()
        {
            return Marshal.PtrToStringAnsi(Y5Lib_ActionEncountManager_GetStartHAct());
        }

        public static EnemyDisposeInfo GetEnemyDispose(int enemyIndex)
        {
            IntPtr disposePtr = Y5Lib_ActionEncountManager_Get_Enemy_Dispose(enemyIndex);

            if (disposePtr == IntPtr.Zero)
                return new EnemyDisposeInfo();
            else
                return Marshal.PtrToStructure<EnemyDisposeInfo>(disposePtr);
        }
    }
}
