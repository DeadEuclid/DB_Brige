using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoGrid
{
    public class DataGridProcessor
    {
        public DataGridProcessor(DataGridView dataGrid, IEnumerable<object> items,Type type)
        {
            DataGridLocal = dataGrid;
            DataGridLocal.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            ShowData(items,type);

        }
        private DataGridView DataGridLocal;
        public BindingList<object> Rows;
        public void AddRow(object item)
        {
            Rows.Add(item);
        }
        public void RemoweRow(object item)
        {
            Rows.Remove(item);
        }
        public object SelectedItem => GetSelectedItem();
            private object GetSelectedItem()
        {
            if (DataGridLocal.SelectedRows.Count != 0)
                return DataGridLocal.SelectedRows[0].DataBoundItem;
            else return null;
                }
        private void ShowData(IEnumerable<object> items, Type type)
        {

            Rows = new BindingList<object>(items.ToList());
            DataGridLocal.DataSource = Rows;

                IEnumerable<KeyValuePair<PropertyInfo,Title>> itemProps = type.GetPropertiesWithAttribute<Title>();
            foreach (DataGridViewColumn column in DataGridLocal.Columns)
            {
                column.Visible = false;
                var colProp= column.DataPropertyName;

               bool contain= itemProps.Select(pair=>pair.Key.Name).Contains(colProp);

                column.Visible = contain;
            }
           
        }

    }
}
