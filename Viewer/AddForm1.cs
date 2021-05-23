using AutoGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Viewer.ControlsInput;


namespace Viewer
{
    public partial class AddForm1 : Form, IControlInput
    {
        public AddForm1(Type type)
        {
            Width = 420;
            Controls.Add(new HeadAddFormControl());
            Dictionary<PropertyInfo, UserControl> dic = GetControls(type);
            foreach (var item in dic)
            {
                UserControl control = item.Value;
                Controls.Add(control);
            }
            Init();
        }
        StationContext Context = new StationContext();
        public Dictionary<PropertyInfo, UserControl> GetControls(Type type)
        {
            PropertyInfo property;
            string getPropetyTitle(string nameProperty)
            {
                property = type.GetProperty(nameProperty);
                var title = (AddableBDTitle)property.GetCustomAttributes(false).Where(a => a.GetType() == typeof(AddableBDTitle)).First();
                return title.Name;
            }
            var props = type.GetProperties();
            var dic = new Dictionary<PropertyInfo, UserControl>();
            string label;
            switch (type.Name)
            {
                case "Person":
                    label = getPropetyTitle("FirstName");
                    dic.Add(property, new TextInputControl(label));
                    label = getPropetyTitle("LastName");
                    dic.Add(property, new TextInputControl(getPropetyTitle(label)));
                    label = getPropetyTitle("MiddleName");
                    dic.Add(property, new TextInputControl(getPropetyTitle(label)));
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

        //public void Show()
        //{
        //    var instance = Activator.CreateInstance<T>();
        //    Type type = typeof(T);
        //    var properties = type.GetPropertiesWithAttribute<Title>();

        //    foreach (var prop in properties)
        //    {
        //        var control = new TextInputControl(prop.Value.Name);

        //        control.Value.Enter += (sender, args) => prop.Key.SetValue(instance, ((TextBox)sender).Text);
        //        Controls.Add(control);
        //    }

        //    Init();
        //}

        public void Show(object instance)
        {
            throw new NotImplementedException();
        }

        public void Show(object instance, PropertyInfo propertyInfo)
        {
            throw new NotImplementedException();
        }
    }
}
