using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGrid
{
    class TitleAtrtibute : Attribute
    {
        public TitleAtrtibute(string name)
        {
            Name = name;
        }
        public string Name { get; }
    }
}
