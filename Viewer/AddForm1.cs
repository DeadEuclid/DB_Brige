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
        public AddForm1(Type type1)
        {
            Type type = typeof(Trip);
            InitializeComponent();
            this.Text = "Добавление " + type.GetTitle();
            string[] titles = type.GetTitlesPropery();
            Controls.Add(new HeadAddFormControl());
            TripAdd();

            

            int i = 0;
            foreach (Control control in Controls)
            {
                control.Margin = new Padding(100);
                control.Top = control.Size.Height * i;
                control.Anchor = (AnchorStyles)((byte)AnchorStyles.Left + (byte)AnchorStyles.Right + (byte)AnchorStyles.Top);
                i++;
            }
        }

        void RouteAdd()
        {

            Controls.Add(new ComboWithControlControler("Станции"));
            Controls.Add(new TextInputControl("Базовая цена билета"));
        }
        void PersonAdd()
        {
            Type type = typeof(Person);
            string[] titles = type.GetTitlesPropery();
            Controls.Add(new TextInputControl(titles[0]));
            Controls.Add(new TextInputControl(titles[1]));
            Controls.Add(new TextInputControl(titles[2]));
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
            Cadd(new DateIputControl("Дата отправления"));
        }
        void WagonAdd()
        {
            Cadd(new TextInputControl("Ноомер"));
            Cadd(new TextInputControl("Количество мест"));
            Cadd(new ComboInputControl("Класс"));
        }
    }
}
