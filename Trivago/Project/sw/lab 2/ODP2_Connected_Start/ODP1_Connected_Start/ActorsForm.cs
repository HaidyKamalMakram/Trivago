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

namespace ODP1_Connected_Start
{
    public partial class ActorsForm : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public ActorsForm()
        {
            InitializeComponent();
        }

        private void ActorsForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ActorID from Actors";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_ID.Items.Add(dr[0]);
            }
            dr.Close();


        }

        private void cmb_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select actorname, gender from Actors where ActorID=: id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", cmb_ID.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_Name.Text = dr[0].ToString();
                txt_Gender.Text = dr[1].ToString();

            }
            dr.Close();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Actors values(:id, :name, :gender)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", cmb_ID.Text);
            cmd.Parameters.Add("name", txt_Name.Text);
            cmd.Parameters.Add("gender", txt_Gender.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                cmb_ID.Items.Add(cmb_ID.Text);
                MessageBox.Show("New Actor IS Added");

            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update Actors set ActorName =:name, Gender=:gender where ActorID =:id";
            cmd.CommandType = CommandType.Text;
           
            cmd.Parameters.Add("name", txt_Name.Text);
            cmd.Parameters.Add("gender", txt_Gender.Text);
            cmd.Parameters.Add( cmb_ID.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Actor Info IS Updated");

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from  Actors where ActorID =:id";
            cmd.CommandType = CommandType.Text;
            
            //cmd.Parameters.Add("name",txt_Name.Text);
           // cmd.Parameters.Add("gender", txt_Gender.Text);
            cmd.Parameters.Add("id", cmb_ID.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                cmb_ID.Items.RemoveAt(cmb_ID.SelectedIndex);
                txt_Name.Text = "";
                txt_Gender.Text = "";
                MessageBox.Show("Actor Info IS Deleted");
            
            }
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
