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
using Viewer.ControlsInput;


namespace Viewer
{
    public partial class AddForm1 : Form
    {
        public AddForm1(Type type)
        {
            //Type type = typeof(Trip);
            //base.InitializeComponent();
            //this.Text = "Добавление " + type.GetTitle();
            //string[] titles = type.GetTitlesProperty();
            //TripAdd();
            Width = 420;
            Controls.Add(new HeadAddFormControl());
        }
        public List<IControlInput> GetControls(Type type)
        {

            switch (type.Name)
            {
                case "Person":
                    new List<IControlInput>()
                {
                    new TextInputControl();
                    

                    }
                case "Route":
                case "Station":
                case "TimeTable":
                case "Train":
                case "Trip":
                case "Wagon":

                default:
                    throw new NotImplementedException("Данный тип не добовляется в базу данных");
                    break;
            }

            void RouteAdd()
            {

                Controls.Add(new ComboWithControlControler("Станции"));
                Controls.Add(new TextInputControl("Базовая цена билета"));
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

            public void Show<T>()
            {
                var instance = Activator.CreateInstance<T>();
                Type type = typeof(T);
                var properties = type.GetPropertiesWithAttribute<Title>();

                foreach (var prop in properties)
                {
                    var control = new TextInputControl(prop.Value.Name);
                    control.Value.Enter += (sender, args) => prop.Key.SetValue(instance, ((TextBox)sender).Text);
                    Controls.Add(control);
                }

                Init();
            }

            void StationAdd()
            {
                Controls.Add(new ComboWithControlControler("Машруты станции"));
                Controls.Add(new TextInputControl("Название станции"));

            }
            void TimetableAdd()
            {
                Controls.Add(new TimeInputControl("Время отправления"));
                Controls.Add(new TextInputControl("Расписание"));
                Controls.Add(new ChoseInputControl("Маршрут"));

            }
            void TrainAdd()
            {
                Controls.Add(new ComboWithControlControler("Вагоны"));
                Controls.Add(new TextInputControl("Номер поезда"));

            }
            void Cadd(UserControl control)
            {
                Controls.Add(control);
            }
            void TripAdd()
            {
                Cadd(new ChoseInputControl("Поезд"));
                Cadd(new ChoseInputControl("Расписание"));
                Cadd(new DateInputControl("Дата отправления"));
            }
            void WagonAdd()
            {
                Cadd(new TextInputControl("Ноомер"));
                Cadd(new TextInputControl("Количество мест"));
                Cadd(new ComboInputControl("Класс"));
            }
        }
    }
