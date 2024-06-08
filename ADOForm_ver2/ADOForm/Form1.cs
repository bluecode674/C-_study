//ver2

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
        private int SelectedRowIndex;      //수정하거나 삭제하기 위해 선택된 행의 인덱스를 저장한다.

        OracleDataAdapter DBAdapter;     // Data Provider인 DBAdapter 입니다.

        DataSet DS; // DataSet 객체입니다.

        OracleCommandBuilder myCommandBuilder;
        // 추가, 수정, 삭제시에 필요한 명령문을 자동으로 작성해주는 객체입니다.

        DataTable phoneTable;               // DataTable 객체입니다.

        private int SelectedKeyValue; // 수정, 삭제할 때 필요한 레코드의 키값을 보관할 필드

        private void ClearTextBoxes()
        {
            txtid.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtMail.Clear();
        }


        private void DB_Open()//사용자 정의 메서드
        {
            try
            {
                string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";
                string commandString = "select * from Phone";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);

                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        public Form1()
        {
            InitializeComponent();
            DB_Open();//*****  호출문(각 객체 생성)
        }



        private void DAOpenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DS.Clear(); //*****
                DBAdapter.Fill(DS, "phone");
                DBGrid.DataSource = DS.Tables["phone"].DefaultView;
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

                DS.Clear();//*****

                DBAdapter.Fill(DS, "Phone");

                phoneTable = DS.Tables["Phone"];  //*****
                DataRow newRow = phoneTable.NewRow();
                newRow["id"] = Convert.ToInt32(txtid.Text);
                newRow["PName"] = txtName.Text;
                newRow["Phone"] = txtPhone.Text;
                newRow["Email"] = txtMail.Text;

                phoneTable.Rows.Add(newRow);

                DBAdapter.Update(DS, "Phone");
                DS.AcceptChanges();  //****
                ClearTextBoxes();    //****
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
                DataSet DS = new DataSet();   //*****
                DBAdapter.Fill(DS, "Phone");   //*****

                DataTable phoneTable = DS.Tables["Phone"];//*****

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
                DS.Clear();//*****
                DBAdapter.Fill(DS, "Phone");
                phoneTable = DS.Tables["Phone"];//*****
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
                DS.Clear();//*****
                DBAdapter.Fill(DS, "Phone");
                phoneTable = DS.Tables["Phone"];//*****
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


        private void SearchBtn_Click(object sender, EventArgs e)
        {



        }


        private void SearchBtn_Click_1(object sender, EventArgs e)
        {
            DS.Clear();

            DBAdapter.Fill(DS, "Phone");

            phoneTable = DS.Tables["Phone"];

            DataRow[] ResultRows = phoneTable.Select("PName like  '%" + txtSearch.Text + "%'");
            // DS  테이블의 Select 메서드 이용 

            NameList.Items.Clear();

            foreach (DataRow currRow in ResultRows)
            {
                NameList.Items.Add(currRow["Id"].ToString() + " " + currRow["PName"].ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DS.Clear();
            DBAdapter.Fill(DS, "Phone");
            phoneTable = DS.Tables["Phone"];

            DataRow[] ResultRows = phoneTable.Select("PName like '%" + txtSearch.Text + "%'");

            DataColumn[] PrimaryKey = new DataColumn[1];
            PrimaryKey[0] = phoneTable.Columns["id"];
            phoneTable.PrimaryKey = PrimaryKey;

            DataRow currRow = phoneTable.Rows.Find(NameList.Text.Substring(0, 2));//*

            SelectedKeyValue = Convert.ToInt32(currRow["id"].ToString());
            txtid.Text = currRow["id"].ToString();
            txtName.Text = currRow["PName"].ToString();
            txtMail.Text = currRow["Email"].ToString();
            txtPhone.Text = currRow["Phone"].ToString();
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            if (NameList.SelectedIndex != 0)
            {
                NameList.SelectedIndex = NameList.SelectedIndex - 1;
            }
            else
            {
                MessageBox.Show("이곳은 레코드의 처음입니다.");
            }
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            if (NameList.SelectedIndex != NameList.Items.Count - 1)
            {
                NameList.SelectedIndex = NameList.SelectedIndex + 1;
            }
            else
            {
                MessageBox.Show("이곳은 레코드의 마지막입니다.");
            }
        }
    }
}

