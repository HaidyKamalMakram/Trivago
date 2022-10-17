using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string ordb = 'data source = orcl; user = scott; password=tiger;';
        OracleConnection conn;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select HotelName from DestinationData D, HotelInfo H where D.DestName =:name and D.HotelID = H.HotelID"; ;            c.CommandType = CommandType.Text;
            c.CommandType = CommandType.Text;
            c.Parameters.Add("name", textBox2.Text);

            int x = c.ExecuteNonQuery();
            if(x != -1)
            {
                textBox2.Items.Add(textBox2.Text);
            }

            
        }
    }
}
