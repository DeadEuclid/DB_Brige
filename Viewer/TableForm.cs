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
        public TableForm()
        {

            InitializeComponent();

            

        }
        public StationContext rep= new StationContext();
        private DataGridProcessor viewProcessor;
        private Type Type;

        public TableForm Init<T>(IEnumerable<T> set) where T:class
        {
            Type = typeof(T);
            var valueName = Type.GetTitle();
            this.Text = "Таблица " + valueName;
            viewProcessor = new DataGridProcessor(dataGridView1, set,Type);
            viewProcessor.ShowData(set,Type);
            return this;
        }
        private void TableForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm(Type);
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DbSet dbSet;
            StationContext context = new StationContext();
            if (Type.Name == typeof(Person).Name)
                dbSet= context.Persons;
            else
            if (Type.Name == typeof(Route).Name)
                dbSet= context.Routes;
            else
            if (Type.Name == typeof(Station).Name)
                dbSet = context.Stations;
            else
            if (Type.Name == typeof(TimeTable).Name)
                dbSet = context.TimeTables;
            else
            if (Type.Name == typeof(Train).Name)
                dbSet = context.Trains;
            else
            if (Type.Name == typeof(Wagon).Name)
                dbSet = context.Wagons;
            else
            throw new Exception("Данный тип не записывается в базу");
            if (viewProcessor.SelectedItem!=null)
            {
                object item = dbSet.Attach(viewProcessor.SelectedItem);
                dbSet.Remove(item);
                context.SaveChanges();
                viewProcessor.RemoweRow(item);
            }
            
        }




        
    }
}
