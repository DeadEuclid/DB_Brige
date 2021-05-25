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
    public partial class TextInputControl : UserControl, IControlInput
    {
        public TextInputControl(string label)
        {
            InitializeComponent();
            label1.Text = label;
        }

        public void Show(object instance, PropertyInfo propertyInfo)
        {
            textBox1.Leave += (sender, args) =>
            {
                var parsed = int.TryParse(textBox1.Text, out var number);
                if (parsed)
                {
                    propertyInfo.SetValue(instance, number);
                }
                else 
                { propertyInfo.SetValue(instance, textBox1.Text); }

            };
        }

        private void Value_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
