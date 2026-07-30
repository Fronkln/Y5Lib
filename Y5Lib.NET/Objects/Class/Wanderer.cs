using System;
namespace Y5Lib
{
    public class Wanderer : Human
    {
        public bool IsEncounter()
        {
            int chip = aiChip;
            return chip == 7 || chip == 8 || chip == 9;
        }
    }
}
