using System;
using System.Runtime.InteropServices;
using Y5Lib.Unsafe;

namespace Y5Lib
{
    public static class Voicer
    {
        internal delegate IntPtr Y5Lib_Voicer_Load(ref int a1, int voicer, int VoicerCategory);
        internal delegate SoundCue Y5Lib_Voicer_GetSound(int voicer, int sound);
        internal static Y5Lib_Voicer_Load F_Voicer_Load;
        internal static Y5Lib_Voicer_GetSound F_Voicer_GetSound;

        static Voicer()
        {
            F_Voicer_Load = Marshal.GetDelegateForFunctionPointer<Y5Lib_Voicer_Load>(CPP.ReadCall(CPP.PatternSearch("E8 ? ? ? ? 90 48 8D 4F ? 48 8B D0 E8 ? ? ? ? 90 48 8D 4C 24")));
            F_Voicer_GetSound = Marshal.GetDelegateForFunctionPointer<Y5Lib_Voicer_GetSound>(CPP.PatternSearch("8B C2 41 B8 ? ? ? ? C1 F8 ? 66 41 3B C0 75 ? B8"));
        }

        public static bool Load(VoicerID voicer, VoicerCategory category)
        {
            int a1 = -1;
            F_Voicer_Load(ref a1, (int)voicer, (int)category);

            return a1 != -1;
        }

        public static SoundCue GetSound(VoicerID voicer, VoicerCategory voicerCategory, short index)
        {
            int sound = (int)voicerCategory << 16 | (int)index;
            return F_Voicer_GetSound((int)voicer, sound);
        }
    }
}
