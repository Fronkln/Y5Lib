using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public static class ActionEntityManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONENTITYMANAGER_GET_ENTITY_BY_UID", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_ActionEntityManager_GetEntityByUID(int uid);

        public static Entity GetEntityByUID(int uid)
        {
            return new Entity() { Pointer = Y5Lib_ActionEntityManager_GetEntityByUID(uid)};
        }

        public static T GetEntityByUID<T>(int uid) where T : Entity, new()
        {
            return new T() { Pointer = Y5Lib_ActionEntityManager_GetEntityByUID(uid) };
        }

        public static void RegisterEntity(Entity entity) => NativeFunctions.CActEntityManagerNativeFunctions.RegisterEntity(entity);
    }
}
