using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationSystemFrontEnd
{
    public partial class EducationSystem : Form
    {
        public EducationSystem()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TeacherPanel_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Teacher");
        }

        private void Appointment_Panel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "ASppointment");
        }

        private void Retirement_Panel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Retirement");
        }

        private void Transfer_Panel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Transfer");
        }

    }
}
