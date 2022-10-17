using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace ODP2
{
    public partial class Rental_Form : Form
    {
        OracleConnection con;
        string ordb = "data source = orcl; user id =scott; password=tiger;";

        public Rental_Form()
        {
            InitializeComponent();
        }

        private void Rental_Form_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
            // rent date and due back date

            txt_DateRented.Text = DateTime.Now.ToString();
            txt_DateBack.Text = DateTime.Now.AddDays(3).ToString();

        }

        private void btn_showCopies_Click(object sender, EventArgs e)
        {
            //write code of show copies
            // Film example    The Smurfs
            
            
        }

        

       

        private void btn_rent_Click(object sender, EventArgs e)
        {
            // Get Rent id code
            int maxID, newID;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "GetRentID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            try
            {
                maxID = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                newID = maxID + 1;
            }
            catch
            { newID = 1; }
            /////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            //write the rent code
            




            /////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            //Update status code
            OracleCommand c2 = new OracleCommand();
            c2.Connection = con;
            c2.CommandText = "update_status";
            c2.CommandType = CommandType.StoredProcedure;
            c2.Parameters.Add("id", cmb_copies.SelectedItem.ToString());
            c2.ExecuteNonQuery();
            MessageBox.Show("Film status updated succefully");

            
        }
    }
}
