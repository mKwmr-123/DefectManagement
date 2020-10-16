namespace DefectManagement
{
    partial class AddDefect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDefect));
            this.label1 = new System.Windows.Forms.Label();
            this.manage_id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_detail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_reception_date = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_deadline = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
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
            this.manage_id.Location = new System.Drawing.Point(82, 13);
            this.manage_id.Name = "manage_id";
            this.manage_id.Size = new System.Drawing.Size(59, 12);
            this.manage_id.TabIndex = 1;
            this.manage_id.Text = "000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "件名";
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(48, 34);
            this.textBox_Title.MaxLength = 50;
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(740, 19);
            this.textBox_Title.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "詳細内容";
            // 
            // textBox_detail
            // 
            this.textBox_detail.Location = new System.Drawing.Point(17, 79);
            this.textBox_detail.Multiline = true;
            this.textBox_detail.Name = "textBox_detail";
            this.textBox_detail.Size = new System.Drawing.Size(771, 324);
            this.textBox_detail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "受付日：";
            // 
            // textBox_reception_date
            // 
            this.textBox_reception_date.Location = new System.Drawing.Point(64, 414);
            this.textBox_reception_date.MaxLength = 10;
            this.textBox_reception_date.Name = "textBox_reception_date";
            this.textBox_reception_date.Size = new System.Drawing.Size(77, 19);
            this.textBox_reception_date.TabIndex = 7;
            this.textBox_reception_date.Text = "00/00/00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "納期：";
            // 
            // textBox_deadline
            // 
            this.textBox_deadline.Location = new System.Drawing.Point(236, 414);
            this.textBox_deadline.MaxLength = 10;
            this.textBox_deadline.Name = "textBox_deadline";
            this.textBox_deadline.Size = new System.Drawing.Size(79, 19);
            this.textBox_deadline.TabIndex = 9;
            this.textBox_deadline.Text = "00/00/00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(662, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "ステータス：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(718, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "受付";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.White;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Location = new System.Drawing.Point(713, 5);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "登録";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // AddDefect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_deadline);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_reception_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_detail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.manage_id);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDefect";
            this.Text = "登録画面";
            this.Load += new System.EventHandler(this.AddDefect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label manage_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_detail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_reception_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_deadline;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_add;
    }
}