using System;

namespace Y5Lib
{
    public class DriveVehicleBase : UnmanagedObject
    {
        public Human Driver
        {
            get
            {
                if (Pointer == IntPtr.Zero)
                    return new Human();

                unsafe
                {
                    PXDLinkedListNode* node = (PXDLinkedListNode*)(Pointer + 0x180);
                    return new Human() { Pointer = node->Value };
                }
            }
        }

       
        public Human GetPassenger(int passengerIndex)
        {
            if (passengerIndex > 1)
                return new Human();

            if (Pointer == IntPtr.Zero)
                return new Human();

            unsafe
            {
                PXDLinkedListNode* node = (PXDLinkedListNode*)(Pointer + 0x1A0);
                node += passengerIndex;

                return new Human() { Pointer = node->Value };
            }
        }

        public void SetPosition(Vector4 pos)
        {
            if (Pointer == IntPtr.Zero)
                return;

            unsafe
            {
                *((Vector4*)(Pointer + 0x2A0)) = pos;
                *((Vector4*)(Pointer + 0x200)) = pos;
                *((Vector4*)(Pointer + 0x210)) = pos;
                *((Vector4*)(Pointer + 0x1F0)) = pos;
            }
        }


        public Vector3 GetPosition()
        {
            if (Pointer == IntPtr.Zero)
                return new Vector3();

            unsafe
            {
                return *((Vector3*)(Pointer + 0x1F0));
            }
        }

        public float GetSpeed()
        {
            if (Pointer == IntPtr.Zero)
                return 0;

            unsafe
            {
                return *((float*)(Pointer + 0x264));
            }
        }

        public void SetSpeed(float speed)
        {
            unsafe
            {
                *((float*)(Pointer + 0x264)) = speed;
            }
        }

        public int GetRotY()
        {
            if (Pointer == IntPtr.Zero)
                return 0;

            unsafe
            {
                return *((int*)(Pointer + 0x250));
            }
        }

        public void SetRotY(int rotY)
        {
            unsafe
            {
                *((int*)(Pointer + 0x250)) = rotY;
            }
        }
    }
}
