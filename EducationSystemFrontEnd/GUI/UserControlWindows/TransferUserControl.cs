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
    public partial class TransferUserControl : UserControl
    {
        private static TransferUserControl _instance;
        public TransferUserControl()
        {
            InitializeComponent();
        }

        private void TransferUserControl_Load(object sender, EventArgs e)
        {

        }
        public static TransferUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TransferUserControl();
                }
                return _instance;
            }
        }
    }
}
