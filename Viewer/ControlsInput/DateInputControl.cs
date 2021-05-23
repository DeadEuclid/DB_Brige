using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viewer.ControlsInput
{
    public partial class DateInputControl : UserControl, IControlInput
    {
        public DateInputControl(string label)
        {
            InitializeComponent();
            label1.Text = label;
        }

        public void Show(object instance, PropertyInfo propertyInfo)
        {
            dateTimePicker1.ValueChanged += (sender, args) => propertyInfo.SetValue(instance, dateTimePicker1.Value);
        }
    }
}
