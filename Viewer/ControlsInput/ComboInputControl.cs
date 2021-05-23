using AutoGrid;
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
    public partial class ComboInputControl : UserControl, IControlInput
    {
        public ComboInputControl(string label, Type enumView)
        {
            InitializeComponent();
            label1.Text = label;
            enumView.GetType();
            comboBox1.DataSource = 
Enum.GetValues(enumView.GetType())
    .Cast<Enum>()
    .Select(value => new enumItem((Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(Title)) as Title).Name,
        value)
    )
    .OrderBy(item => item.Name)
    .ToList();
            comboBox1.DisplayMember = "Name";


        }

        public void Show(object instance, PropertyInfo propertyInfo)
        {
            comboBox1.SelectedValueChanged += (sender, args) => propertyInfo.SetValue(instance, ((enumItem)comboBox1.SelectedItem).Value);
        }
        private class enumItem
        {
            public enumItem(string name, Enum value)
            {
                Name = name;
                Value = value;
            }
            public string Name { get; set; }
            public Enum Value { get; set; }

        }
    }
}
