using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Brige;

namespace Viewer
{
    public partial class DataViewer : UserControl
    {
        public DataViewer()
        {
            InitializeComponent();
        }


        private void Init(Type viewType)
        {
            this.Data.Rows.Clear();
            this.Data.Columns.Clear();
            var fields = viewType.GetProperties();
            this.Pairs = fields.Select(f => ((Func<object, object>)(f.GetValue), ((TitleAttribute)f.GetCustomAttributes(typeof(TitleAttribute), false).FirstOrDefault())?.Name)).Where(x => x.Name != null);
           
            foreach (var name in Pairs.Select(x => x.Name))
                this.Data.Columns.Add(name.ToLower(), name);
        }


        public void ShowData(IEnumerable<object> items, Type viewType)
        {
            Init(viewType);

            foreach (var item in items)
            {
                var index = Data.Rows.Count - 1;
                Data.Rows.Add();
                int col = 0;

                foreach (var pair in Pairs)
                {
                    var val = pair.GetFunc(item);
                    if (val != null)
                        Data[col, index].Value = val.ToString();
                    col++;
                }
            }
        }

        public IEnumerable<(Func<object, object> GetFunc, string Name)> Pairs { get; set; }
    }
}
