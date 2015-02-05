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
    public partial class Add_Data_Form : Form
    {
        string sprocName;
        string[] fieldTitles;
        Main_Form main;
        int numberOfArguments;
        public Add_Data_Form(string sprocName, Main_Form main)

        {
            this.sprocName = sprocName;
            this.numberOfArguments = main.dbHandler.parameterNames[sprocName].Length;
            this.main = main;
            InitializeComponent();
            label1.Text = sprocName;
            fillLabels();

        }

        private void fillLabels()
        {
            if (1 <= numberOfArguments)
                label2.Text = this.main.dbHandler.parameterNames[sprocName][0];
            if (2 <= numberOfArguments)
                label3.Text = this.main.dbHandler.parameterNames[sprocName][1];
            if (3 <= numberOfArguments)
                label4.Text = this.main.dbHandler.parameterNames[sprocName][2];
            if (4 <= numberOfArguments)
                label5.Text = this.main.dbHandler.parameterNames[sprocName][3];
            if (5 <= numberOfArguments)
                label6.Text = this.main.dbHandler.parameterNames[sprocName][4];
        }
        private string[] getInputList()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void AddSubmitButton_Click(object sender, EventArgs e)
        {
            main.runParamSproc("dbo.pms_getUser", new string[] { "warden" });
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
