using System;
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
    public partial class UserUserControl : UserControl
    {
        private static UserUserControl _instance;
        public UserUserControl()
        {
            InitializeComponent();
        }

        private void UserUserControl_Load(object sender, EventArgs e)
        {

        }
        public static UserUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserUserControl();
                }
                return _instance;
            }
        }
    }
}
