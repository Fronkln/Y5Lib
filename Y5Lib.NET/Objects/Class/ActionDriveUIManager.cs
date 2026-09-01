using System;
using System.Collections.Generic;
using System.Text;

namespace Y5Lib
{
    public static class ActionDriveUIManager
    {
        public static void SelectMission(int missionID, int unknown = 0)
        {
            NativeFunctions.CActionDriveUIManagerNativeFunctions.SelectMission(missionID, unknown);
        }
    }
}
