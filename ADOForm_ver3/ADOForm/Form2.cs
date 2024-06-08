using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.DataAccess.Client;
namespace ADOForm
{
    public partial class Form2 : Form
    {
        new Form1 Parent;
        //수정하거나 삭제하기 위해 선택된 행의 인덱스를 저장한다.
        private int SelectedRowIndex;

        // Data Provider인 DBAdapter 입니다.
        OracleDataAdapter DBAdapter;

        // DataSet 객체입니다.
        DataSet DS;

        // 추가, 수정, 삭제시에 필요한 명령문을 
        // 자동으로 작성해주는 객체입니다.
        OracleCommandBuilder myCommandBuilder;

        // ataTable 객체입니다.
        DataTable phoneTable;

        // 수정, 삭제할 때 필요한 레코드의 키값을 보관할 필드
        private int SelectedKeyValue;

        private void ClearTextBoxes()
        {
            txtid.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtMail.Clear();
        }
        private void DB_Open()
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
        public Form2()
        {
            InitializeComponent();
            DB_Open();//***
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

        private void Form2_Load(object sender, EventArgs e)
        {
            DS.Clear();
            DBAdapter.Fill(DS, "Phone");
            Parent = (Form1)Owner;
            phoneTable = DS.Tables["Phone"];

            DataRow[] ResultRows
                = phoneTable.Select("PName like '%" + Parent.TxtS + "%'");

            NameList.Items.Clear();

            foreach (DataRow currRow in ResultRows)
            {
                NameList.Items.Add(currRow["Id"].ToString()
                    + " " + currRow["PName"].ToString());
            }
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

        private void NameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DS.Clear();
            //DBAdapter.Fill(DS, "Phone");
            Parent = (Form1)Owner;
            phoneTable = DS.Tables["Phone"];

            DataRow[] ResultRows = phoneTable.Select("PName like '%" + Parent.TxtS + "%'");

            DataColumn[] PrimaryKey = new DataColumn[1];
            PrimaryKey[0] = phoneTable.Columns["id"];
            phoneTable.PrimaryKey = PrimaryKey;

            DataRow currRow = phoneTable.Rows.Find(NameList.Text.Substring(0, 2));

            SelectedKeyValue = Convert.ToInt32(currRow["id"].ToString());
            txtid.Text = currRow["id"].ToString();
            txtName.Text = currRow["PName"].ToString();
            txtMail.Text = currRow["Email"].ToString();
            txtPhone.Text = currRow["Phone"].ToString();
        }
    }
}