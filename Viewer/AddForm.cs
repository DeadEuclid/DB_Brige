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
using DB_Brige;

namespace Viewer
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            Init(typeof(Ticket));
        }

        public void Init(Type viewType)
        {
            var fields = viewType.GetProperties();
            var a = fields.Select(f => (info: (f), ((TitleAttribute)f.GetCustomAttributes(typeof(TitleAttribute), false).FirstOrDefault())?.Name)).Where(x => x.Name != null);

            foreach (var item in a) TextBoxes.Add(item.Name, (item.info, new TextBox()));

            foreach (var tb in TextBoxes)
            {
                this.flowLayoutPanel1.Controls.Add(new Label() { Text = tb.Key, Margin = new Padding(0, 10, 0, 0) });
                this.flowLayoutPanel1.Controls.Add(tb.Value.text);
            }

        }

        public Dictionary<string, (PropertyInfo info, TextBox text)> TextBoxes { get; set; } =
            new Dictionary<string, (PropertyInfo info, TextBox text)>();

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        public void Add(Type type)
        {
            var data = Activator.CreateInstance(type);

            foreach (var item in TextBoxes)
            {
                var type_name = item.Value.info.PropertyType.Name;
                if (type_name == "Int32")
                {
                    int.TryParse(item.Value.text.Text, out var r);
                    item.Value.info.SetValue(data, r);
                }

                if (type_name == "String")
                {
                    item.Value.info.SetValue(data, item.Value.text.Text);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add(typeof(Ticket));
        }
    }
}
