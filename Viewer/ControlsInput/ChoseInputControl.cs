﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viewer.ControlsInput
{
    public partial class ChoseInputControl : UserControl,IControlInput
    {
        public ChoseInputControl(string label)
        {
            InitializeComponent();
            label1.Text = label;
        }
    }
}
