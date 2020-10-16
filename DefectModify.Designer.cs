namespace DefectManagement
{
    partial class DefectModify
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefectModify));
            this.label1 = new System.Windows.Forms.Label();
            this.manage_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.detail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reception_date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deadline = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.TextBox();
            this.buttonMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "管理番号：";
            // 
            // manage_id
            // 
            this.manage_id.AutoSize = true;
            this.manage_id.Location = new System.Drawing.Point(79, 13);
            this.manage_id.Name = "manage_id";
            this.manage_id.Size = new System.Drawing.Size(53, 12);
            this.manage_id.TabIndex = 1;
            this.manage_id.Text = "管理番号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "件名：";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(57, 37);
            this.title.MaxLength = 50;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(731, 19);
            this.title.TabIndex = 3;
            // 
            // detail
            // 
            this.detail.Location = new System.Drawing.Point(15, 62);
            this.detail.Multiline = true;
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(773, 356);
            this.detail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "受付日：";
            // 
            // reception_date
            // 
            this.reception_date.AutoSize = true;
            this.reception_date.Location = new System.Drawing.Point(69, 427);
            this.reception_date.Name = "reception_date";
            this.reception_date.Size = new System.Drawing.Size(53, 12);
            this.reception_date.TabIndex = 6;
            this.reception_date.Text = "00/00/00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "納期：";
            // 
            // deadline
            // 
            this.deadline.Location = new System.Drawing.Point(210, 424);
            this.deadline.MaxLength = 10;
            this.deadline.Name = "deadline";
            this.deadline.Size = new System.Drawing.Size(100, 19);
            this.deadline.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "ステータス：";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(603, 424);
            this.status.MaxLength = 10;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(185, 19);
            this.status.TabIndex = 10;
            // 
            // buttonMod
            // 
            this.buttonMod.BackColor = System.Drawing.Color.White;
            this.buttonMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMod.Location = new System.Drawing.Point(713, 8);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(75, 23);
            this.buttonMod.TabIndex = 11;
            this.buttonMod.Text = "更新";
            this.buttonMod.UseVisualStyleBackColor = false;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // DefectModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deadline);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reception_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.manage_id);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DefectModify";
            this.Text = "修正画面";
            this.Load += new System.EventHandler(this.DefectModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label manage_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox detail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label reception_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox deadline;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Button buttonMod;
    }
}