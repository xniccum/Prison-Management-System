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
                    setup_shift_update();
                    break;
                case "Delete Shift":
                    setup_shift_delete();
                    break;
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

        }
        public void setup_shift_delete()
        {

            
        }

        private void shift_add()
        {
            string[] argList = new String[2];
            argList[0] = shift_IU_textBox2.Text;
            argList[1] = shift_IU_textBox3.Text;
            if (!this.parentForm.dbHandler.runParamSproc_Boolean("dbo.shift_add", argList))
            {
                MessageBox.Show("Syntax Error, Please try again");
            }
            else
            {
                MessageBox.Show("Add Successfull");
            }
        }

        public void shift_update(){

            string[] argList = new String[3];
            argList[0] = shift_IU_textBox1.Text;
            argList[1] = shift_IU_textBox2.Text;
            argList[2] = shift_IU_textBox3.Text;
            if (!this.parentForm.dbHandler.runParamSproc_Boolean("dbo.shift_update", argList))
            {
                MessageBox.Show("Syntax Error, Please try again");
            }
            else
            {
                MessageBox.Show("Update Succesfull");
            }
        }


        private void shift_delete()
        {
            string[] argList = new String[1];
            argList[0] = shift_Delete_TextBox1.Text;
            if (!this.parentForm.dbHandler.runParamSproc_Boolean("dbo.shift_delete", argList))
            {
                MessageBox.Show("Syntax Error, Please try again");
            } 
            else
            {
                MessageBox.Show("Delete Successfull");
            }
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void schedulesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void shift_delete_button1_Click(object sender, EventArgs e)
        {
            shift_delete();
        }

        private void jobSchedulesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = shiftComboBox.SelectedItem.ToString();
            switch (selected)
            {
                case "Add Job Schedule":
                    shift_add();
                    break;
                case "Delete Job Schedule":
                    shift_update();
                    break;
            }
        }
        public void jws_add()
        {

        }
        public void jws_update()
        {

        }


    }
}
