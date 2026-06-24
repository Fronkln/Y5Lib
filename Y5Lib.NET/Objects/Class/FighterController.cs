using System;
using System.Runtime.InteropServices;


namespace Y5Lib
{
    public class FighterController : InputDeviceListener
    {
        [DllImport("Y5Lib.dll", EntryPoint = "OE_LIB_FIGHTERCONTROLLER_GETTER_FIGHTER", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Y5Lib_FighterController_Getter_Fighter(IntPtr fighterController);

        public Fighter Fighter
        {
            get
            {
                return new Fighter() { Pointer = Y5Lib_FighterController_Getter_Fighter(Pointer) };
            }
        }
    }
}
