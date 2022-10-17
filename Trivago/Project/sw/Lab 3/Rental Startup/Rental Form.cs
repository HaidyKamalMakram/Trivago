using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//to deal  with oracle
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
            //get today's date 
            txt_DateRented.Text = DateTime.Now.ToString();
            txt_DateBack.Text = DateTime.Now.AddDays(3).ToString();

        }

        private void btn_showCopies_Click(object sender, EventArgs e)
        {
            //write code of show copies
            // Film example    The Smurfs
           OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "getcopy";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("title", txt_title.Text);
            cmd.Parameters.Add("id", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read()){
                cmb_copies.Items.Add(dr[0]);
            }

            dr.Close();
        }

        private void txt_title_TextChanged(object sender, EventArgs e)
        {


        }

        

       

   
    }
}
