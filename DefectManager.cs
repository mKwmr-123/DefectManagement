using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DefectManagement
{
    public partial class ManagementMain : Form
    {
        static public int manage_id;        //管理番号
        static public int last_id;          //最新管理番号

        public ManagementMain()
        {
            InitializeComponent();
        }

        private void ManagementMain_Load(object sender, EventArgs e)
        {
            this.table_DefectTableAdapter.Fill(this.databaseDefect.Table_Defect);
            //管理番号初期化
            manage_id = 0;
            last_id = 0;
        }

        private void Button_All_Click(object sender, EventArgs e)
        {
            //全件表示
            DefectTableUpdate("SELECT * FROM Table_Defect");
        }

        private void Button_Detail_Click(object sender, EventArgs e)
        {
            if (table_DefectDataGridView.Rows.Count < 1)
            {
                //1件もデータがない場合
                MessageBox.Show("データがありません", "確認");
                return;
            }
            else if (table_DefectDataGridView.CurrentRow.Selected)
            {
                //選択行を管理番号にセット
                manage_id = (int)table_DefectDataGridView.CurrentRow.Cells[0].Value;
            }
            else
            {
                //行選択されていない場合
                return;
            }

            //詳細画面を表示
            DefectDetail_Form detail = new DefectDetail_Form();
            detail.ShowDialog();

        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            //データベースへの接続
            string connStr = ConfigurationManager.ConnectionStrings["dbDefectCn"].ConnectionString;
            //管理番号テーブルを降順に取得
            string sqlStr = "SELECT * FROM Table_ManageID ORDER BY manage_id DESC";

            using (SqlConnection cn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sqlStr,cn);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        //管理番号取得
                        int.TryParse(rd["manage_id"].ToString(), out last_id);
                        if(last_id > 0)
                        {
                            DateTime dt = DateTime.ParseExact(last_id.ToString().Substring(0, 6), "yyMMdd", null);
                            if (dt == null)
                            {
                                last_id = 0;
                            }
                            else if (dt == DateTime.Today)
                            {
                                //今日の番号が発行されていたら、プラス1
                                last_id++;
                            }
                            else
                            {
                                //今日の番号が発行されていない場合は、今日の日付の1番
                                int.TryParse(DateTime.Today.ToString("yy/MM/dd").Replace("/", "") + "001", out last_id);
                            }
                        }
                    }
                    else
                    {
                        //新規管理番号は現在の日付の1番
                        int.TryParse(DateTime.Today.ToString("yy/MM/dd").Replace("/", "") + "001", out last_id);
                    }
                }

            }

            //登録画面表示
            AddDefect add = new AddDefect();
            add.ShowDialog();

            //全件表示
            DefectTableUpdate("SELECT * FROM Table_Defect");
        }

        private void Button_Mod_Click(object sender, EventArgs e)
        {
            if (table_DefectDataGridView.Rows.Count < 1)
            {
                //1件もデータがない場合
                MessageBox.Show("データがありません", "確認");
                return;
            }
            else if (table_DefectDataGridView.CurrentRow.Selected)
            {
                //選択行を管理番号にセット
                manage_id = (int)table_DefectDataGridView.CurrentRow.Cells[0].Value;
            }
            else
            {
                //行選択されていない場合
                return;
            }

            //更新画面表示
            DefectModify mod = new DefectModify();
            mod.ShowDialog();

            //全件表示
            DefectTableUpdate("SELECT * FROM Table_Defect");
        }

        private void Button_Serch_Click(object sender, EventArgs e)
        {
            //検索画面を表示して、作成された文字列で詳細テーブルから抽出
            string sqlStr = SerchForm.ShowSerchForm();
            string sqlStrDefect = "SELECT * FROM Table_Defect WHERE 1=1";

            //データベースへの接続
            string connStr = ConfigurationManager.ConnectionStrings["dbDefectCn"].ConnectionString;

            using (SqlConnection cn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(sqlStr, cn);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    bool idFlg = false;
                    while (rd.Read())
                    {
                        //管理番号取得
                        int.TryParse(rd["manage_id"].ToString(), out last_id);
                        if (last_id > 0)
                        {
                            if (idFlg == false)
                            {
                                sqlStrDefect += " AND (manage_id='" + last_id + "'";
                                idFlg = true;
                            }
                            else
                            {
                                sqlStrDefect += " OR manage_id='" + last_id + "'";
                            }
                        }
                    }

                    if (idFlg)
                        sqlStrDefect += ")";
                }
            }
            //取得した管理番号で絞り込み
            DefectTableUpdate(sqlStrDefect);
        }

        private void DefectTableUpdate(string sqlStr)
        {
            //全件表示処理
            string connStr = ConfigurationManager.ConnectionStrings["dbDefectCn"].ConnectionString;
            using (SqlConnection cn = new SqlConnection(connStr))
            {
                try
                {
                    cn.Open();
                    var adapter = new SqlDataAdapter(sqlStr, cn);
                    var ds = new DataSet();

                    adapter.Fill(ds);
                    this.table_DefectDataGridView.DataSource = ds.Tables[0];
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"不具合一覧表示エラー");
                }
            }
        }
    }
}
