using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    [StructLayout(LayoutKind.Sequential, Size = 72)]
    public struct VehiclePassengerData
    {
        public unsafe fixed byte ModelName[32]; //0x0000
        public unsafe fixed byte pad_0020[32]; //0x0020
        public long Flags;

        public VehiclePassengerData()
        {

        }

        public unsafe string GetModelName()
        {
            fixed (byte* p = ModelName)
            {
                return new string((sbyte*)p);
            }
        }

        public unsafe void SetModelName(string name)
        {
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(name);

            fixed (byte* dest = ModelName)
            {
                // Clear the existing string
                new Span<byte>(dest, 32).Clear();

                // Leave room for null terminator
                int length = Math.Min(bytes.Length, 31);

                bytes.AsSpan(0, length).CopyTo(new Span<byte>(dest, 32));
                dest[length] = 0;
            }
        }
    }
}
