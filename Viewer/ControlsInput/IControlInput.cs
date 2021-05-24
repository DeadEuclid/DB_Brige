using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Viewer.ControlsInput
{
   public interface IControlInput
    {

         void Show(object instance, PropertyInfo propertyInfo);


    }
}
