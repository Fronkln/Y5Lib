using System;

namespace Y5Lib
{
    [AttributeUsage(AttributeTargets.Assembly)]
    public class Y5ModAttribute : Attribute
    {
        public string ModName;
        public string Author;
        public Type ModType;

        public Y5ModAttribute(string modName, string author, Type modType)
        {
            ModName = modName;
            Author = author;
            ModType = modType;
        }
    }
}
