    using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DefectManagement
{
    public partial class AddDefect : Form
    {
        public AddDefect()
        {
            InitializeComponent();
        }

        private void AddDefect_Load(object sender, EventArgs e)
        {
            //管理番号、受付日、納期をセット
            manage_id.Text = ManagementMain.last_id.ToString();
            textBox_reception_date.Text = DateTime.Today.ToString("yyyy/MM/dd");
            textBox_deadline.Text = DateTime.Today.AddDays(7).ToString("yyyy/MM/dd");
        }

        private void button_add_Click(object sender, EventArgs e)
        {

            if (ManagementMain.last_id <= 0)
            {
                //管理番号が取得できていない場合
                MessageBox.Show("管理番号が正しく設定されませんでした。","エラー");
                this.Close();
                return;
            }

            if (String.IsNullOrEmpty(textBox_Title.Text))
            {
                MessageBox.Show("件名を入力してください。", "確認");
                return;
            }

            if (String.IsNullOrEmpty(textBox_reception_date.Text))
            {
                MessageBox.Show("受付日を入力してください。", "確認");
                return;
            }

            //データ接続
            string connStr = ConfigurationManager.ConnectionStrings["dbDefectCn"].ConnectionString;

            using (SqlConnection cn = new SqlConnection(connStr))
            {
                try
                {
                    cn.Open();
                    using (var tran = cn.BeginTransaction())
                    using (var cmd = new SqlCommand() { Connection = cn, Transaction = tran })
                    {
                        try
                        {
                            //データ追加SQL
                            //管理番号テーブル
                            cmd.CommandText = "INSERT INTO Table_ManageID VALUES(" + ManagementMain.last_id.ToString() + ")";
                            cmd.ExecuteNonQuery();

                            //不具合テーブル
                            cmd.CommandText = @"INSERT INTO Table_Defect VALUES(" +
                                            ManagementMain.last_id.ToString() + ",N'" +
                                            textBox_Title.Text + "',N" +
                                            "'受付')";
                            cmd.ExecuteNonQuery();

                            //不具合詳細テーブル
                            cmd.CommandText = @"INSERT INTO Table_DefectDetail VALUES(" +
                                            ManagementMain.last_id.ToString() + ",N'" +
                                            textBox_Title.Text + "',N'" +
                                            textBox_detail.Text + "','" +
                                            textBox_reception_date.Text + "','" +
                                            textBox_deadline.Text + "')";
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
                    MessageBox.Show(ex.Message,"登録エラー");
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
