using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;

namespace DefectManagement
{
    public partial class DefectModify : Form
    {
        public DefectModify()
        {
            InitializeComponent();
        }
            
        private void DefectModify_Load(object sender, EventArgs e)
        {
            //データベースへの接続
            string connStr = ConfigurationManager.ConnectionStrings["dbDefectCn"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connStr))
            {
                //選択された行の管理番号からレコードを抜き出す
                SqlCommand cmd = new SqlCommand("SELECT * FROM Table_DefectDetail WHERE manage_id=" + ManagementMain.manage_id.ToString(), cn);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        //管理番号、件名、詳細内容、受付日、納期
                        manage_id.Text = rd["manage_id"].ToString();
                        title.Text = rd["title"].ToString();
                        detail.Text = rd["detail"].ToString();
                        reception_date.Text = DateTime.Parse(rd["reception_date"].ToString()).ToString("yyyy/MM/dd");
                        deadline.Text = DateTime.Parse(rd["deadline"].ToString()).ToString("yyyy/MM/dd");
                    }
                }

                cmd = new SqlCommand("SELECT * FROM Table_Defect WHERE manage_id=" + ManagementMain.manage_id.ToString(), cn);
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        //ステータス
                        status.Text = rd["status"].ToString();
                    }
                }
            }
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            //データベースへの接続
            string connStr = ConfigurationManager.ConnectionStrings["dbDefectCn"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connStr))
            {
                try
                {
                    cn.Open();
                    using(var tran = cn.BeginTransaction())
                    using (var cmd = new SqlCommand() {Connection = cn, Transaction = tran})
                    {
                        try
                        {
                            //入力された内容からデータ更新
                            //不具合詳細テーブル
                            cmd.CommandText = "UPDATE Table_DefectDetail SET " +
                                                "title=N'" + title.Text +
                                                "',detail=N'" + detail.Text +
                                                "',deadline='" + DateTime.Parse(deadline.Text).ToString("yyyy/MM/dd") +
                                                "' WHERE manage_id=" + ManagementMain.manage_id.ToString();
                            cmd.ExecuteNonQuery();

                            //不具合テーブル
                            cmd.CommandText = "UPDATE Table_Defect SET " +
                                                "status=N'" + status.Text +
                                                "' WHERE manage_id=" + ManagementMain.manage_id.ToString();
                            cmd.ExecuteNonQuery();

                            //コミット
                            tran.Commit();
                        }
                        catch
                        {
                            //ロールバック
                            tran.Rollback();
                            throw;
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"更新エラー");
                    throw;
                }
                finally
                {
                    cn.Close();
                }

            }

            this.Close();
        }
    }
}
