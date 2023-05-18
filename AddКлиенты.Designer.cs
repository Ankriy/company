
namespace company
{
    partial class AddКлиенты
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
            this.txtbx_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_date1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_ФИО = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.txtbx_date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtbx_phone
            // 
            this.txtbx_phone.Location = new System.Drawing.Point(401, 82);
            this.txtbx_phone.Name = "txtbx_phone";
            this.txtbx_phone.Size = new System.Drawing.Size(164, 22);
            this.txtbx_phone.TabIndex = 13;
            this.txtbx_phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_phone_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Номер телефона";
            // 
            // txtbx_date1
            // 
            this.txtbx_date1.Location = new System.Drawing.Point(228, 82);
            this.txtbx_date1.Name = "txtbx_date1";
            this.txtbx_date1.Size = new System.Drawing.Size(164, 22);
            this.txtbx_date1.TabIndex = 11;
            this.txtbx_date1.Visible = false;
            this.txtbx_date1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_date_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Дата регистрации";
            // 
            // txtbx_ФИО
            // 
            this.txtbx_ФИО.Location = new System.Drawing.Point(58, 82);
            this.txtbx_ФИО.Name = "txtbx_ФИО";
            this.txtbx_ФИО.Size = new System.Drawing.Size(164, 22);
            this.txtbx_ФИО.TabIndex = 9;
            this.txtbx_ФИО.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_ФИО_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "ФИО";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(228, 123);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(164, 53);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Добавить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txtbx_date
            // 
            this.txtbx_date.Location = new System.Drawing.Point(225, 82);
            this.txtbx_date.Name = "txtbx_date";
            this.txtbx_date.Size = new System.Drawing.Size(167, 22);
            this.txtbx_date.TabIndex = 14;
            // 
            // AddКлиенты
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 254);
            this.Controls.Add(this.txtbx_date);
            this.Controls.Add(this.txtbx_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_date1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_ФИО);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Name = "AddКлиенты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_date1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_ФИО;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DateTimePicker txtbx_date;
    }
}