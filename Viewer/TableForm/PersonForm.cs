using AutoGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viewer.TableForm
{
    public partial class PersonForm : Form
    {

        public PersonForm()
        {
            InitializeComponent();
            dataViewer = new DataViewer();
            panel1.Controls.Add(dataViewer);
            dataViewer.ShowData(new List<Person>(), typeof(Person));
        }
        private DataViewer dataViewer;
    }
}
