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
    public partial class AdminForm : Form
    {
        string ordb = "Data Source = orcl; User Id = scott; Password = tiger;";
        OracleConnection conn;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into HotelInfo values (:HotelID, :HotelName, :HotelPhoneNumber,:HotelLocation, :AvailableNumberOfRooms)";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("HotelID", comboBox2.Text);
            cmd.Parameters.Add("HotelName", textBox2.Text);
            cmd.Parameters.Add("HotelPhoneNumber", textBox3.Text);
            cmd.Parameters.Add("HotelLocation", textBox4.Text);
            cmd.Parameters.Add("AvailableNumberOfRooms", textBox5.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                comboBox2.Items.Add(comboBox2.Text);
                MessageBox.Show("New Hotel is added");
            }

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select HotelID from HotelInfo";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select HotelID, HotelName, HotelLocation, HotelPhoneNumber, AvailableNumberOfRooms from HotelInfo where HotelID=: id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", comboBox2.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                textBox4.Text = dr[3].ToString();
                textBox5.Text = dr[4].ToString();


            }
            dr.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
