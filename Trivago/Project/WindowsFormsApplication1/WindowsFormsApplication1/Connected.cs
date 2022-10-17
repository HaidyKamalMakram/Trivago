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
namespace WindowsFormsApplication1
{
    public partial class Connected : Form
    {
        string ordb = "Data Source = orcl; User Id = scott; Password = tiger;";
        OracleConnection conn;
        public Connected()
        {
            InitializeComponent();
        }

        private void Connected_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select DestName from DestinationData";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select h.HotelName from HotelInfo h , DestinationData d where h.HotelID = d.HotelID and h.HotelLocation =: DestName";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("DestName", comboBox1.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                //comboBox2.Items.Add(dr[0]);
                textBox3.Text = dr[0].ToString();
            }
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETROOMS";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("DestName", comboBox1.SelectedItem.ToString());
            cmd.Parameters.Add("name", textBox3.Text);
            cmd.Parameters.Add("idout", OracleDbType.Int64, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                comboBox3.Items.Add(dr[0]);
            }
            dr.Close();
        }
    }
}
