using AutoGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;


namespace Viewer
{
    public partial class TableForm : Form
    {
        public TableForm(DbSet set)
        {

            InitializeComponent();
            viewProcessor = new DataGridProcessor(dataGridView1);
            var typeModel = set.GetType().GetGenericArguments()[0];
            var valueName =typeModel.GetTitle();
            this.Text = "Таблица " + valueName;

            viewProcessor.ShowData((IEnumerable<object>)set, typeModel);
        }

        private DataGridProcessor viewProcessor;

        private void TableForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
