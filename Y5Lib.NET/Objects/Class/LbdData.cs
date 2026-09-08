using System;

namespace Y5Lib
{
    public unsafe class LbdData : UnmanagedObject
    {
        public unsafe int GetButtonCount()
        {
            if (Pointer == IntPtr.Zero)
                return 0;

            return *(int*)(Pointer + 0x3C);
        }

        public int* GetButtonStates(int dancerIndex)
        {
            if (Pointer == IntPtr.Zero)
                return null;

            IntPtr data = *(IntPtr*)(Pointer + 0x48);

            return (int*)(data + GetButtonCount() * dancerIndex * 4);
        }

        public LbdButton* GetButtons(int dancerIndex)
        {
            if (Pointer == IntPtr.Zero)
                return null;

            IntPtr data = *(IntPtr*)(Pointer + 0x40);

            return (LbdButton*)(data + GetButtonCount() * dancerIndex * 12);
        }

        public LbdButton* GetButton(int dancerIndex, int buttonIndex)
        {
            if (Pointer == IntPtr.Zero)
                return null;

            return GetButtons(dancerIndex) + buttonIndex;
        } 

        public unsafe void SetButtonState(int dancerIndex, int buttonIndex, int state)
        {
            if (Pointer == IntPtr.Zero)
                return;

            int* buttonStates = GetButtonStates(dancerIndex);
            int* buttonStatePtr = buttonStates + buttonIndex;

            *buttonStatePtr = state;

            if ((state - 3) <= 1)
                *buttonStatePtr = state | (state << 16);
        }
    }
}
