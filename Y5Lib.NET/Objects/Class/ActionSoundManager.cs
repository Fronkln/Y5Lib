using System;
using System.Runtime.InteropServices;
namespace Y5Lib
{
    public static class ActionSoundManager
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_ACTIONSOUNDMANAGER_PLAY_SOUND", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Y5Lib_ActionSoundManager_PlaySound(short cuesheet, short soundID, int unknown);

        public static int PlaySound(short cuesheet, short soundID, int unknown = 0)
        {
            return Y5Lib_ActionSoundManager_PlaySound(cuesheet, soundID, unknown);
        }
    }
}
