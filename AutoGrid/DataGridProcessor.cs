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
            DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private DataGridView DataGrid;
        public object SelectedItem => DataGrid.SelectedRows[0].DataBoundItem;
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
                AddRow(item);
            }
        }
        public void AddRow(object item)
        {
            var index = DataGrid.Rows.Count;
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
        public void ShowData<T>(IEnumerable<T> items)where T:class
        {

            ShowData((List<T>)items,typeof( T));
        }

        public IEnumerable<(Func<object, object> GetFunc, string Name)> Pairs { get; set; }
    }

}
