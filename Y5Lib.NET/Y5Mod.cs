using System;

namespace Y5Lib
{
    public class Y5Mod
    {
        public string ModPath { get; internal set; }

        public virtual void OnModInit() { }
    }
}
