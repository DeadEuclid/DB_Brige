using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoGrid
{
    public partial class DataViewer: UserControl
    {
        public DataViewer()
        {
            InitializeComponent();
            GridProcessor = new DataGridProcessor(DataGrid);
        }

     DataGridProcessor GridProcessor;
        public void ShowData(IEnumerable<object> items, Type viewType)
        {
            GridProcessor.ShowData(items, viewType);
        }



    }
}
