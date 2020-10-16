namespace DefectManagement
{
    partial class ManagementMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementMain));
            this.Button_All = new System.Windows.Forms.Button();
            this.Button_Serch = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Mod = new System.Windows.Forms.Button();
            this.Button_Detail = new System.Windows.Forms.Button();
            this.table_DefectDataGridView = new System.Windows.Forms.DataGridView();
            this.manageIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableDefectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDefect = new DefectManagement.DatabaseDefect();
            this.table_DefectTableAdapter = new DefectManagement.DatabaseDefectTableAdapters.Table_DefectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.table_DefectDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDefectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDefect)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_All
            // 
            this.Button_All.BackColor = System.Drawing.Color.White;
            this.Button_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_All.Location = new System.Drawing.Point(12, 12);
            this.Button_All.Name = "Button_All";
            this.Button_All.Size = new System.Drawing.Size(146, 23);
            this.Button_All.TabIndex = 0;
            this.Button_All.Text = "全件表示";
            this.Button_All.UseVisualStyleBackColor = false;
            this.Button_All.Click += new System.EventHandler(this.Button_All_Click);
            // 
            // Button_Serch
            // 
            this.Button_Serch.BackColor = System.Drawing.Color.White;
            this.Button_Serch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Serch.Location = new System.Drawing.Point(606, 12);
            this.Button_Serch.Name = "Button_Serch";
            this.Button_Serch.Size = new System.Drawing.Size(72, 23);
            this.Button_Serch.TabIndex = 1;
            this.Button_Serch.Text = "検索";
            this.Button_Serch.UseVisualStyleBackColor = false;
            this.Button_Serch.Click += new System.EventHandler(this.Button_Serch_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.BackColor = System.Drawing.Color.White;
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.Location = new System.Drawing.Point(787, 12);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 23);
            this.Button_Add.TabIndex = 2;
            this.Button_Add.Text = "登録";
            this.Button_Add.UseVisualStyleBackColor = false;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Mod
            // 
            this.Button_Mod.BackColor = System.Drawing.Color.White;
            this.Button_Mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Mod.Location = new System.Drawing.Point(697, 12);
            this.Button_Mod.Name = "Button_Mod";
            this.Button_Mod.Size = new System.Drawing.Size(75, 23);
            this.Button_Mod.TabIndex = 3;
            this.Button_Mod.Text = "修正";
            this.Button_Mod.UseVisualStyleBackColor = false;
            this.Button_Mod.Click += new System.EventHandler(this.Button_Mod_Click);
            // 
            // Button_Detail
            // 
            this.Button_Detail.BackColor = System.Drawing.Color.White;
            this.Button_Detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Detail.Location = new System.Drawing.Point(174, 12);
            this.Button_Detail.Name = "Button_Detail";
            this.Button_Detail.Size = new System.Drawing.Size(75, 23);
            this.Button_Detail.TabIndex = 6;
            this.Button_Detail.Text = "詳細";
            this.Button_Detail.UseVisualStyleBackColor = false;
            this.Button_Detail.Click += new System.EventHandler(this.Button_Detail_Click);
            // 
            // table_DefectDataGridView
            // 
            this.table_DefectDataGridView.AllowUserToAddRows = false;
            this.table_DefectDataGridView.AllowUserToDeleteRows = false;
            this.table_DefectDataGridView.AllowUserToOrderColumns = true;
            this.table_DefectDataGridView.AutoGenerateColumns = false;
            this.table_DefectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.table_DefectDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.table_DefectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_DefectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manageIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.table_DefectDataGridView.DataSource = this.tableDefectBindingSource;
            this.table_DefectDataGridView.Location = new System.Drawing.Point(12, 50);
            this.table_DefectDataGridView.Name = "table_DefectDataGridView";
            this.table_DefectDataGridView.ReadOnly = true;
            this.table_DefectDataGridView.RowTemplate.Height = 21;
            this.table_DefectDataGridView.Size = new System.Drawing.Size(851, 502);
            this.table_DefectDataGridView.TabIndex = 7;
            // 
            // manageIdDataGridViewTextBoxColumn
            // 
            this.manageIdDataGridViewTextBoxColumn.DataPropertyName = "manage_Id";
            this.manageIdDataGridViewTextBoxColumn.HeaderText = "管理番号";
            this.manageIdDataGridViewTextBoxColumn.Name = "manageIdDataGridViewTextBoxColumn";
            this.manageIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.manageIdDataGridViewTextBoxColumn.Width = 78;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "件名";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 54;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "ステータス";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 84;
            // 
            // tableDefectBindingSource
            // 
            this.tableDefectBindingSource.DataMember = "Table_Defect";
            this.tableDefectBindingSource.DataSource = this.databaseDefect;
            // 
            // databaseDefect
            // 
            this.databaseDefect.DataSetName = "DatabaseDefect";
            this.databaseDefect.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_DefectTableAdapter
            // 
            this.table_DefectTableAdapter.ClearBeforeFill = true;
            // 
            // ManagementMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 564);
            this.Controls.Add(this.table_DefectDataGridView);
            this.Controls.Add(this.Button_Detail);
            this.Controls.Add(this.Button_Mod);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Button_Serch);
            this.Controls.Add(this.Button_All);
            this.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagementMain";
            this.Text = "不具合管理";
            this.Load += new System.EventHandler(this.ManagementMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_DefectDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDefectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDefect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_All;
        private System.Windows.Forms.Button Button_Serch;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Mod;
        private System.Windows.Forms.Button Button_Detail;
        private System.Windows.Forms.DataGridView table_DefectDataGridView;
        private DatabaseDefect databaseDefect;
        private System.Windows.Forms.BindingSource tableDefectBindingSource;
        private DatabaseDefectTableAdapters.Table_DefectTableAdapter table_DefectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn manageIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}

