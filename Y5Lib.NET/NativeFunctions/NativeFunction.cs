namespace Y5Lib.NativeFunctions
{
    internal static class NativeFunction
    {
        public static void Init()
        {
            EntityNativeFunctions.Init();
            MemoryNativeFunctions.Init();
            CActionDriveUIManagerNativeFunctions.Init();
            CActEntityManagerNativeFunctions.Init();
            CActionCameraManagerNativeFunctions.Init();
            CDriveSequenceNativeFunctions.Init();
        }
    }
}
