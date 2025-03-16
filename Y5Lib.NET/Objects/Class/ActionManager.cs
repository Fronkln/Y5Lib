using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public static class ActionManager
    {

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONMANAGER_GETTER_UNPAUSED_TIME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint OELib_ActionManager_Getter_UnpausedTime();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONMANAGER_GETTER_FULL_TIME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint OELib_ActionManager_Getter_FullTime();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONMANAGER_GETTER_DELTA_TIME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern float OELib_ActionManager_Getter_DeltaTime();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONMANAGER_GETTER_FIXED_DELTA_TIME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern float OELib_ActionManager_Getter_FixedDeltaTime();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONMANAGER_GETTER_IS_LOADED", CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.U1)]
        internal static extern bool OELib_ActionManager_Getter_IsLoaded();

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONMANAGER_GETTER_IS_PAUSED", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool IsPaused();



        /// <summary>
        /// Time that has passed without taking paused time into account.
        /// </summary>
        public static uint UnpausedTime { get { return OELib_ActionManager_Getter_UnpausedTime(); } }
        /// <summary>
        /// (Number of ticks)Time that has passed including everything like pausing.
        /// </summary>
        public static uint TimeTicks { get { return  OELib_ActionManager_Getter_FullTime(); } }
        /// <summary>
        /// (Seconds)Time that has passed including everything like pausing.
        /// </summary>
        public static float Time { get { return OELib_ActionManager_Getter_FullTime() / 60f; } }

        /// <summary>
        /// (Seconds)Time that has passed since last frame, affected by game speed.
        /// </summary>
        public static float DeltaTime { get { return OELib_ActionManager_Getter_DeltaTime(); } }


        /// <summary>
        /// (Seconds)Time that has passed since last frame, not affected by game speed.
        /// </summary>
        public static float UnscaledDeltaTime { get { return OELib_ActionManager_Getter_FixedDeltaTime(); } }

        public static bool IsLoaded()
        {
            return OELib_ActionManager_Getter_IsLoaded();
        }
    }
}
