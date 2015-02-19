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
    public partial class CellEditor : Form
    {
        Main_Form parentForm;
        Panel currentPanel;

        public CellEditor()
        {
            InitializeComponent();
            currentPanel = movePrisonerPanel;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
            switch (selected)
            {
                case "Add Cell":
                    focusPanel(addCellPanel);
                    break;
                case "Change A Prisoner's Cell":
                    focusPanel(movePrisonerPanel);
                    break;

            }
        }
        private void hidePanes()
        {
            addCellPanel.Visible = false;
            movePrisonerPanel.Visible = false;

        }
        private void focusPanel(Panel desired)
        {
            hidePanes();
            desired.Visible = true;
            Point oldLocation = this.currentPanel.Location;
            this.currentPanel.Location = desired.Location;
            desired.Location = oldLocation;
            this.currentPanel = desired;
        }
        private void fillComboBox()
        {
            comboBox1.Items.AddRange(new Object[] {
                "Add Cell",
                "Change A Prisoner's Cell"
            });
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
