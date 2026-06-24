using System.Runtime.InteropServices;

namespace Y5Lib
{
    [StructLayout(LayoutKind.Sequential, Size = 192)]
    public struct EnemyDisposeInfo
    {
        public DisposeInfo Dispose;
        public int FighterIndex;
    }
}
