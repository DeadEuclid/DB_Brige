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
    public partial class ColectionControl : UserControl, IControlInput
    {
        public ColectionControl(string label, IEnumerable<object> set)
        {
            InitializeComponent();
            label1.Text = label;
            type = set.GetType().GetGenericArguments()[0];

            comboBox1.DataSource = set;
            comboBox1.DisplayMember = "Name";

            listBox1.DataSource = Value;
            listBox1.DisplayMember = "Name";

        }
        private Type type;
        private object value;
        public List<object> Value = new List<object>();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            value = comboBox1.SelectedItem;
        }

        public void Show(object instance, PropertyInfo propertyInfo)
        {
            listBox1.DataBindings.CollectionChanged += (sender, args) => propertyInfo.SetValue(instance, Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Value.Contains(value))
            {
                Value.Add(value);
            }

        }
    }
}
