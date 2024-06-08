using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
    namespace ADOForm
{
    public partial class Form1 : Form
    {
        private int SelectedRowIndex;//???

        public Form1()
        {
            InitializeComponent();
        }

       

        private void DAOpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

                string commandString = "select * from phone";

                OracleDataAdapter DBAdapter
                    = new OracleDataAdapter(commandString, connectionString);

                DataSet DS = new DataSet();
                DBAdapter.Fill(DS, "phone");
                DBGrid.DataSource = DS.Tables["phone"].DefaultView;  //****
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void CCBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

                OracleConnection myConnection
                    = new OracleConnection(connectionString);

                string commandString = "select * from Phone";
                OracleCommand myCommand = new OracleCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                OracleDataAdapter DBAdapter = new OracleDataAdapter();
                DBAdapter.SelectCommand = myCommand;

                DataSet DS = new DataSet();

                DBAdapter.Fill(DS, "Phone");
                DBGrid.DataSource = DS.Tables["Phone"].DefaultView;
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void DRBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

                OracleConnection myConnection = new OracleConnection(connectionString);

                string commandString = "select * from phone";
                OracleCommand myCommand = new OracleCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                // 연결을 엽니다.
                myConnection.Open();  //****

                OracleDataReader myReader;
                myReader = myCommand.ExecuteReader();

                string ResultMessage = "";
                while (myReader.Read())
                {
                    ResultMessage = myReader.GetString(1) + ", " + myReader.GetString(2);
                    MessageBox.Show(ResultMessage);
                }
                // DataReader를 닫습니다.
                myReader.Close();

                //한번 연 연결은 반드시 닫아줘야 합니다.
                myConnection.Close();

            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        
        }

        private void AppendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

                string commandString = "select * from Phone";

                OracleDataAdapter DBAdapter
                    = new OracleDataAdapter(commandString, connectionString);

                OracleCommandBuilder myCommandBuilder
                    = new OracleCommandBuilder(DBAdapter);

                DataSet DS = new DataSet();

                DBAdapter.Fill(DS, "Phone");

                DataTable phoneTable = DS.Tables["Phone"];
                DataRow newRow = phoneTable.NewRow();
                newRow["id"] =Convert.ToInt32(txtid.Text);
                newRow["PName"] = txtName.Text;
                newRow["Phone"] = txtPhone.Text;
                newRow["Email"] = txtMail.Text;

                phoneTable.Rows.Add(newRow);

                DBAdapter.Update(DS, "Phone");

                DBGrid.DataSource = DS.Tables["Phone"].DefaultView;
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

            string commandString = "select * from Phone";

            OracleDataAdapter DBAdapter
                = new OracleDataAdapter(commandString, connectionString);

            DataSet DS = new DataSet();
            DBAdapter.Fill(DS, "Phone");

            DataTable phoneTable = DS.Tables["Phone"];
          
            if (e.RowIndex < 0)
            {
                // DBGrid의 컬럼 헤더를 클릭하면 컬럼을 정렬하므로
                // 아무 메시지도 띄우지 않습니다.
                return;
            }
            else if (e.RowIndex > phoneTable.Rows.Count - 1)
            {
                MessageBox.Show("해당하는 데이터가 존재하지 않습니다.");
                return;
            }

            DataRow currRow = phoneTable.Rows[e.RowIndex];
            txtid.Text = currRow["id"].ToString();
            txtName.Text = currRow["PName"].ToString();
            txtPhone.Text = currRow["Phone"].ToString();
            txtMail.Text = currRow["EMail"].ToString();

            SelectedRowIndex = Convert.ToInt32(currRow["id"]);
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

                string commandString = "select * from Phone";

                OracleDataAdapter DBAdapter
                    = new OracleDataAdapter(commandString, connectionString);

                OracleCommandBuilder myCommandBuilder
                    = new OracleCommandBuilder(DBAdapter);

                DataSet DS = new DataSet("Phone");
                DBAdapter.Fill(DS, "Phone");


                DataTable phoneTable = DS.Tables["Phone"];
               DataColumn[] PrimaryKey = new DataColumn[1];
               PrimaryKey[0] = phoneTable.Columns["id"];
               phoneTable.PrimaryKey = PrimaryKey;

                DataRow currRow = phoneTable.Rows.Find(SelectedRowIndex);


                currRow.BeginEdit();
                currRow["id"] = txtid.Text;
                currRow["PName"] = txtName.Text;
                currRow["Phone"] = txtPhone.Text;
                currRow["EMail"] = txtMail.Text;
                currRow.EndEdit();

                DataSet UpdatedSet = DS.GetChanges(DataRowState.Modified);
                if (UpdatedSet.HasErrors)
                {
                    MessageBox.Show("변경된 데이터에 문제가 있습니다.");
                }
                else
                {
                    DBAdapter.Update(UpdatedSet, "Phone");
                    DS.AcceptChanges();
                }

                DBGrid.DataSource = DS.Tables["Phone"].DefaultView;

            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }	
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";

                string commandString = "select * from Phone";

                OracleDataAdapter DBAdapter
                    = new OracleDataAdapter(commandString, connectionString);

                OracleCommandBuilder myCommandBuilder
                    = new OracleCommandBuilder(DBAdapter);

                DataSet DS = new DataSet("Phone");
                DBAdapter.Fill(DS, "Phone");


                DataTable phoneTable = DS.Tables["Phone"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = phoneTable.Columns["id"];
                phoneTable.PrimaryKey = PrimaryKey;

                DataRow currRow = phoneTable.Rows.Find(SelectedRowIndex);
                currRow.Delete();

                DBAdapter.Update(DS.GetChanges(DataRowState.Deleted), "Phone");
                DBGrid.DataSource = DS.Tables["Phone"].DefaultView;
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

      
        private void DBGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
