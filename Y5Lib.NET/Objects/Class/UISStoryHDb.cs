using System;

namespace Y5Lib
{
    public class UISStoryHDb : Surfboard
    {
        public void SetDancerLine(int line, bool isNPC, int unk1 = 0)
        {
            if (Pointer == IntPtr.Zero)
                return;

            unsafe
            {
                NativeFunctions.CUISStoryHDbNativeFunctions.SetRow(Pointer, line, isNPC, unk1);
            }
        }
    }
}
