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
        SQLhandler dbHandler;

        public Form1()
        {
            InitializeComponent();
            dbHandler = new SQLhandler();
            if (dbHandler.isConnected())
            {
                MessageBox.Show("Connected to database");
            }
            else
            {
                MessageBox.Show("Unable to connect");
            }
        }
        //login button
        private void button1_Click(object sender, EventArgs e)
        {
            if(dbHandler.isConnected()){
                if(dbHandler.isUserLoggedIn()) {
                    MessageBox.Show("Already Logged In");
                } else {
                    if(dbHandler.verifyUsernamePassword(textBox1.Text,textBox2.Text))
                    {
                        if (dbHandler.checkUsernamePermissions(textBox1.Text) < 1)
                        {
                            MessageBox.Show("You do not have permission to use this software. \nPlease contact a warden or a guard.");
                            dbHandler.logOut();
                        } else 
                        {
                        MessageBox.Show("Login Accepted");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("Username Or Password Incorrect");
                    }
                }
            }
            else 
            {
                MessageBox.Show("Not connected to Database");
            }
            

        }
       
        //private void update_data(string s)
        //{
        //    try
        //    {
                
        //            SqlDataAdapter adapter = new SqlDataAdapter(s, cnn);
        //            DataSet ds = new DataSet();
        //            adapter.Fill(ds, s);
        //            dataGridView1.DataSource = ds.Tables[0];
        //            dataGridView1.Refresh();
                    
                
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Must be logged on to view data");
        //    }
        //}



        //Depricated. Will be removed. 
        private void run_sproc(string s)
        {
            //DataTable table2 = new DataTable();
            //SqlDataReader reader;
            //using ( var command = new SqlCommand(s,cnn)
            //{ 
            //    CommandType = System.Data.CommandType.StoredProcedure 
            //} ) 
            //{
            //    reader = command.ExecuteReader(); 
            //}
            //table2.Load(reader);
            //dataGridView1.DataSource = table2;
            //reader.Close();
        }

        //logout button
        private void button2_Click(object sender, EventArgs e)
        {
            if( this.dbHandler.logOut())
                MessageBox.Show("Logged Out");
            //try
            //{
            //    cnn.Close();
            //    connetionString = null;
            //    cnn = null;
            //    dataGridView1.DataSource = null;
            //    dataGridView1.Rows.Clear();
            //    dataGridView1.Refresh();    
                
            //}
            //catch (Exception ex) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "dbo.pms_getAllPrisoners";
            run_sproc(s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //"dbo.pms_guards";
            if(dbHandler.isUserLoggedIn())
                dataGridView1.DataSource = dbHandler.getGuardsDataTable();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s = "dbo.pms_getGuardSchedule";
            run_sproc(s);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        
    }
}
