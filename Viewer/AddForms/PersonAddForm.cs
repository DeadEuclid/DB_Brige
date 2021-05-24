using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Viewer.ControlsInput;

namespace Viewer.AddForms
{
    public partial class PersonAddForm : Form
    {
        public PersonAddForm()
        {
            InitializeComponent();
            
            Text = "Добавление пассажира";
            Width = 420;
            Controls.Add(new HeadAddFormControl());
            ((HeadAddFormControl)Controls[0]).Init();  
            Controls.Add(new TextInputControl("Фамилия"));
            Controls.Add(new TextInputControl("Имя"));
            Controls.Add(new TextInputControl("Отчество"));
            for (int i = 1; i < Controls.Count; i++)
            {      
                ((IControlInput)Controls[i]).Show(Instanse, Instanse.GetType().GetProperty("LastName"));
                ((IControlInput)Controls[i]).Show(Instanse, Instanse.GetType().GetProperty("FirstName"));
                ((IControlInput)Controls[i]).Show(Instanse, Instanse.GetType().GetProperty("MiddleName"));
            }
            Init();
        }
        private DialogResult dialogResult;
        private StationContext context=new StationContext();
        public new DialogResult DialogResult
        {
            get { return dialogResult; }
            set
            {
                dialogResult = value;
                if (dialogResult == DialogResult.OK)
                {
                    context.Persons.Add(Instanse);
                    context.SaveChanges();

                    Close();
                    return;
                }
                if (dialogResult == DialogResult.Cancel)
                {
                    Close();
                }

            }
        }
       public Person Instanse=new Person();
        void Init()
        {
            int i = 0;

            foreach (Control control in Controls)
            {
                control.Margin = new Padding(100);
                control.Top = control.Size.Height * i;
                control.Anchor = (AnchorStyles)((byte)AnchorStyles.Left + (byte)AnchorStyles.Right + (byte)AnchorStyles.Top);
                i++;
            }
        }
    }
}
