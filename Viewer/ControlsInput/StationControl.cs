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
    public partial class StationControl : UserControl,IControlInput
    {
        public StationControl(IEnumerable<Station> set)
        {            InitializeComponent();
            comboBox1.DataSource = set;
            comboBox1.DisplayMember = "Name";

            listBox1.DataSource = Values;
            listBox1.DisplayMember = "Name";

        }
        private Station value;
        public List<Station> Value => Values.ToList();
        private BindingList<Station> Values = new BindingList<Station>();
        private void StationControl_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            value = (Station)comboBox1.SelectedItem;
        }
        public object ConvertList(List<object> value)
        {
            return value.Select(item => Convert.ChangeType(item,typeof( Station))).ToList();
        }
        public void Show(object instance,PropertyInfo propertyInfo)
        {
            Values.ListChanged +=
               (sender, args) =>
               {
                   propertyInfo.SetValue((Station)instance, Value);
               };

        }


    }
}
