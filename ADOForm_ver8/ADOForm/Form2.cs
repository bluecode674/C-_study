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
using Oracle.DataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ADOForm
{
    public partial class Form2 : Form
    {
        private OracleConnection odpConn = new
                                    OracleConnection();
        Form1 _parent;

        public Form2(Form1 inform1)
        {
            InitializeComponent();
            _parent = inform1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (_parent.getstrCommand == "삭제")
            {
                btnOK.Text = "삭제";
                txtid.Enabled = false;
                initialTextBoxes();
            }
            else if (_parent.getstrCommand == "업데이트")
            {
                btnOK.Text = "업데이트";
                txtid.Enabled = false;
                txtName.Enabled = false;
                initialTextBoxes();
            }
            else btnOK.Text = "추가";
        }

        private void initialTextBoxes()//사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";
            odpConn.Open();

            string strqry = "select * from phone where id=:id";
            OracleCommand OraCmd = new OracleCommand(strqry,
                                              odpConn);

            OraCmd.Parameters.Add("id",
                 OracleDbType.Int32).Value = _parent.getintID;

            OracleDataReader odr = OraCmd.ExecuteReader();

            while (odr.Read())
            {
                txtid.Text = Convert.ToString(odr.GetValue(0));
                txtName.Text = Convert.ToString(odr.GetValue(1));
                txtPhone.Text = Convert.ToString(odr.GetValue(2));
                txtMail.Text = Convert.ToString(odr.GetValue(3));
            }
            odr.Close();
            odpConn.Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (btnOK.Text == "추가")
            {
                if (INSERTRow() > 0)
                {
                    MessageBox.Show("정상적으로 데이터 행이 추가됨.");
                }
                else MessageBox.Show("데이터 행이 추가되지 않음!");
                this.Close();
            }
            else if (btnOK.Text == "삭제")
            {
                if (DELETERow() > 0)
                {
                    MessageBox.Show("정상적으로 데이터 행이 삭제됨!");
                }
                else MessageBox.Show("데이터 행이 삭제되지 않음!");
                this.Close();
            }
            else
            {
                if (UPDATERow() > 0)
                {
                    MessageBox.Show("정상적으로 데이터가 업데이트됨!");
                }
                else MessageBox.Show("데이터 행이 업데이트되지 않음!");
                this.Close();
            }
        }

        private int INSERTRow()//사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";
            odpConn.Open();
            string strqry = "INSERT INTO phone VALUES (:id, :pname, :phone, :email)";
       
   OracleCommand OraCmd = new OracleCommand(strqry, odpConn);

            OraCmd.Parameters.Add("id", OracleDbType.Int32).Value =
                    txtid.Text.Trim();

            OraCmd.Parameters.Add("pname", OracleDbType.Varchar2, 20).Value = txtName.Text.Trim();

            OraCmd.Parameters.Add("phone", OracleDbType.Varchar2, 20).Value = txtPhone.Text.Trim();

            OraCmd.Parameters.Add("email", OracleDbType.Varchar2, 20).Value = txtMail.Text.Trim();
            return OraCmd.ExecuteNonQuery(); //추가되는 행수 반환
        }

        private int DELETERow() //사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";
            odpConn.Open();
            string strqry = "DELETE FROM phone WHERE id=:id";
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);

            OraCmd.Parameters.Add("id", OracleDbType.Int32).Value
                    = _parent.getintID;
            return OraCmd.ExecuteNonQuery();
        }

        private int UPDATERow() //사용자 함수 정의
        {
            odpConn.ConnectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))   (CONNECT_DATA =     (SERVER = DEDICATED)     (SERVICE_NAME = xe)   ) );";
            odpConn.Open();
            string strqry = "UPDATE  phone SET phone=:phone, email=:email WHERE id=:id";
            OracleCommand OraCmd = new OracleCommand(strqry, odpConn);
            OraCmd.Parameters.Add("phone", OracleDbType.Varchar2, 20).Value = txtPhone.Text.Trim();
            OraCmd.Parameters.Add("email", OracleDbType.Varchar2, 20).Value = txtMail.Text.Trim();
            OraCmd.Parameters.Add("id", OracleDbType.Int32).Value = _parent.getintID;
            return OraCmd.ExecuteNonQuery(); //업데이트되는 행수 반환
        }
    }
}
