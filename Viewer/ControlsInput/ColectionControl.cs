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

            listBox1.DataSource = Values;
            listBox1.DisplayMember = "Name";

        }
        private Type type;
        private object value;
        public List<object> Value => Values.ToList();
        private BindingList<object> Values = new BindingList<object>();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            value = comboBox1.SelectedItem;
        }
        public object ConvertList(List<object> value, Type type)
        {
            var containedType = type.GenericTypeArguments.First();
            return value.Select(item => Convert.ChangeType(item, containedType)).ToList();
        }
        public void Show(object instance, PropertyInfo propertyInfo)
        {

            Values.ListChanged +=
               (sender, args) =>
               {
                   var list = ConvertList(Value, propertyInfo.PropertyType);
                   propertyInfo.SetValue(instance, list);
               };
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!Values.Contains(value))
            {

                Values.Add(value);
                ////listBox1.DataSource=Value;
                //listBox1.Update();
                //listBox1.Refresh();

            }


        }
        public object GetValue()
        {
            return Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Values.Remove(listBox1.SelectedItem);
        }
    }
}
