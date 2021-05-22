using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGrid
{
    public class InvintationTitle:Attribute,ITitle
    {
        public InvintationTitle(string name)
        {
            Name = name;
        }
        public string Name { get; }
    }
    public interface ITitle
    {

    }

}
