using System;
using System.Collections.Generic;
using System.Text;

namespace Y5Lib
{
    public class DriveSequence : UnmanagedVirtualObject
    {
        public DriveVehicleBase GetPlayerVehicle()
        {
            if (Pointer == IntPtr.Zero)
                return new DriveVehicleBase();

            unsafe
            {
               return new DriveVehicleBase() { Pointer = ((delegate* unmanaged<IntPtr, IntPtr>)GetVirtualFunctionAtIndex(7))(Pointer) };
            }
        }

        public DriveVehicleBase GetRivalVehicle()
        {
            if (Pointer == IntPtr.Zero)
                return new DriveVehicleBase();

            unsafe
            {
                return new DriveVehicleBase() { Pointer = ((delegate* unmanaged<IntPtr, IntPtr>)GetVirtualFunctionAtIndex(8))(Pointer) };
            }
        }
    }
}
