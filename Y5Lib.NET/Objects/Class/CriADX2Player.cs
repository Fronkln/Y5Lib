using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib
{
    public class CriADX2Player : UnmanagedObject
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CRIADX2PLAYER_RESUME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_CriADX2Player_Resume(IntPtr player);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CRIADX2PLAYER_PAUSE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_CriADX2Player_Pause(IntPtr player);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CRIADX2PLAYER_IS_PAUSED", CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.U1)]
        internal static extern bool Y5Lib_CriADX2Player_IsPaused(IntPtr player);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CRIADX2PLAYER_SET_START_TIME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_CriADX2Player_SetStartTime(IntPtr player, int startTime);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CRIADX2PLAYER_START", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_CriADX2Player_Start(IntPtr player);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CRIADX2PLAYER_START_STREAM", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_CriADX2Player_StartStream(IntPtr player, string stream);

        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_CRIADX2PLAYER_STOP_WITHOUT_RELEASE_TIME", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Y5Lib_CriADX2Player_StopWithoutReleaseTime(IntPtr player);

        public void Resume() => Y5Lib_CriADX2Player_Resume(Pointer);
        public void Pause() => Y5Lib_CriADX2Player_Pause(Pointer);
        public bool IsPaused() => Y5Lib_CriADX2Player_IsPaused(Pointer);

        public void SetStartTime(int time) => Y5Lib_CriADX2Player_SetStartTime(Pointer, time);

        public void Start() => Y5Lib_CriADX2Player_Start(Pointer);
        public void StartStream(string fileName) => Y5Lib_CriADX2Player_StartStream(Pointer, "data/strmen/" + fileName);
        public void StopWithoutReleaseTime() => Y5Lib_CriADX2Player_StopWithoutReleaseTime(Pointer);
    }
}
