using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            string selected = shiftComboBox.SelectedItem.ToString();
            switch (selected) {
                case "Add Shift":
                    setup_shift_add();
                    break;
                case "Update Shift":
                    shift_update();
                    break;
                case "Delete Shift":
                    setup_shift_delete();
                    break;
            }
        }

        private void shift_add()
        {
            string[] argList = new String[2];
            argList[0] = shift_IU_textBox2.Text;
            argList[1] = shift_IU_textBox3.Text;
            if (!this.parentForm.dbHandler.runParamSproc_Boolean("dbo.shift_add", argList))
            {
                MessageBox.Show("Did not work");
            }
        }
       private void setup_shift_add()
        {
            shift_IU_label1.Visible = false;
            shift_IU_textBox1.Visible = false;
        }

        private void setup_shift_update()
        {
            shift_IU_label1.Visible = true;
            shift_IU_textBox1.Visible = true;

            throw new NotImplementedException();
        }

        public void shift_update(){

            throw new NotImplementedException();
        }

        public void setup_shift_delete(){

            throw new NotImplementedException();
        }
        private void shift_delete()
        {
            throw new NotImplementedException();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void schedulesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = schedulesComboBox.SelectedItem.ToString();
            switch (selected)
            {
                case "Add Schedule":
                    setup_schedule_add();
                    break;
                case "Change Schedule":
                    setup_schedule_change();
                    break;
                case "Delete Schedule":
                    setup_schedule_delete();
                    break;
            }
        }
        private void Schedule_IUsubmitbutton_Click(object sender, EventArgs e)
        {
            string selected = schedulesComboBox.SelectedItem.ToString();
            switch (selected)
            {
                case "Add Schedule":
                    schedule_add();
                    break;
                case "Change Schedule":
                    schedule_update();
                    break;
            }
        }
        private void setup_schedule_change()
        {
            scheduleadd_label.Visible = false;
            ScheduleID_label.Visible = true;
            ScheduleID_input.Visible = true;
            scheduleupdate_label.Visible = true;
        }
        private void setup_schedule_add()
        {
            scheduleupdate_label.Visible = false;
            scheduleadd_label.Visible = true;
            ScheduleID_label.Visible = false;
            ScheduleID_input.Visible = false;
        }
        private void setup_schedule_delete()
        {

        }
        private void schedule_add()
        {
            string[] argList = new String[7];
            argList[0] = Sunshift_input.Text;
            argList[1] = Monshift_input.Text;
            argList[2] = Tuesshift_input.Text;
            argList[3] = Wedshift_input.Text;
            argList[4] = Thursshift_input.Text;
            argList[5] = Frishift_input.Text;
            argList[6] = Satshift_input.Text;
            if (!this.parentForm.dbHandler.runParamSproc_Boolean("dbo.schedule_insert", argList))
            {
                MessageBox.Show("Did not work");
            }
        }
        private void schedule_update() { 
            string[] argList = new String[8];
            argList[0] = ScheduleID_input.Text;
            if (string.IsNullOrEmpty(Sunshift_input.Text))
            {
                argList[1] = null;
            }
            else
            {
                argList[1] = Sunshift_input.Text;
            }
            if (string.IsNullOrEmpty(Monshift_input.Text))
            {
                argList[2] = null;
            }
            else
            {
                argList[2] = Monshift_input.Text;
            }
            if (string.IsNullOrEmpty(Tuesshift_input.Text))
            {
                argList[3] = null;
            }
            else
            {
                argList[3] = Tuesshift_input.Text;
            }
            if (string.IsNullOrEmpty(Wedshift_input.Text))
            {
                argList[4] = null;
            }else {
                argList[4] = Wedshift_input.Text;
            }
            if (string.IsNullOrEmpty(Thursshift_input.Text)){
                argList[5] = null;
            }else {
                argList[5] = Thursshift_input.Text;
            }
            if (string.IsNullOrEmpty(Frishift_input.Text))
            {
                argList[6] = null;
            }
            else
            {
                argList[6] = Frishift_input.Text;
            }
            if (string.IsNullOrEmpty(Satshift_input.Text))
            {
                argList[7] = null;
            }
            else
            {
                argList[7] = Satshift_input.Text;
            }
            if (!this.parentForm.dbHandler.runParamSproc_Boolean("dbo.schedule_update", argList))
            {
                MessageBox.Show("Did not work");
            }
        }
        

        private void shift_IU_button1_Click(object sender, EventArgs e)
        {
            string selected = shiftComboBox.SelectedItem.ToString();
            switch (selected)
            {
                case "Add Shift":
                    shift_add();
                    break;
                case "Update Shift":
                    shift_update();
                    break;
            }
        }


    }
}
