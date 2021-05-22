using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AutoGrid
{
    public class DataGridProcessor
    {
        public DataGridProcessor(DataGridView dataGrid)
        {
            DataGrid = dataGrid;
        }
        private DataGridView DataGrid;
        private void Init(Type viewType)
        {
            this.DataGrid.Rows.Clear();
            this.DataGrid.Columns.Clear();
            var fields = viewType.GetProperties();
            this.Pairs = fields.Select(f => ((Func<object, object>)(f.GetValue), ((Title)f.GetCustomAttributes(typeof(Title), false).FirstOrDefault())?.Name)).Where(x => x.Name != null);

            foreach (var name in Pairs.Select(x => x.Name))
                this.DataGrid.Columns.Add(name.ToLower(), name);
        }


        public void ShowData(IEnumerable<object> items, Type viewType)
        {
            Init(viewType);
            foreach (var item in items)
            {
                var index = DataGrid.Rows.Count - 1;
                DataGrid.Rows.Add();
                int col = 0;

                foreach (var pair in Pairs)
                {
                    var val = pair.GetFunc(item);
                    if (val != null)
                        DataGrid[col, index].Value = val.ToString();
                    col++;
                }
            }

        }


        public IEnumerable<(Func<object, object> GetFunc, string Name)> Pairs { get; set; }
    }

}
