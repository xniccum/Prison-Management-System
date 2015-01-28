﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        string connetionString = null;
        private void button1_Click(object sender, EventArgs e)
        {
           SqlConnection myConn = new SqlConnection(); 
           {
            
            //System.Data.SqlClient.SqlConnection cnn ;
            connetionString = "Data Source=titan.csse.rose-hulman.edu;Initial Catalog=PMS; User ID=" + textBox1.Text + "; password=" + textBox2.Text + ";";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show ("Authentification Accepted");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Authentification Failed");
            }
            }
        }
       
        private void update_data(string s)
        {
            try
            {
                
                    SqlDataAdapter adapter = new SqlDataAdapter(s, cnn);
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string s = "select * from Prisoner";
                update_data(s);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                string s = "select * from Guard";
                update_data(s);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging out");
            try
            {
                cnn.Close();
                connetionString = null;
                cnn = null;
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();    
                
            }
            catch (Exception ex) { }
        }
        
    }
}
