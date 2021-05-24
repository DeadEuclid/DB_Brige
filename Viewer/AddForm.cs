using AutoGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Viewer.ControlsInput;


namespace Viewer
{
    public partial class AddForm : Form
    {
        public AddForm(Type type)
        {
            DialogResult = new DialogResult();
            this.Text = "Добавление " + type.GetTitle();
            Instanse = Activator.CreateInstance(type);
            Type = type;
            Width = 420;
            Controls.Add(new HeadAddFormControl());
            ((HeadAddFormControl)Controls[0]).Init();
            Dictionary<PropertyInfo, IControlInput> dic = GetControls(type);
            foreach (var propContrPair in dic)
            {
                IControlInput control = propContrPair.Value;
                PropertyInfo property = propContrPair.Key;
                control.Show(Instanse, propContrPair.Key);
                
                Controls.Add((UserControl)control);


            }
            Init();
        }
        StationContext Context = new StationContext();
        Type Type;
        public object Instanse;

        private DialogResult dialogResult;
        public new DialogResult DialogResult
        {
            get { return dialogResult; }
            set
            {
                dialogResult = value;
                if (dialogResult == DialogResult.OK)
                {
                    DbsetFabric(Type).Add(Instanse);
                    Context.SaveChanges();
             
                    Close();
                    return;
                }
                if (dialogResult == DialogResult.Cancel)
                {
                    Close();
                }
               
            }
        }
        public Dictionary<PropertyInfo, IControlInput> GetControls(Type type)
        {
            PropertyInfo property;
            string getPropetyTitle(string nameProperty)
            {
                property = Instanse.GetType().GetProperty(nameProperty);
                var title = (AddableBDTitle)property.GetCustomAttributes(false).Where(a => a.GetType() == typeof(AddableBDTitle)).First();
                return title.Name;
            }
            var props = type.GetProperties();
            var dic = new Dictionary<PropertyInfo, IControlInput>();
            string label;

            switch (type.Name)
            {
                case "Person":
                    label = getPropetyTitle("FirstName");
                    dic.Add(property, new TextInputControl(label));
                    label = getPropetyTitle("LastName");
                    dic.Add(property, new TextInputControl(label));
                    label = getPropetyTitle("MiddleName");
                    dic.Add(property, new TextInputControl(label));
                    break;
                case "Route":
                    label = getPropetyTitle("Stations");
                    dic.Add(property, new ColectionControl(label, Context.Stations.ToList()));
                    label = getPropetyTitle("Price");
                    dic.Add(property, new TextInputControl(label));
                    break;
                case "Station":
                    label = getPropetyTitle("Name");
                    dic.Add(property, new TextInputControl(label));
                    label = getPropetyTitle("Routes");
                    dic.Add(property, new ColectionControl(label, Context.Routes.ToList()));
                    break;
                case "TimeTable":
                    label = getPropetyTitle("DepartureTime");
                    dic.Add(property, new DateInputControl(label));
                    label = getPropetyTitle("WeekTable");
                    dic.Add(property, new TimeTableControl(label));
                    label = getPropetyTitle("Route");
                    dic.Add(property, new ChoseInputControl(label, Context.Routes.ToList()));
                    break;
                case "Train":
                    label = getPropetyTitle("Number");
                    dic.Add(property, new TextInputControl(label));
                    label = getPropetyTitle("Wagon");
                    dic.Add(property, new ChoseInputControl(label, Context.Wagons.ToList()));
                    break;
                case "Trip":
                    label = getPropetyTitle("Train");
                    dic.Add(property, new ChoseInputControl(label, Context.Trains.ToList()));
                    label = getPropetyTitle("TimeTable");
                    dic.Add(property, new ChoseInputControl(label, Context.TimeTables.ToList()));
                    label = getPropetyTitle("DepartureDate");
                    dic.Add(property, new DateInputControl(label));
                    break;
                case "Wagon":
                    label = getPropetyTitle("Number");
                    dic.Add(property, new TextInputControl(label));
                    label = getPropetyTitle("SeatsCount");
                    dic.Add(property, new TextInputControl(label));
                    label = getPropetyTitle("WagonClass");
                    dic.Add(property, new ComboInputControl(label, typeof(WagonClass)));
                    break;

                default:
                    throw new NotImplementedException("Данный тип не добовляется в базу данных");
                    break;
            }
            return dic;
        }



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

        public DbSet DbsetFabric(Type type)
        {

            if (type == typeof(Person))
                return Context.Persons;
            if (type == typeof(Route))
                return Context.Routes;
            if (type == typeof(Station))
                return Context.Stations;
            if (type == typeof(TimeTable))
                return Context.TimeTables;
            if (type == typeof(Train))
                return Context.Trains;
            if (type == typeof(Wagon))
                return Context.Wagons;
            else throw new Exception("Данный тип не записывается в базу");


        }
    }
}
