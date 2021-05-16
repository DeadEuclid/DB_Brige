﻿using System;

namespace Viewer
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