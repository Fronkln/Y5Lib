using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    public class DanceBattleDancer : UnmanagedVirtualObject
    {
        public Human Human
        {
            get
            {
                if(Pointer == IntPtr.Zero)
                    return null;
                
                unsafe
                {
                    return new Human() { Pointer = *(IntPtr*)(Pointer + 0x50) };
                }
            }
        }

        public int Flags
        {
            get
            {
                if (Pointer == IntPtr.Zero)
                    return 0;

                unsafe
                {
                    return *(int*)(Pointer + 0x4C);
                }
            }
        }

        public bool IsRival()
        {
            return (Flags & 1) != 0;
        }

        public byte GetLine()
        {
            if (Pointer == IntPtr.Zero)
                return 0;

            unsafe
            {
                return *(byte*)(Pointer + 0x82);
            }
        }

        public void SetLine(byte line)
        {
            if (Pointer == IntPtr.Zero)
                return;

            unsafe
            {
                *(byte*)(Pointer + 0x82) = line;
            }
        }

        public int GetScore()
        {
            if (Pointer == IntPtr.Zero)
                return 0;

            unsafe
            {
                return *(int*)(Pointer + 0x10);
            }
        }

        public void SetScore(int score)
        {
            if (Pointer == IntPtr.Zero)
                return;
            
            unsafe
            {
                *(int*)(Pointer + 0x10) = score;
            }
        }

        public int GetHealth()
        {
            if (Pointer == IntPtr.Zero)
                return 0;
            
            unsafe
            {
                return *(int*)(Pointer + 0x60);
            }
        }

        public void SetHealth(int health)
        {
            if (Pointer == IntPtr.Zero)
                return;
            
            unsafe
            {
                *(int*)(Pointer + 0x60) = health;
            }
        }

        public float GetHeat()
        {
            if (Pointer == IntPtr.Zero)
                return 0;

            unsafe
            {
                return *(float*)(Pointer + 0x64);
            }
        }
        public void SetHeat(float heat)
        {
            if (Pointer == IntPtr.Zero)
                return;
            
            unsafe
            {
                *(float*)(Pointer + 0x64) = heat;
            }
        }

        public unsafe void ButtonInputResult(int result, short unk1, int unk2, LbdButton* button, LbdButton* nextButton)
        {
            if (Pointer == IntPtr.Zero)
                return;

            NativeFunctions.CDanceBattleDancerNativeFunctions.ButtonInputResult(Pointer, result, unk1, unk2, button, nextButton);
        }
    }
}
