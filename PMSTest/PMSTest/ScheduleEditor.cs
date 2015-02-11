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
        Main_Form parentForm;
        public ScheduleEditor(Main_Form passedForm)
        {
            this.parentForm = passedForm;
            InitializeComponent();
            fillComboBoxes();
        }

        private void ScheduleEditor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void shiftComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillComboBoxes()
        {
            schedulesComboBox.Items.AddRange(new Object[] {
               "Add Schedule",
               "Change Schedule",
               "Delete Schedule"
            });
            jobSchedulesComboBox.Items.AddRange(new Object[] {
                "Add Job Schedule",
                "Delete Job Schedule"
            });

            shiftComboBox.Items.AddRange(new Object[] { "Add Shift", "Update Shift", "Delete Shift" });
            guardSchedulesComboBox.Items.AddRange(new Object[] { "Update Guard Schedule" });
        }
        private void fillJobSchedulesComboBox()
        {

        }

        private void schedulesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
