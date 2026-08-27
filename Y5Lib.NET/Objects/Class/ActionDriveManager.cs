using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Y5Lib
{
    public static class ActionDriveManager
    {
        public static int VehicleCount
        {
            get
            {
                IntPtr action = ActionManager.GetAction(199);

                if (action == IntPtr.Zero)
                    return 0;

                return Marshal.ReadInt32(action + 0x208);
            }
        }

        public static DriveVehicleBase GetVehicle(int index)
        {
            if (index >= VehicleCount)
                return new DriveVehicleBase();

            IntPtr action = ActionManager.GetAction(199);

            if (action == IntPtr.Zero)
                return new DriveVehicleBase();

            return new DriveVehicleBase() { Pointer = Marshal.ReadIntPtr(action + 0x210 + (index * 8)) };
        }
    }
}
