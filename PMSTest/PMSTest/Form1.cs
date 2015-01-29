using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PMSTest
{
    public partial class Form1 : Form
    {
        private string dummyUsername = "333Winter2014Prisoner";
        private string dummyPassword = "prisoner";
        public Form1()
        {
            InitializeComponent();

            startConnection();
        }
        SqlConnection dbConnection;
        string connetionString = null;
        private void button1_Click(object sender, EventArgs e)
        {     
            
        }

        private void startConnection()
        {
            SqlConnection myConn = new SqlConnection(); 

            connetionString = "Data Source=titan.csse.rose-hulman.edu;Initial Catalog=PMS; User ID=" + dummyUsername + "; password=" + dummyPassword + ";";
            dbConnection = new SqlConnection(connetionString);
            try
            {
                dbConnection.Open();
                MessageBox.Show("Auto-Login Accepted");
            }
            catch
            {
                MessageBox.Show("Auto-Login Failed");
            }

        }
       
        private void update_data(string s)
        {
            try
            {
                
                    SqlDataAdapter adapter = new SqlDataAdapter(s, dbConnection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, s);
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Refresh();
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Must be logged on to view data");
            }
        }

        private void run_sproc(string s)
        {
            DataTable table2 = new DataTable();
            SqlDataReader reader;
            using ( var command = new SqlCommand(s,dbConnection)
            { CommandType = System.Data.CommandType.StoredProcedure } ) {
                reader = command.ExecuteReader(); 
            }
            table2.Load(reader);
            dataGridView1.DataSource = table2;
            reader.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging out");
            try
            {
                dbConnection.Close();
                connetionString = null;
                dbConnection = null;
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();    
                
            }
            catch (Exception ex) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "dbo.pms_getAllPrisoners";
            run_sproc(s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = "dbo.pms_guards";
            run_sproc(s);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = "dbo.pms_getGuardSchedule";
            run_sproc(s);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
  
    }
}
