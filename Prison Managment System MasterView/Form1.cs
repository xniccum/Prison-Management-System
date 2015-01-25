using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prison_Managment_System_MasterView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_tb_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=titan.csse.rose-hulman.edu;Database=PMS;Uid="+
                login_bt.Text+";Pwd="+password_tb.Text+";";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery_tb.Text, connection);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable tb=new DataTable();
                sda.Fill(tb);
                datagridView.DataSource=new BindingSource(tb,null);
        }
    }
}
