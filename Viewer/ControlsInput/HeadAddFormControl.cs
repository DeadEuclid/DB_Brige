using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Viewer.AddForms;

namespace Viewer.ControlsInput
{
    public partial class HeadAddFormControl : UserControl{
        public HeadAddFormControl()
        {
            InitializeComponent();
            
        
        }
        public void Init()
        {

            //  addForm = (AddForm)this.FindForm();
              addForm = (PersonAddForm)this.FindForm();
        }
        //AddForm addForm;
        PersonAddForm addForm;
        private void canselButton_Click(object sender, EventArgs e)
        {
            addForm.DialogResult=DialogResult.Cancel;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addForm.DialogResult = DialogResult.OK;
        }
    }
}
