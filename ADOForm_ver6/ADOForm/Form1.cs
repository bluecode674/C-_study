using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types; //***

namespace ADOForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchB1_Click(object sender, EventArgs e)
        {
            string ConStr = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            OracleConnection conn = new OracleConnection(ConStr);
            conn.Open();
            string strqry = "select * from phone where pname =:pname";
            OracleCommand comm = new OracleCommand(strqry, conn);
            comm.Parameters.Add("pname", OracleDbType.Varchar2, 20);
            comm.Parameters["pname"].Value = txtSearch.Text.Trim();
            label2.Text = "select * from phone where pname = '" + txtSearch.Text + "'";
            OracleDataReader sr = comm.ExecuteReader();
            while (sr.Read())
            {
                listBox1.Items.Add(sr["PName"].ToString());
            }
            sr.Close();
            conn.Close();

        }

        private void searchB2_Click(object sender, EventArgs e)
        {
            string ConStr = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";
            OracleConnection conn = new OracleConnection(ConStr);
            conn.Open();
            OracleDataAdapter DBAdapter = new OracleDataAdapter();
            DBAdapter.SelectCommand = new OracleCommand
            ("select * from phone where pname =:pname ", conn);
            DBAdapter.SelectCommand.Parameters.Add("pname", OracleDbType.Varchar2, 20);
            DBAdapter.SelectCommand.Parameters["pname"].Value = txtSearch.Text.Trim();
            DataSet DS = new DataSet();
            DBAdapter.Fill(DS, "Phone");
            DataTable phoneTable = DS.Tables["Phone"];
            DBGrid.DataSource = phoneTable;

        }
    }
}
