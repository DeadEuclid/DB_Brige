using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viewer.ControlsInput
{
    public partial class ChoseInputControl : UserControl,IControlInput
    {
        public ChoseInputControl(string label,IEnumerable<object> set)
        {
            InitializeComponent();
            label1.Text = label;
            Set = set;
            
            
        }
        IEnumerable<object> Set;
        public object Value { get; set; }
        public void Show(object instance, PropertyInfo propertyInfo)
        {

            button1.Click += (sender, args) => propertyInfo.SetValue(instance, Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChoseForm choseForm = new ChoseForm(Set);
            choseForm.ShowDialog();
            Value = choseForm.Value;

        }
    }
}
