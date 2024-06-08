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
using ADOForm;
using System.Data.SqlClient;


namespace ADOForm
{
    public partial class Form1 : Form
    {
        private int intID;  //ID 필드 설정
        private string strCommand;
        //데이터 삭제, 추가, 업데이트 인지를 설정할 문자열 필드

        private OracleConnection odpConn = new
                                            OracleConnection();

        public int getintID
        { get { return intID; } }

        public string getstrCommand
        { get { return strCommand; } }

        private void showDataGridView()  //사용자 정의 함수
        {
            try
            {
                odpConn.ConnectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";
                odpConn.Open();
                OracleDataAdapter oda = new OracleDataAdapter();
                oda.SelectCommand = new OracleCommand("SELECT * from phone", odpConn);

                DataTable dt = new DataTable();
                oda.Fill(dt);
                odpConn.Close();
                DBGrid.DataSource = dt;

                DBGrid.AutoResizeColumns();
                DBGrid.AutoSizeColumnsMode =
                             DataGridViewAutoSizeColumnsMode.Fill;

                DBGrid.SelectionMode =
                          DataGridViewSelectionMode.FullRowSelect;
                DBGrid.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("에러 발생 : " + ex.ToString());
                odpConn.Close();
            }
        }
        public Form1()  //자동 생성되니 참고 만 할 것
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showDataGridView();
        }

        private void 선택한행업데이트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strCommand = "업데이트";
            intID =
        Convert.ToInt32(DBGrid.SelectedCells[0].Value);
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
            form2.Dispose();
            showDataGridView();
        }

        private void 새로운데이터추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strCommand = "추가";
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
            form2.Dispose();
            showDataGridView();

        }

        private void 선택한행삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strCommand = "삭제";
            intID =
        Convert.ToInt32(DBGrid.SelectedCells[0].Value);

            Form2 form2 = new Form2(this);
            form2.ShowDialog();
            form2.Dispose();
            showDataGridView();

        }

    }
}