
namespace company
{
    partial class DismissWorker
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dismissworker = new System.Windows.Forms.Button();
            this.txtbx_ФИО = new System.Windows.Forms.TextBox();
            this.txtbx_article = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_cause = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_date = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_ID = new System.Windows.Forms.TextBox();
            this.txtbx_должность = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_отдел = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // btn_dismissworker
            // 
            this.btn_dismissworker.Location = new System.Drawing.Point(51, 332);
            this.btn_dismissworker.Name = "btn_dismissworker";
            this.btn_dismissworker.Size = new System.Drawing.Size(118, 53);
            this.btn_dismissworker.TabIndex = 1;
            this.btn_dismissworker.Text = "Уволить";
            this.btn_dismissworker.UseVisualStyleBackColor = true;
            this.btn_dismissworker.Click += new System.EventHandler(this.btn_dismissworker_Click);
            // 
            // txtbx_ФИО
            // 
            this.txtbx_ФИО.Location = new System.Drawing.Point(12, 74);
            this.txtbx_ФИО.Name = "txtbx_ФИО";
            this.txtbx_ФИО.Size = new System.Drawing.Size(225, 22);
            this.txtbx_ФИО.TabIndex = 2;
            // 
            // txtbx_article
            // 
            this.txtbx_article.Location = new System.Drawing.Point(15, 212);
            this.txtbx_article.Name = "txtbx_article";
            this.txtbx_article.Size = new System.Drawing.Size(222, 22);
            this.txtbx_article.TabIndex = 8;
            this.txtbx_article.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_article_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Статья";
            // 
            // txtbx_cause
            // 
            this.txtbx_cause.Location = new System.Drawing.Point(15, 258);
            this.txtbx_cause.Name = "txtbx_cause";
            this.txtbx_cause.Size = new System.Drawing.Size(222, 22);
            this.txtbx_cause.TabIndex = 10;
            this.txtbx_cause.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_cause_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Причина";
            // 
            // txtbx_date
            // 
            this.txtbx_date.Location = new System.Drawing.Point(15, 304);
            this.txtbx_date.Name = "txtbx_date";
            this.txtbx_date.Size = new System.Drawing.Size(222, 22);
            this.txtbx_date.TabIndex = 12;
            this.txtbx_date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_date_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Дата увольнения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // txtbx_ID
            // 
            this.txtbx_ID.Location = new System.Drawing.Point(12, 28);
            this.txtbx_ID.Name = "txtbx_ID";
            this.txtbx_ID.Size = new System.Drawing.Size(225, 22);
            this.txtbx_ID.TabIndex = 4;
            // 
            // txtbx_должность
            // 
            this.txtbx_должность.Location = new System.Drawing.Point(15, 166);
            this.txtbx_должность.Name = "txtbx_должность";
            this.txtbx_должность.Size = new System.Drawing.Size(222, 22);
            this.txtbx_должность.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Должность";
            // 
            // txtbx_отдел
            // 
            this.txtbx_отдел.Location = new System.Drawing.Point(15, 120);
            this.txtbx_отдел.Name = "txtbx_отдел";
            this.txtbx_отдел.Size = new System.Drawing.Size(222, 22);
            this.txtbx_отдел.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Отдел";
            // 
            // DismissWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 393);
            this.Controls.Add(this.txtbx_должность);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_отдел);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbx_date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbx_cause);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbx_article);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbx_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_ФИО);
            this.Controls.Add(this.btn_dismissworker);
            this.Controls.Add(this.label1);
            this.Name = "DismissWorker";
            this.Load += new System.EventHandler(this.DismissWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dismissworker;
        private System.Windows.Forms.TextBox txtbx_ФИО;
        private System.Windows.Forms.TextBox txtbx_article;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_cause;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_ID;
        private System.Windows.Forms.TextBox txtbx_должность;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_отдел;
        private System.Windows.Forms.Label label7;
    }
}