using System;
using System.Runtime.InteropServices;

namespace Y5Lib
{
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public struct ScenarioFollowup
    {
        public uint ScenarioID;
        public int Result;

        public ScenarioFollowup(uint ScenarioID, int Result)
        {
            this.ScenarioID = ScenarioID;
            this.Result = Result;
        }

        public bool IsValid()
        {
            return Result >= 0 && ScenarioID != uint.MaxValue;
        }

        public static bool operator ==(ScenarioFollowup left, ScenarioFollowup right)
        {
            return left.ScenarioID == right.ScenarioID && left.Result == right.Result;
        }

        public static bool operator !=(ScenarioFollowup left, ScenarioFollowup right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            return obj is ScenarioFollowup other && this == other;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(ScenarioID, Result).GetHashCode();
        }
    }
}
