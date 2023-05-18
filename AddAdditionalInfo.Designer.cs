
namespace company
{
    partial class AddAdditionalInfo
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
            this.ltbx_Сотрудники = new System.Windows.Forms.ListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtbx_numpas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_numtrud = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_date1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_гражданство = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbx_ИНН = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbx_снилс = new System.Windows.Forms.TextBox();
            this.txtbx_date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ltbx_Сотрудники
            // 
            this.ltbx_Сотрудники.FormattingEnabled = true;
            this.ltbx_Сотрудники.ItemHeight = 16;
            this.ltbx_Сотрудники.Location = new System.Drawing.Point(12, 12);
            this.ltbx_Сотрудники.Name = "ltbx_Сотрудники";
            this.ltbx_Сотрудники.Size = new System.Drawing.Size(239, 420);
            this.ltbx_Сотрудники.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(532, 56);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(510, 331);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(172, 101);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtbx_numpas
            // 
            this.txtbx_numpas.Location = new System.Drawing.Point(260, 31);
            this.txtbx_numpas.Name = "txtbx_numpas";
            this.txtbx_numpas.Size = new System.Drawing.Size(176, 22);
            this.txtbx_numpas.TabIndex = 6;
            this.txtbx_numpas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_numpas_KeyDown);
            this.txtbx_numpas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Номер и серия паспорта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Номер трудовой книжки";
            // 
            // txtbx_numtrud
            // 
            this.txtbx_numtrud.Location = new System.Drawing.Point(260, 76);
            this.txtbx_numtrud.Name = "txtbx_numtrud";
            this.txtbx_numtrud.Size = new System.Drawing.Size(176, 22);
            this.txtbx_numtrud.TabIndex = 8;
            this.txtbx_numtrud.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_numtrud_KeyDown);
            this.txtbx_numtrud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дата приёма на работу";
            // 
            // txtbx_date1
            // 
            this.txtbx_date1.Location = new System.Drawing.Point(260, 352);
            this.txtbx_date1.Name = "txtbx_date1";
            this.txtbx_date1.Size = new System.Drawing.Size(176, 22);
            this.txtbx_date1.TabIndex = 10;
            this.txtbx_date1.Visible = false;
            this.txtbx_date1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_date_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Номер телефона";
            // 
            // txtbx_phone
            // 
            this.txtbx_phone.Location = new System.Drawing.Point(260, 166);
            this.txtbx_phone.Name = "txtbx_phone";
            this.txtbx_phone.Size = new System.Drawing.Size(176, 22);
            this.txtbx_phone.TabIndex = 12;
            this.txtbx_phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_phone_KeyDown);
            this.txtbx_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Гражданство";
            // 
            // txtbx_гражданство
            // 
            this.txtbx_гражданство.Location = new System.Drawing.Point(260, 211);
            this.txtbx_гражданство.Name = "txtbx_гражданство";
            this.txtbx_гражданство.Size = new System.Drawing.Size(176, 22);
            this.txtbx_гражданство.TabIndex = 14;
            this.txtbx_гражданство.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_гражданство_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "ИНН";
            // 
            // txtbx_ИНН
            // 
            this.txtbx_ИНН.Location = new System.Drawing.Point(260, 256);
            this.txtbx_ИНН.Name = "txtbx_ИНН";
            this.txtbx_ИНН.Size = new System.Drawing.Size(176, 22);
            this.txtbx_ИНН.TabIndex = 16;
            this.txtbx_ИНН.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_ИНН_KeyDown);
            this.txtbx_ИНН.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "СНИЛС";
            // 
            // txtbx_снилс
            // 
            this.txtbx_снилс.Location = new System.Drawing.Point(260, 301);
            this.txtbx_снилс.Name = "txtbx_снилс";
            this.txtbx_снилс.Size = new System.Drawing.Size(176, 22);
            this.txtbx_снилс.TabIndex = 18;
            this.txtbx_снилс.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_снилс_KeyDown);
            this.txtbx_снилс.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_KeyPress);
            // 
            // txtbx_date
            // 
            this.txtbx_date.Location = new System.Drawing.Point(260, 121);
            this.txtbx_date.Name = "txtbx_date";
            this.txtbx_date.Size = new System.Drawing.Size(176, 22);
            this.txtbx_date.TabIndex = 20;
            // 
            // AddAdditionalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbx_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbx_снилс);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbx_ИНН);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbx_гражданство);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbx_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_date1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_numtrud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_numpas);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.ltbx_Сотрудники);
            this.Name = "AddAdditionalInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ltbx_Сотрудники;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtbx_numpas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_numtrud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_date1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_гражданство;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbx_ИНН;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbx_снилс;
        private System.Windows.Forms.DateTimePicker txtbx_date;
    }
}