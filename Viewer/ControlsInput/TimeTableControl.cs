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

namespace Viewer.ControlsInput
{
    public partial class TimeTableControl : UserControl, IControlInput
    {
        public TimeTableControl(string label)
        {
            InitializeComponent();
            label1.Text = label;

        }
        private string val { get; set; }
        public string Value
        {
            get
            {
                valueSet();
                return val;
            }
            set
            {
                val = value;
            }
        }
        delegate void hendler(object sender, EventArgs e);
        private event hendler ValueChenged;


        private bool[] week = new bool[7];
        private void valueSet()
        {
            for (int i = 0; i < week.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        Value += "Пн. ";
                        break;
                    case 1:
                        Value += "Вт. ";
                        break;
                    case 2:
                        Value += "Ср. ";
                        break;
                    case 3:
                        Value += "Чт. ";
                        break;
                    case 4:
                        Value += "Пт. ";
                        break;
                    case 5:
                        Value += "Сб. ";
                        break;
                    case 6:
                        Value += "Вс.";
                        break;
                    default:
                        break;
                }
            }
        }
        private void CheckBoxSwith(bool mode)
        {
            foreach (var control in this.Controls)
            {
                if (control is CheckBox)
                    ((CheckBox)control).Enabled = mode;
            }
        }
        private void TimeTableControlcs_Load(object sender, EventArgs e)
        {

        }

        private void weekDays_CheckedChanged(object sender, EventArgs e)
        {
            if (weekDays.Checked)
                CheckBoxSwith(true);
            else
                CheckBoxSwith(false);
            ValueChenged.Invoke(sender, e);

        }

        private void oddDays_CheckedChanged(object sender, EventArgs e)
        {
            if (oddDays.Checked)
            {
                Value = "По чётным дням";
                }
            ValueChenged.Invoke(sender, e);

        }

        private void evenDays_CheckedChanged(object sender, EventArgs e)
        {
            if (oddDays.Checked)
            {
                Value = "По нечётным дням";
            }
            ValueChenged.Invoke(sender, e);

        }

        private void weekDayPocessor(CheckBox box,object sender, EventArgs e )
        {
            if (box.Checked)
                week[0] = true;
            else
                week[0] = false;
            ValueChenged.Invoke(sender, e);
        }
        private void Monday_CheckedChanged(object sender, EventArgs e)
        {
            weekDayPocessor(Monday, sender, e);
        }

        private void Tuesday_CheckedChanged(object sender, EventArgs e)
        { 
            weekDayPocessor(Thursday, sender, e);
        }

        private void Wednesday_CheckedChanged(object sender, EventArgs e)
        {
            weekDayPocessor(Wednesday, sender, e);
        }

        private void Thursday_CheckedChanged(object sender, EventArgs e)
        {
            weekDayPocessor(Thursday, sender, e);
        }

        private void Friday_CheckedChanged(object sender, EventArgs e)
        {
            weekDayPocessor(Friday, sender, e);
        }

        private void Saturday_CheckedChanged(object sender, EventArgs e)
        {
            weekDayPocessor(Saturday, sender, e);
        }

        private void Sunday_CheckedChanged(object sender, EventArgs e)
        {
            weekDayPocessor(Sunday, sender, e);
        }

        public void Show(object instance, PropertyInfo propertyInfo)
        {
            ValueChenged += (sender, args) => propertyInfo.SetValue(instance, Value);
        }
    }
}