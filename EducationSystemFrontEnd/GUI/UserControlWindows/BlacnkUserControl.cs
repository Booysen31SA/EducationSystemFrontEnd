using System;
using System.Windows.Forms;

namespace EducationSystemFrontEnd.GUI.UserControlWindows
{
    public partial class BlacnkUserControl : UserControl
    {
        private static BlacnkUserControl _instance;

        public BlacnkUserControl()
        {
            InitializeComponent();
        }

        private void BlacnkUserControl_Load(object sender, EventArgs e)
        {
        }

        public static BlacnkUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BlacnkUserControl();
                }
                return _instance;
            }
        }
    }
}