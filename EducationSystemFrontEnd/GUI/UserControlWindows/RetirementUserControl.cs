﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationSystemFrontEnd.GUI.UserControlWindows
{
    public partial class RetirementUserControl : UserControl
    {
        private static RetirementUserControl _instance;
        public RetirementUserControl()
        {
            InitializeComponent();
        }

        private void RetirementUserControl_Load(object sender, EventArgs e)
        {

        }
        public static RetirementUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RetirementUserControl();
                }
                return _instance;
            }
        }
    }
}
