using System;

namespace DB_Brige
{
    public class TitleAttribute : Attribute
    {
        public TitleAttribute(string name)
        {
            Name = name;
        }
        public string Name { get; }
    }
}