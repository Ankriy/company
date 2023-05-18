
namespace company
{
    partial class FmAddсотрудника
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
            this.txtbx_фио = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_пол = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_др = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_адрес = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_сп = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbx_Образование = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbx_ор = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbx_диплом = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbx_спец = new System.Windows.Forms.TextBox();
            this.cmbBx_Отдел = new System.Windows.Forms.ComboBox();
            this.cmbBx_Должность = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbx_фио
            // 
            this.txtbx_фио.Location = new System.Drawing.Point(47, 53);
            this.txtbx_фио.Name = "txtbx_фио";
            this.txtbx_фио.Size = new System.Drawing.Size(129, 22);
            this.txtbx_фио.TabIndex = 0;
            this.txtbx_фио.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_фио_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пол";
            // 
            // txtbx_пол
            // 
            this.txtbx_пол.Location = new System.Drawing.Point(47, 101);
            this.txtbx_пол.Name = "txtbx_пол";
            this.txtbx_пол.Size = new System.Drawing.Size(129, 22);
            this.txtbx_пол.TabIndex = 3;
            this.txtbx_пол.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_пол_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата рождения";
            // 
            // txtbx_др
            // 
            this.txtbx_др.Location = new System.Drawing.Point(47, 148);
            this.txtbx_др.Name = "txtbx_др";
            this.txtbx_др.Size = new System.Drawing.Size(129, 22);
            this.txtbx_др.TabIndex = 5;
            this.txtbx_др.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_др_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Адрес";
            // 
            // txtbx_адрес
            // 
            this.txtbx_адрес.Location = new System.Drawing.Point(201, 53);
            this.txtbx_адрес.Name = "txtbx_адрес";
            this.txtbx_адрес.Size = new System.Drawing.Size(129, 22);
            this.txtbx_адрес.TabIndex = 7;
            this.txtbx_адрес.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_адрес_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Семейное положение";
            // 
            // txtbx_сп
            // 
            this.txtbx_сп.Location = new System.Drawing.Point(201, 101);
            this.txtbx_сп.Name = "txtbx_сп";
            this.txtbx_сп.Size = new System.Drawing.Size(129, 22);
            this.txtbx_сп.TabIndex = 9;
            this.txtbx_сп.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_сп_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Образование";
            // 
            // txtbx_Образование
            // 
            this.txtbx_Образование.Location = new System.Drawing.Point(201, 148);
            this.txtbx_Образование.Name = "txtbx_Образование";
            this.txtbx_Образование.Size = new System.Drawing.Size(129, 22);
            this.txtbx_Образование.TabIndex = 11;
            this.txtbx_Образование.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_Образование_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Опыт работы";
            // 
            // txtbx_ор
            // 
            this.txtbx_ор.Location = new System.Drawing.Point(358, 148);
            this.txtbx_ор.Name = "txtbx_ор";
            this.txtbx_ор.Size = new System.Drawing.Size(129, 22);
            this.txtbx_ор.TabIndex = 17;
            this.txtbx_ор.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_ор_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Диплом";
            // 
            // txtbx_диплом
            // 
            this.txtbx_диплом.Location = new System.Drawing.Point(358, 101);
            this.txtbx_диплом.Name = "txtbx_диплом";
            this.txtbx_диплом.Size = new System.Drawing.Size(129, 22);
            this.txtbx_диплом.TabIndex = 15;
            this.txtbx_диплом.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_диплом_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Специальность";
            // 
            // txtbx_спец
            // 
            this.txtbx_спец.Location = new System.Drawing.Point(358, 53);
            this.txtbx_спец.Name = "txtbx_спец";
            this.txtbx_спец.Size = new System.Drawing.Size(129, 22);
            this.txtbx_спец.TabIndex = 13;
            this.txtbx_спец.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_спец_KeyDown);
            // 
            // cmbBx_Отдел
            // 
            this.cmbBx_Отдел.FormattingEnabled = true;
            this.cmbBx_Отдел.Location = new System.Drawing.Point(503, 53);
            this.cmbBx_Отдел.Name = "cmbBx_Отдел";
            this.cmbBx_Отдел.Size = new System.Drawing.Size(148, 24);
            this.cmbBx_Отдел.TabIndex = 19;
            this.cmbBx_Отдел.SelectedValueChanged += new System.EventHandler(this.cmbBx_Отдел_SelectedValueChanged);
            this.cmbBx_Отдел.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBx_Отдел_KeyDown);
            // 
            // cmbBx_Должность
            // 
            this.cmbBx_Должность.FormattingEnabled = true;
            this.cmbBx_Должность.Location = new System.Drawing.Point(503, 99);
            this.cmbBx_Должность.Name = "cmbBx_Должность";
            this.cmbBx_Должность.Size = new System.Drawing.Size(148, 24);
            this.cmbBx_Должность.TabIndex = 20;
            this.cmbBx_Должность.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBx_Должность_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(500, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Отдел";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(500, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Должность";
            // 
            // FmAddсотрудника
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 251);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbBx_Должность);
            this.Controls.Add(this.cmbBx_Отдел);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbx_ор);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbx_диплом);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbx_спец);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbx_Образование);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbx_сп);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbx_адрес);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_др);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_пол);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbx_фио);
            this.Name = "FmAddсотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_фио;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_пол;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_др;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_адрес;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_сп;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbx_Образование;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbx_ор;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbx_диплом;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbx_спец;
        private System.Windows.Forms.ComboBox cmbBx_Отдел;
        private System.Windows.Forms.ComboBox cmbBx_Должность;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}