
namespace company
{
    partial class workscreenAdmin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_сотрудники = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_saveотделы = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_отделы = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_saveдолжности = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_должности = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_saveпродажи = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_продажи = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_saveуслуги = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgv_услуги = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_сотрудники)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_отделы)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_должности)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_продажи)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_услуги)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.ItemSize = new System.Drawing.Size(91, 21);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1402, 572);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.btn_open);
            this.tabPage3.Controls.Add(this.btn_save);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1394, 543);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Сотрудники";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1267, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(1231, 151);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(126, 88);
            this.btn_open.TabIndex = 5;
            this.btn_open.Text = "добавить данные из excel таблицы";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = global::company.Properties.Resources.export_83981;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.Location = new System.Drawing.Point(1231, 39);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(45, 41);
            this.btn_save.TabIndex = 3;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_сотрудники);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1197, 499);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dgv_сотрудники
            // 
            this.dgv_сотрудники.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_сотрудники.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_сотрудники.Location = new System.Drawing.Point(3, 18);
            this.dgv_сотрудники.Name = "dgv_сотрудники";
            this.dgv_сотрудники.RowHeadersVisible = false;
            this.dgv_сотрудники.RowHeadersWidth = 51;
            this.dgv_сотрудники.RowTemplate.Height = 24;
            this.dgv_сотрудники.Size = new System.Drawing.Size(1191, 478);
            this.dgv_сотрудники.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_saveотделы);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1394, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Отделы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_saveотделы
            // 
            this.btn_saveотделы.Location = new System.Drawing.Point(388, 24);
            this.btn_saveотделы.Name = "btn_saveотделы";
            this.btn_saveотделы.Size = new System.Drawing.Size(134, 77);
            this.btn_saveотделы.TabIndex = 2;
            this.btn_saveотделы.Text = "сохранить данные в файл";
            this.btn_saveотделы.UseVisualStyleBackColor = true;
            this.btn_saveотделы.Click += new System.EventHandler(this.btn_saveотделы_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_отделы);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 263);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgv_отделы
            // 
            this.dgv_отделы.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_отделы.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_отделы.Location = new System.Drawing.Point(3, 18);
            this.dgv_отделы.Name = "dgv_отделы";
            this.dgv_отделы.RowHeadersVisible = false;
            this.dgv_отделы.RowHeadersWidth = 51;
            this.dgv_отделы.RowTemplate.Height = 24;
            this.dgv_отделы.Size = new System.Drawing.Size(371, 242);
            this.dgv_отделы.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_saveдолжности);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1394, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Должности";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_saveдолжности
            // 
            this.btn_saveдолжности.Location = new System.Drawing.Point(430, 24);
            this.btn_saveдолжности.Name = "btn_saveдолжности";
            this.btn_saveдолжности.Size = new System.Drawing.Size(121, 72);
            this.btn_saveдолжности.TabIndex = 3;
            this.btn_saveдолжности.Text = "сохранить данные в файл";
            this.btn_saveдолжности.UseVisualStyleBackColor = true;
            this.btn_saveдолжности.Click += new System.EventHandler(this.btn_saveдолжности_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_должности);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 272);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // dgv_должности
            // 
            this.dgv_должности.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_должности.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_должности.Location = new System.Drawing.Point(3, 18);
            this.dgv_должности.Name = "dgv_должности";
            this.dgv_должности.RowHeadersVisible = false;
            this.dgv_должности.RowHeadersWidth = 51;
            this.dgv_должности.RowTemplate.Height = 24;
            this.dgv_должности.Size = new System.Drawing.Size(413, 251);
            this.dgv_должности.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_saveпродажи);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1394, 543);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Продажи";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_saveпродажи
            // 
            this.btn_saveпродажи.Location = new System.Drawing.Point(456, 21);
            this.btn_saveпродажи.Name = "btn_saveпродажи";
            this.btn_saveпродажи.Size = new System.Drawing.Size(125, 91);
            this.btn_saveпродажи.TabIndex = 4;
            this.btn_saveпродажи.Text = "сохранить данные в файл";
            this.btn_saveпродажи.UseVisualStyleBackColor = true;
            this.btn_saveпродажи.Click += new System.EventHandler(this.btn_saveпродажи_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_продажи);
            this.groupBox4.Location = new System.Drawing.Point(8, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(442, 324);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // dgv_продажи
            // 
            this.dgv_продажи.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_продажи.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_продажи.Location = new System.Drawing.Point(3, 18);
            this.dgv_продажи.Name = "dgv_продажи";
            this.dgv_продажи.RowHeadersVisible = false;
            this.dgv_продажи.RowHeadersWidth = 51;
            this.dgv_продажи.RowTemplate.Height = 24;
            this.dgv_продажи.Size = new System.Drawing.Size(436, 303);
            this.dgv_продажи.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_saveуслуги);
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1394, 543);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Услуги";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_saveуслуги
            // 
            this.btn_saveуслуги.Location = new System.Drawing.Point(499, 21);
            this.btn_saveуслуги.Name = "btn_saveуслуги";
            this.btn_saveуслуги.Size = new System.Drawing.Size(153, 63);
            this.btn_saveуслуги.TabIndex = 5;
            this.btn_saveуслуги.Text = "сохранить данные в файл";
            this.btn_saveуслуги.UseVisualStyleBackColor = true;
            this.btn_saveуслуги.Click += new System.EventHandler(this.btn_saveуслуги_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgv_услуги);
            this.groupBox5.Location = new System.Drawing.Point(8, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(488, 328);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // dgv_услуги
            // 
            this.dgv_услуги.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_услуги.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_услуги.Location = new System.Drawing.Point(3, 18);
            this.dgv_услуги.Name = "dgv_услуги";
            this.dgv_услуги.RowHeadersVisible = false;
            this.dgv_услуги.RowHeadersWidth = 51;
            this.dgv_услуги.RowTemplate.Height = 24;
            this.dgv_услуги.Size = new System.Drawing.Size(482, 307);
            this.dgv_услуги.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1426, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.импортироватьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // импортироватьToolStripMenuItem
            // 
            this.импортироватьToolStripMenuItem.Name = "импортироватьToolStripMenuItem";
            this.импортироватьToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.импортироватьToolStripMenuItem.Text = "Экспортировать все таблицы";
            this.импортироватьToolStripMenuItem.Click += new System.EventHandler(this.экспортироватьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пмToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // пмToolStripMenuItem
            // 
            this.пмToolStripMenuItem.Name = "пмToolStripMenuItem";
            this.пмToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.пмToolStripMenuItem.Text = "пм";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // workscreenAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 623);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "workscreenAdmin";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_сотрудники)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_отделы)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_должности)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_продажи)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_услуги)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_сотрудники;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_saveотделы;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_отделы;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_saveдолжности;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_должности;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_saveпродажи;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_продажи;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btn_saveуслуги;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgv_услуги;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}