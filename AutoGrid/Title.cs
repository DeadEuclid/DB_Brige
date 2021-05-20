using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGrid
{
   public class Title : Attribute
    {
        public Title(string name)
        {
            Name = name;
        }
        public string Name { get; }
    }
}
