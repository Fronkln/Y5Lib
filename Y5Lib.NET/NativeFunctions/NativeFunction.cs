using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y5Lib.NativeFunctions
{
    internal static class NativeFunction
    {
        public static void Init()
        {
            EntityNativeFunctions.Init();
            MemoryNativeFunctions.Init();
            CActEntityManagerNativeFunctions.Init();
            CActionCameraManagerNativeFunctions.Init();
        }
    }
}
