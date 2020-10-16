namespace DefectManagement
{
    partial class SerchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerchForm));
            this.label1 = new System.Windows.Forms.Label();
            this.manage_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.detail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reception_date = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deadline = new System.Windows.Forms.TextBox();
            this.button_serch = new System.Windows.Forms.Button();
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
            this.manage_id.Location = new System.Drawing.Point(78, 10);
            this.manage_id.MaxLength = 9;
            this.manage_id.Name = "manage_id";
            this.manage_id.Size = new System.Drawing.Size(100, 19);
            this.manage_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "件名：";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(78, 41);
            this.title.MaxLength = 50;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(305, 19);
            this.title.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "詳細内容：";
            // 
            // detail
            // 
            this.detail.Location = new System.Drawing.Point(78, 76);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(466, 19);
            this.detail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "受付日：";
            // 
            // reception_date
            // 
            this.reception_date.Location = new System.Drawing.Point(78, 112);
            this.reception_date.MaxLength = 10;
            this.reception_date.Name = "reception_date";
            this.reception_date.Size = new System.Drawing.Size(100, 19);
            this.reception_date.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "納期：";
            // 
            // deadline
            // 
            this.deadline.Location = new System.Drawing.Point(78, 149);
            this.deadline.MaxLength = 10;
            this.deadline.Name = "deadline";
            this.deadline.Size = new System.Drawing.Size(100, 19);
            this.deadline.TabIndex = 9;
            // 
            // button_serch
            // 
            this.button_serch.BackColor = System.Drawing.Color.White;
            this.button_serch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_serch.Location = new System.Drawing.Point(469, 180);
            this.button_serch.Name = "button_serch";
            this.button_serch.Size = new System.Drawing.Size(75, 23);
            this.button_serch.TabIndex = 12;
            this.button_serch.Text = "検索";
            this.button_serch.UseVisualStyleBackColor = false;
            this.button_serch.Click += new System.EventHandler(this.button_serch_Click);
            // 
            // SerchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 216);
            this.Controls.Add(this.button_serch);
            this.Controls.Add(this.deadline);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reception_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.manage_id);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SerchForm";
            this.Text = "検索条件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox manage_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox detail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox reception_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox deadline;
        private System.Windows.Forms.Button button_serch;
    }
}