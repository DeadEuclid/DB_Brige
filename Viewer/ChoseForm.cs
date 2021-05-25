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

namespace Viewer
{
    public partial class ChoseForm : Form
    {
        public ChoseForm(IEnumerable<object> set)
        {
            InitializeComponent();

            type = set.GetType();
            var typeModel = type.GetGenericArguments()[0];
            viewProcessor = new DataGridProcessor(dataGridView1,set,typeModel);
            var valueName = typeModel.GetTitle();
            this.Text = "Выбор " + valueName;

            viewProcessor.ShowData((IEnumerable<object>)set,typeModel);
        }
        Type type;
        public object Value { get; set; }
        //public ChoseForm()
        //{
        //    ExemType exem = ExemType.Student;
        //  // var test=  exem.GetTitlesValue();
        //   //var t=   Enum.Parse(typeof( ExemType), "None");
        //    InitializeComponent();
        //    viewProcessor = new DataGridProcessor(dataGridView1);
        //    var typeModel = typeof(Person);
        //    var valueName = typeModel.GetTitle();
        //    this.Text = "Выбор " + valueName;

        //    viewProcessor.ShowData(new List<Person>(), typeModel);
        //}
        private DataGridProcessor viewProcessor;

        private void canselButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
