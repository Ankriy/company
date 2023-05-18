
namespace company
{
    partial class Additional_Info
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_addinfo = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_AddAdditionalInfo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_ФИО = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_паспорт = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_трудовая = new System.Windows.Forms.Label();
            this.lbl_гражданство = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_телефон = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_датаПриёма = new System.Windows.Forms.Label();
            this.lbl_снилс = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_ИНН = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_IDInfo = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txtbx_снилс = new System.Windows.Forms.TextBox();
            this.txtbx_ФИО = new System.Windows.Forms.TextBox();
            this.txtbx_паспорт = new System.Windows.Forms.TextBox();
            this.txtbx_номертрудовой = new System.Windows.Forms.TextBox();
            this.txtbx_телефон = new System.Windows.Forms.TextBox();
            this.txtbx_ИНН = new System.Windows.Forms.TextBox();
            this.txtbx_гражданство = new System.Windows.Forms.TextBox();
            this.txtbx_ID = new System.Windows.Forms.TextBox();
            this.btn_saveChange = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_addImage = new System.Windows.Forms.Button();
            this.pcr_Bx_сотрудник = new System.Windows.Forms.PictureBox();
            this.txtbx_date = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addinfo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Bx_сотрудник)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_addinfo);
            this.groupBox1.Location = new System.Drawing.Point(497, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgv_addinfo
            // 
            this.dgv_addinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_addinfo.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_addinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_addinfo.Location = new System.Drawing.Point(3, 18);
            this.dgv_addinfo.Name = "dgv_addinfo";
            this.dgv_addinfo.RowHeadersVisible = false;
            this.dgv_addinfo.RowHeadersWidth = 51;
            this.dgv_addinfo.Size = new System.Drawing.Size(219, 303);
            this.dgv_addinfo.TabIndex = 0;
            this.dgv_addinfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_addinfo_CellContentClick);
            this.dgv_addinfo.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_addinfo_CellMouseEnter);
            this.dgv_addinfo.SelectionChanged += new System.EventHandler(this.dgv_addinfo_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem,
            this.удалитьСтрокуToolStripMenuItem,
            this.копироватьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(188, 76);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьСтрокуToolStripMenuItem
            // 
            this.удалитьСтрокуToolStripMenuItem.Name = "удалитьСтрокуToolStripMenuItem";
            this.удалитьСтрокуToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.удалитьСтрокуToolStripMenuItem.Text = "Удалить строку ";
            this.удалитьСтрокуToolStripMenuItem.Click += new System.EventHandler(this.удалитьСтрокуToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // btn_AddAdditionalInfo
            // 
            this.btn_AddAdditionalInfo.Location = new System.Drawing.Point(529, 347);
            this.btn_AddAdditionalInfo.Name = "btn_AddAdditionalInfo";
            this.btn_AddAdditionalInfo.Size = new System.Drawing.Size(161, 60);
            this.btn_AddAdditionalInfo.TabIndex = 2;
            this.btn_AddAdditionalInfo.Text = "добавить запись";
            this.btn_AddAdditionalInfo.UseVisualStyleBackColor = true;
            this.btn_AddAdditionalInfo.Click += new System.EventHandler(this.btn_AddAdditionalInfo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl_ФИО
            // 
            this.lbl_ФИО.AutoSize = true;
            this.lbl_ФИО.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ФИО.Location = new System.Drawing.Point(150, 70);
            this.lbl_ФИО.Name = "lbl_ФИО";
            this.lbl_ФИО.Size = new System.Drawing.Size(73, 19);
            this.lbl_ФИО.TabIndex = 6;
            this.lbl_ФИО.Text = "Ошибка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(150, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(150, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Паспорт";
            // 
            // lbl_паспорт
            // 
            this.lbl_паспорт.AutoSize = true;
            this.lbl_паспорт.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_паспорт.Location = new System.Drawing.Point(150, 115);
            this.lbl_паспорт.Name = "lbl_паспорт";
            this.lbl_паспорт.Size = new System.Drawing.Size(73, 19);
            this.lbl_паспорт.TabIndex = 9;
            this.lbl_паспорт.Text = "Ошибка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(150, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Номер трудовой книжки";
            // 
            // lbl_трудовая
            // 
            this.lbl_трудовая.AutoSize = true;
            this.lbl_трудовая.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_трудовая.Location = new System.Drawing.Point(150, 158);
            this.lbl_трудовая.Name = "lbl_трудовая";
            this.lbl_трудовая.Size = new System.Drawing.Size(73, 19);
            this.lbl_трудовая.TabIndex = 11;
            this.lbl_трудовая.Text = "Ошибка";
            // 
            // lbl_гражданство
            // 
            this.lbl_гражданство.AutoSize = true;
            this.lbl_гражданство.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_гражданство.Location = new System.Drawing.Point(150, 286);
            this.lbl_гражданство.Name = "lbl_гражданство";
            this.lbl_гражданство.Size = new System.Drawing.Size(73, 19);
            this.lbl_гражданство.TabIndex = 17;
            this.lbl_гражданство.Text = "Ошибка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(150, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Гражданство";
            // 
            // lbl_телефон
            // 
            this.lbl_телефон.AutoSize = true;
            this.lbl_телефон.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_телефон.Location = new System.Drawing.Point(150, 243);
            this.lbl_телефон.Name = "lbl_телефон";
            this.lbl_телефон.Size = new System.Drawing.Size(73, 19);
            this.lbl_телефон.TabIndex = 15;
            this.lbl_телефон.Text = "Ошибка";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(150, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Телефон";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(150, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "Дата приёма";
            // 
            // lbl_датаПриёма
            // 
            this.lbl_датаПриёма.AutoSize = true;
            this.lbl_датаПриёма.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_датаПриёма.Location = new System.Drawing.Point(150, 205);
            this.lbl_датаПриёма.Name = "lbl_датаПриёма";
            this.lbl_датаПриёма.Size = new System.Drawing.Size(73, 19);
            this.lbl_датаПриёма.TabIndex = 12;
            this.lbl_датаПриёма.Text = "Ошибка";
            // 
            // lbl_снилс
            // 
            this.lbl_снилс.AutoSize = true;
            this.lbl_снилс.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_снилс.Location = new System.Drawing.Point(150, 367);
            this.lbl_снилс.Name = "lbl_снилс";
            this.lbl_снилс.Size = new System.Drawing.Size(73, 19);
            this.lbl_снилс.TabIndex = 21;
            this.lbl_снилс.Text = "Ошибка";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(150, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 19);
            this.label13.TabIndex = 20;
            this.label13.Text = "СНИЛС";
            // 
            // lbl_ИНН
            // 
            this.lbl_ИНН.AutoSize = true;
            this.lbl_ИНН.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ИНН.Location = new System.Drawing.Point(150, 329);
            this.lbl_ИНН.Name = "lbl_ИНН";
            this.lbl_ИНН.Size = new System.Drawing.Size(73, 19);
            this.lbl_ИНН.TabIndex = 19;
            this.lbl_ИНН.Text = "Ошибка";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(150, 312);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 19);
            this.label15.TabIndex = 18;
            this.label15.Text = "ИНН";
            // 
            // lbl_IDInfo
            // 
            this.lbl_IDInfo.AutoSize = true;
            this.lbl_IDInfo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_IDInfo.Location = new System.Drawing.Point(150, 9);
            this.lbl_IDInfo.Name = "lbl_IDInfo";
            this.lbl_IDInfo.Size = new System.Drawing.Size(26, 19);
            this.lbl_IDInfo.TabIndex = 23;
            this.lbl_IDInfo.Text = "ID";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ID.Location = new System.Drawing.Point(150, 30);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(73, 19);
            this.lbl_ID.TabIndex = 22;
            this.lbl_ID.Text = "Ошибка";
            // 
            // txtbx_снилс
            // 
            this.txtbx_снилс.Location = new System.Drawing.Point(154, 368);
            this.txtbx_снилс.Name = "txtbx_снилс";
            this.txtbx_снилс.Size = new System.Drawing.Size(131, 22);
            this.txtbx_снилс.TabIndex = 24;
            this.txtbx_снилс.Visible = false;
            // 
            // txtbx_ФИО
            // 
            this.txtbx_ФИО.Enabled = false;
            this.txtbx_ФИО.Location = new System.Drawing.Point(153, 73);
            this.txtbx_ФИО.Name = "txtbx_ФИО";
            this.txtbx_ФИО.Size = new System.Drawing.Size(186, 22);
            this.txtbx_ФИО.TabIndex = 26;
            this.txtbx_ФИО.Visible = false;
            // 
            // txtbx_паспорт
            // 
            this.txtbx_паспорт.Location = new System.Drawing.Point(153, 116);
            this.txtbx_паспорт.Name = "txtbx_паспорт";
            this.txtbx_паспорт.Size = new System.Drawing.Size(132, 22);
            this.txtbx_паспорт.TabIndex = 27;
            this.txtbx_паспорт.Visible = false;
            // 
            // txtbx_номертрудовой
            // 
            this.txtbx_номертрудовой.Location = new System.Drawing.Point(153, 159);
            this.txtbx_номертрудовой.Name = "txtbx_номертрудовой";
            this.txtbx_номертрудовой.Size = new System.Drawing.Size(131, 22);
            this.txtbx_номертрудовой.TabIndex = 28;
            this.txtbx_номертрудовой.Visible = false;
            // 
            // txtbx_телефон
            // 
            this.txtbx_телефон.Location = new System.Drawing.Point(153, 244);
            this.txtbx_телефон.Name = "txtbx_телефон";
            this.txtbx_телефон.Size = new System.Drawing.Size(131, 22);
            this.txtbx_телефон.TabIndex = 30;
            this.txtbx_телефон.Visible = false;
            // 
            // txtbx_ИНН
            // 
            this.txtbx_ИНН.Location = new System.Drawing.Point(154, 330);
            this.txtbx_ИНН.Name = "txtbx_ИНН";
            this.txtbx_ИНН.Size = new System.Drawing.Size(131, 22);
            this.txtbx_ИНН.TabIndex = 31;
            this.txtbx_ИНН.Visible = false;
            // 
            // txtbx_гражданство
            // 
            this.txtbx_гражданство.Location = new System.Drawing.Point(153, 287);
            this.txtbx_гражданство.Name = "txtbx_гражданство";
            this.txtbx_гражданство.Size = new System.Drawing.Size(131, 22);
            this.txtbx_гражданство.TabIndex = 32;
            this.txtbx_гражданство.Visible = false;
            // 
            // txtbx_ID
            // 
            this.txtbx_ID.Enabled = false;
            this.txtbx_ID.Location = new System.Drawing.Point(153, 27);
            this.txtbx_ID.Name = "txtbx_ID";
            this.txtbx_ID.Size = new System.Drawing.Size(131, 22);
            this.txtbx_ID.TabIndex = 34;
            this.txtbx_ID.Visible = false;
            // 
            // btn_saveChange
            // 
            this.btn_saveChange.BackgroundImage = global::company.Properties.Resources.signup;
            this.btn_saveChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_saveChange.Location = new System.Drawing.Point(444, 286);
            this.btn_saveChange.Name = "btn_saveChange";
            this.btn_saveChange.Size = new System.Drawing.Size(50, 50);
            this.btn_saveChange.TabIndex = 35;
            this.btn_saveChange.UseVisualStyleBackColor = true;
            this.btn_saveChange.Visible = false;
            this.btn_saveChange.Click += new System.EventHandler(this.btn_saveChange_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackgroundImage = global::company.Properties.Resources._94387;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit.Location = new System.Drawing.Point(444, 225);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(50, 50);
            this.btn_edit.TabIndex = 33;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::company.Properties.Resources.ReforgedBorder_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 127);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_addImage
            // 
            this.btn_addImage.BackgroundImage = global::company.Properties.Resources.angle;
            this.btn_addImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addImage.Location = new System.Drawing.Point(12, 145);
            this.btn_addImage.Name = "btn_addImage";
            this.btn_addImage.Size = new System.Drawing.Size(50, 50);
            this.btn_addImage.TabIndex = 4;
            this.btn_addImage.UseVisualStyleBackColor = true;
            this.btn_addImage.Click += new System.EventHandler(this.btn_addImage_Click);
            // 
            // pcr_Bx_сотрудник
            // 
            this.pcr_Bx_сотрудник.BackgroundImage = global::company.Properties.Resources.no_image;
            this.pcr_Bx_сотрудник.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcr_Bx_сотрудник.Location = new System.Drawing.Point(17, 17);
            this.pcr_Bx_сотрудник.Name = "pcr_Bx_сотрудник";
            this.pcr_Bx_сотрудник.Size = new System.Drawing.Size(122, 117);
            this.pcr_Bx_сотрудник.TabIndex = 3;
            this.pcr_Bx_сотрудник.TabStop = false;
            // 
            // txtbx_date
            // 
            this.txtbx_date.Location = new System.Drawing.Point(153, 206);
            this.txtbx_date.Name = "txtbx_date";
            this.txtbx_date.Size = new System.Drawing.Size(132, 22);
            this.txtbx_date.TabIndex = 29;
            this.txtbx_date.Visible = false;
            // 
            // Additional_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.btn_saveChange);
            this.Controls.Add(this.txtbx_ID);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txtbx_гражданство);
            this.Controls.Add(this.txtbx_ИНН);
            this.Controls.Add(this.txtbx_телефон);
            this.Controls.Add(this.txtbx_date);
            this.Controls.Add(this.txtbx_номертрудовой);
            this.Controls.Add(this.txtbx_паспорт);
            this.Controls.Add(this.txtbx_ФИО);
            this.Controls.Add(this.txtbx_снилс);
            this.Controls.Add(this.lbl_IDInfo);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_снилс);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbl_ИНН);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbl_гражданство);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_телефон);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_датаПриёма);
            this.Controls.Add(this.lbl_трудовая);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_паспорт);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ФИО);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_addImage);
            this.Controls.Add(this.pcr_Bx_сотрудник);
            this.Controls.Add(this.btn_AddAdditionalInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Additional_Info";
            this.Load += new System.EventHandler(this.Additional_Info_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addinfo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Bx_сотрудник)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_addinfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСтрокуToolStripMenuItem;
        private System.Windows.Forms.Button btn_AddAdditionalInfo;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.PictureBox pcr_Bx_сотрудник;
        private System.Windows.Forms.Button btn_addImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_ФИО;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_паспорт;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_трудовая;
        private System.Windows.Forms.Label lbl_гражданство;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_телефон;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_датаПриёма;
        private System.Windows.Forms.Label lbl_снилс;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_ИНН;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_IDInfo;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txtbx_снилс;
        private System.Windows.Forms.TextBox txtbx_ФИО;
        private System.Windows.Forms.TextBox txtbx_паспорт;
        private System.Windows.Forms.TextBox txtbx_номертрудовой;
        private System.Windows.Forms.TextBox txtbx_телефон;
        private System.Windows.Forms.TextBox txtbx_ИНН;
        private System.Windows.Forms.TextBox txtbx_гражданство;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txtbx_ID;
        private System.Windows.Forms.Button btn_saveChange;
        private System.Windows.Forms.TextBox txtbx_date;
    }
}