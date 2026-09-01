using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Y5Lib
{

    public static class ActionDriveManager
    {
        public static DriveSequence Sequence
        {
            get
            {
                IntPtr action = ActionManager.GetAction(ActionID.TaxiRaceManager);

                if (action == IntPtr.Zero)
                    return new DriveSequence();

                return new DriveSequence() { Pointer = Marshal.ReadIntPtr(action + 0x1F8) };
            }
        }

        public static int Phase
        {
            get
            {
                IntPtr action = ActionManager.GetAction(ActionID.TaxiRaceManager);

                if (action == IntPtr.Zero)
                    return 0;

                return Marshal.ReadInt32(action + 0x1C8);
            }
        }

        public static DriveMissionType MissionType
        {
            get
            {
                IntPtr action = ActionManager.GetAction(ActionID.TaxiRaceManager);

                if (action == IntPtr.Zero)
                    return (DriveMissionType)(-1);

                return (DriveMissionType)Marshal.ReadInt32(action + 0x1D8);
            }
        }

        public static int VehicleCount
        {
            get
            {
                IntPtr action = ActionManager.GetAction(ActionID.TaxiRaceManager);

                if (action == IntPtr.Zero)
                    return 0;

                return Marshal.ReadInt32(action + 0x208);
            }
        }

        public static DriveVehicleBase GetVehicle(int index)
        {
            if (index >= VehicleCount)
                return new DriveVehicleBase();

            IntPtr action = ActionManager.GetAction(ActionID.TaxiRaceManager);

            if (action == IntPtr.Zero)
                return new DriveVehicleBase();

            return new DriveVehicleBase() { Pointer = Marshal.ReadIntPtr(action + 0x210 + (index * 8)) };
        }
    }
}
