using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace DefectManagement
{
    public partial class DefectDetail_Form : Form
    {
        public DefectDetail_Form()
        {
            InitializeComponent();
        }

        private void DefectDetail_Form_Load(object sender, EventArgs e)
        {
            //データベースへの接続
            string connStr = ConfigurationManager.ConnectionStrings["dbDefectCn"].ConnectionString;
            string sqlStr = "SELECT * FROM Table_DefectDetail WHERE manage_id=" + ManagementMain.manage_id.ToString();

            using (SqlConnection cn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        //選択された行の管理番号から詳細データを表示
                        ManagementNumber.Text = rd["manage_Id"].ToString();
                        Title.Text = rd["title"].ToString();
                        detail.Text = rd["detail"].ToString();
                        reception_date.Text = DateTime.Parse(rd["reception_date"].ToString()).ToString("yyyy/MM/dd");
                        deadline.Text = DateTime.Parse(rd["deadline"].ToString()).ToString("yyyy/MM/dd");
                    }
                }

            }
        }
    }
}
