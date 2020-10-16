using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefectManagement
{
    public partial class SerchForm : Form
    {
        public string sqlStr;
        public SerchForm()
        {
            InitializeComponent();
        }

        private void button_serch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(manage_id.Text))
            {
                //管理番号
                this.sqlStr += "AND manage_id=" + manage_id.Text;
            }
            if (!String.IsNullOrEmpty(title.Text))
            {
                //件名
                var wk = title.Text.Contains("*") ? " LIKE N'" + title.Text.Replace("*","%") : "=N'" + title.Text;
                this.sqlStr += "AND title" +  wk + "'";
            }
            if (!String.IsNullOrEmpty(detail.Text))
            {
                //詳細内容
                var wk = detail.Text.Contains("*") ? " LIKE N'" + detail.Text.Replace("*", "%") : "=N'" + detail.Text;
                this.sqlStr += "AND detail" + wk + "'";
            }
            if (!String.IsNullOrEmpty(reception_date.Text))
            {
                //受付日
                string wk = "='";
                if (reception_date.Text.Contains("<="))
                    wk = "<='";
                else if (reception_date.Text.Contains(">="))
                    wk = ">='";
                else if (reception_date.Text.Contains("<"))
                    wk = "<'";
                else if (reception_date.Text.Contains(">"))
                    wk = ">'";
                wk += reception_date.Text.Replace("=", "").Replace("<", "").Replace(">", "");

                this.sqlStr += "AND reception_date" + wk + "'";
            }
            if (!String.IsNullOrEmpty(deadline.Text))
            {
                //納期
                string wk = "='";
                if (deadline.Text.Contains("<="))
                    wk = "<='";
                else if (deadline.Text.Contains(">="))
                    wk = ">='";
                else if (deadline.Text.Contains("<"))
                    wk = "<'";
                else if (deadline.Text.Contains(">"))
                    wk = ">'";
                wk += deadline.Text.Replace("=", "").Replace("<", "").Replace(">", "");

                this.sqlStr += "AND deadline" + wk + "'";
            }

            this.Close();
        }

        static public string ShowSerchForm()
        {
            SerchForm sf = new SerchForm();
            //検索SQL作成
            sf.sqlStr = "SELECT * FROM Table_DefectDetail WHERE 1=1";
            sf.ShowDialog();
            string rt = sf.sqlStr;
            sf.Dispose();
            return rt;
        }
    }
}
