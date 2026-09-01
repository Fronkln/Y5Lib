using System;

namespace Y5Lib
{
    public class DriveSequenceNormal : DriveSequence
    {
        public unsafe void DecideOutcome(int outcome)
        {
            if (Pointer == IntPtr.Zero)
                return;

            NativeFunctions.CDriveSequenceNativeFunctions.DecideOutcome(Pointer, outcome);
        }
    }
}
