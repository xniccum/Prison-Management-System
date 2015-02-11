using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMSTest
{
    public partial class ScheduleEditor : Form
    {
        public ScheduleEditor()
        {
            InitializeComponent();
            fillSchedulesComboBox();
            fillJobSchedulesComboBox();
        }

        private void ScheduleEditor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void fillSchedulesComboBox()
        {
            schedulesComboBox.Items.AddRange(new Object[] {
               "Add Schedule",
               "Change Schedule",
               "Delete Schedule"
            });
        }
        private void fillJobSchedulesComboBox()
        {
            jobSchedulesComboBox.Items.AddRange(new Object[] {
                "Add Job Schedule",
                "Delete Job Schedule"
            });
        }

    }
}
