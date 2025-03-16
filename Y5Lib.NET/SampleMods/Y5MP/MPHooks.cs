using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinHook.NET;

namespace Y5MP
{
    internal static class MPHooks
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        private delegate void HumanRequestAnim(IntPtr mot, int anim);

        private static HumanRequestAnim _humanRequestAnimDeleg;
        private static HumanRequestAnim _humanRequestAnimDeleg2;
        private static HumanRequestAnim _humanRequestAnimTrampoline;
        private static HumanRequestAnim _humanRequestAnimTrampoline2;


        public static void Init()
        {
            _humanRequestAnimDeleg = new HumanRequestAnim(HumanPlayAnimationHook);
            _humanRequestAnimDeleg2 = new HumanRequestAnim(HumanPlayAnimationHook2);

            MinHookHelper.createHook((IntPtr)0x14093E9F0, _humanRequestAnimDeleg, out _humanRequestAnimTrampoline);
            MinHookHelper.createHook((IntPtr)0x14094CE30, _humanRequestAnimDeleg2, out _humanRequestAnimTrampoline2);
            MinHookHelper.enableAllHook();
        }

        public static void HumanPlayAnimationHook(IntPtr motion, int anim)
        {
            if (MPManager.CharaMotions.ContainsKey(motion))
                return;

            _humanRequestAnimTrampoline(motion, anim);
        }

        public static void HumanPlayAnimationHook2(IntPtr motion, int anim)
        {
            if (MPManager.CharaMotions.ContainsKey(motion))
                return;

            _humanRequestAnimTrampoline2(motion, anim);
        }


    }
}
