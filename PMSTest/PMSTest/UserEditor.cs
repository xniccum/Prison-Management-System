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
    public partial class UserEditor : Form
    {
        Main_Form parentForm;

        public UserEditor(Main_Form passedForm)
        {
            this.parentForm = passedForm;
            InitializeComponent();
            this.Size = new Size(800, 500);
        }

        private void user_iu_button_Click(object sender, EventArgs e)
        {
            string[] argList = new String[5];
            if (string.IsNullOrEmpty(fname_iu_textbox.Text))
            {
                MessageBox.Show("Please Fill in all entry boxes.");
                return;
            }
            else
            {
                argList[0] = fname_iu_textbox.Text;
            }
            if (string.IsNullOrEmpty(mname_iu_textbox.Text))
            {
                MessageBox.Show("Please Fill in all entry boxes.");
                return;
            }
            else
            {
                argList[1] = mname_iu_textbox.Text;
            }
            if (string.IsNullOrEmpty(lname_iu_textbox.Text))
            {
                MessageBox.Show("Please Fill in all entry boxes.");
                return;
            }
            else
            {
                argList[2] = lname_iu_textbox.Text;
            }
            if (string.IsNullOrEmpty(username_textbox.Text))
            {
                MessageBox.Show("Please Fill in all entry boxes.");
                return;
            }
            else
            {
                argList[3] = username_textbox.Text;
            }
            if (string.IsNullOrEmpty(password_textbox.Text))
            {
                MessageBox.Show("Please Fill in all entry boxes.");
                return;
            }
            else
            {
                argList[4] = password_textbox.Text;
            }
            try
            {
                if (!this.parentForm.dbHandler.runParamSproc_Boolean("dbo.pms_registerUser", argList))
                {
                    MessageBox.Show("Invalid Syntax");
                    return;
                }
                MessageBox.Show("Add Successful");
            }
            catch (System.Data.SqlClient.SqlException E)
            {
                MessageBox.Show(E.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string[] argList = new String[1];
            if (string.IsNullOrEmpty(prisoner_delete_TextBox1.Text))
            {
                return;
            }
            else
            {
                argList[0] = prisoner_delete_TextBox1.Text;
            }
            try
            {
                if (!this.parentForm.dbHandler.runParamSproc_Boolean("dbo.pms_deleteUser", argList))
                {
                    MessageBox.Show("Invalid Syntax");
                    return;
                }
                MessageBox.Show("Delete Successful");
            }
            catch (System.Data.SqlClient.SqlException E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] argList = new String[3];
            if (string.IsNullOrEmpty(user_AR_TB.Text))
            {
                argList[0] = null;
            }
            else
            {
                argList[0] = user_AR_TB.Text;
            }
            if (string.IsNullOrEmpty(prisonerID_AR_TB.Text))
            {
                argList[1] = null;
            }
            else
            {
                argList[1] = prisonerID_AR_TB.Text;
            }
            if (string.IsNullOrEmpty(relation_AR_TB.Text))
            {
                argList[2] = null;
            }
            else
            {
                argList[2] = relation_AR_TB.Text;
            }
            try
            {
                if (!this.parentForm.dbHandler.runParamSproc_Boolean("dbo.pms_addRelation", argList))
                {
                    MessageBox.Show("Invalid Syntax");
                    return;
                }
                MessageBox.Show("Add Successful");
            }
            catch (System.Data.SqlClient.SqlException E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] argList = new String[3];
            if (string.IsNullOrEmpty(user_U_TB.Text))
            {
                argList[0] = null;
            }
            else
            {
                argList[0] = user_U_TB.Text;
            }
            if (string.IsNullOrEmpty(prisoner_U_TB.Text))
            {
                argList[1] = null;
            }
            else
            {
                argList[1] = prisoner_U_TB.Text;
            }
            if (string.IsNullOrEmpty(relation_U_TB.Text))
            {
                argList[2] = null;
            }
            else
            {
                argList[2] = relation_U_TB.Text;
            }
            try
            {
                if (!this.parentForm.dbHandler.runParamSproc_Boolean("dbo.pms_updateRelation", argList))
                {
                    MessageBox.Show("Invalid Syntax");
                    return;
                }
                MessageBox.Show("Update Successful");
            }
            catch (System.Data.SqlClient.SqlException E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] argList = new String[2];
            if (string.IsNullOrEmpty(user_D_TB.Text))
            {
                argList[0] = null;
            }
            else
            {
                argList[0] = user_D_TB.Text;
            }
            if (string.IsNullOrEmpty(prisoner_D_TB.Text))
            {
                argList[1] = null;
            }
            else
            {
                argList[1] = prisoner_D_TB.Text;
            }
            try
            {
                if (!this.parentForm.dbHandler.runParamSproc_Boolean("dbo.pms_deleteRelation", argList))
                {
                    MessageBox.Show("Invalid Syntax");
                    return;
                }
                MessageBox.Show("Delete Successful");
            }
            catch (System.Data.SqlClient.SqlException E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] argList = new String[6];
            if (string.IsNullOrEmpty(fname_U_TB.Text))
            {
                argList[0] = null;
            }
            else
            {
                argList[0] = fname_U_TB.Text;
            }
            if (string.IsNullOrEmpty(mname_U_TB.Text))
            {
                argList[1] = null;
            }
            else
            {
                argList[1] = mname_U_TB.Text;
            }
            if (string.IsNullOrEmpty(lname_U_TB.Text))
            {
                argList[2] = null;
            }
            else
            {
                argList[2] = lname_U_TB.Text;
            }
            if (string.IsNullOrEmpty(username_U_TB.Text))
            {
                argList[3] = null;
            }
            else
            {
                argList[3] = username_U_TB.Text;
            }
            if (string.IsNullOrEmpty(password_U_TB.Text))
            {
                argList[4] = null;
            }
            else
            {
                argList[4] = password_U_TB.Text;
            }
            if (string.IsNullOrEmpty(permission_U_TB.Text))
            {
                argList[5] = null;
            }
            else
            {
                argList[5] = permission_U_TB.Text;
            }
            try
            {
                if (!this.parentForm.dbHandler.runParamSproc_Boolean("dbo.pms_updateUser", argList))
                {
                    MessageBox.Show("Invalid Syntax");
                    return;
                }
                MessageBox.Show("Update Successful");
            }
            catch (System.Data.SqlClient.SqlException E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
