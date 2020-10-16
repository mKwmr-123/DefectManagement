namespace DefectManagement
{
    partial class DefectDetail_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefectDetail_Form));
            this.ManagementNumber = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.detail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reception_date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deadline = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ManagementNumber
            // 
            this.ManagementNumber.AutoSize = true;
            this.ManagementNumber.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ManagementNumber.Location = new System.Drawing.Point(100, 13);
            this.ManagementNumber.Name = "ManagementNumber";
            this.ManagementNumber.Size = new System.Drawing.Size(71, 15);
            this.ManagementNumber.TabIndex = 0;
            this.ManagementNumber.Text = "管理番号";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Title.Location = new System.Drawing.Point(71, 38);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(37, 15);
            this.Title.TabIndex = 1;
            this.Title.Text = "件名";
            // 
            // detail
            // 
            this.detail.Location = new System.Drawing.Point(15, 65);
            this.detail.Multiline = true;
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            this.detail.Size = new System.Drawing.Size(773, 345);
            this.detail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "受付日";
            // 
            // reception_date
            // 
            this.reception_date.AutoSize = true;
            this.reception_date.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.reception_date.Location = new System.Drawing.Point(83, 425);
            this.reception_date.Name = "reception_date";
            this.reception_date.Size = new System.Drawing.Size(88, 16);
            this.reception_date.TabIndex = 4;
            this.reception_date.Text = "0000/00/00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(251, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "納期";
            // 
            // deadline
            // 
            this.deadline.AutoSize = true;
            this.deadline.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.deadline.Location = new System.Drawing.Point(320, 425);
            this.deadline.Name = "deadline";
            this.deadline.Size = new System.Drawing.Size(88, 16);
            this.deadline.TabIndex = 6;
            this.deadline.Text = "0000/00/00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "管理番号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(15, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "件名：";
            // 
            // DefectDetail_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deadline);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reception_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ManagementNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DefectDetail_Form";
            this.Text = "詳細情報";
            this.Load += new System.EventHandler(this.DefectDetail_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManagementNumber;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox detail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label reception_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label deadline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}