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
    public partial class AltercationEditor : Form
    {
        Main_Form parentForm;

        public AltercationEditor(Main_Form passedForm)
        {
            InitializeComponent();
            this.parentForm = passedForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] argList = new String[5];
            argList[0] = prisoner1_TB.Text;
            argList[1] = prisoner2_TB.Text;
            argList[2] = altercation_TDP.Value.ToString();
            argList[3] = description_TB.Text;
            try
            {
                if (!this.parentForm.dbHandler.runParamSproc_Boolean("dbo.altercation_update", argList))
                {
                    MessageBox.Show("Invalid Syntax");
                    return;
                }
            }
            catch (System.Data.SqlClient.SqlException E)
            {
                MessageBox.Show(E.Message);
                return;
            }
            MessageBox.Show("Success!");
        }
    }
}
