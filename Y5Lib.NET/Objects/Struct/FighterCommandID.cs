using System.Runtime.InteropServices;

namespace Y5Lib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct FighterCommandID
    {
        public ushort Set;
        public ushort Command;

        public FighterCommandID(ushort set, ushort command)
        {
            Set = set;
            Command = command;
        }

        public override string ToString()
        {
            return $"{Set}-{Command}";
        }
    }
}
