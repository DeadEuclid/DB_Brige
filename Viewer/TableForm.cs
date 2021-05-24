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
using Viewer.AddForms;

namespace Viewer
{
    public partial class TableForm : Form
    {
        public TableForm()//object не преобразуется в понятный тип так как может хранить что угодно нужен метод с генерик аргументом 
        {

            InitializeComponent();

            viewProcessor = new DataGridProcessor(dataGridView1);


        }
        public StationContext rep= new StationContext();
        private DataGridProcessor viewProcessor;
        private Type Type;

        public TableForm Init<T>(IEnumerable<T> set) where T:class
        {
            Type = typeof(T);
            var valueName = Type.GetTitle();
            this.Text = "Таблица " + valueName;
            viewProcessor.ShowData<T>(set);
            return this;
        }
        private void TableForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //var addForm = new AddForm(Type);
            //addForm.ShowDialog();
            var addForm = new PersonAddForm();
            addForm.ShowDialog();
            if (addForm.DialogResult==DialogResult.OK)
            {
                viewProcessor.AddRow(addForm.Instanse);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
