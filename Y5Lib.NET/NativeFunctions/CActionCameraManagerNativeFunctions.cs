using System;
using Y5Lib.Unsafe;

namespace Y5Lib.NativeFunctions
{
    internal unsafe partial class CActionCameraManagerNativeFunctions
    {
        private const int ACTION_ID = 123;

        private static IntPtr m_camManager;


        private static delegate* unmanaged<IntPtr, int, int, void> m_setActiveCamera;

        internal static void Init()
        {
            m_camManager = ActionManager.GetAction(ACTION_ID);
            m_setActiveCamera = (delegate* unmanaged<IntPtr, int, int, void>)CPP.PatternSearch("48 89 5C 24 ? 48 89 6C 24 ? 48 89 74 24 ? 57 48 83 EC ? 41 8B E8 48 8B 81");
        }

        public static void SetActiveCamera(int cameraID, int transitionID = 0)
        {
            m_setActiveCamera(m_camManager, cameraID, transitionID);
        }
    }
}
