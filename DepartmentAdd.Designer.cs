
namespace company
{
    partial class DepartmentAdd
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
            this.txtbx_отдел = new System.Windows.Forms.TextBox();
            this.btn_addОтдел = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название Отдела";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbx_отдел
            // 
            this.txtbx_отдел.Location = new System.Drawing.Point(15, 46);
            this.txtbx_отдел.Name = "txtbx_отдел";
            this.txtbx_отдел.Size = new System.Drawing.Size(123, 22);
            this.txtbx_отдел.TabIndex = 1;
            this.txtbx_отдел.TextChanged += new System.EventHandler(this.txtbx_отдел_TextChanged);
            this.txtbx_отдел.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_отдел_KeyDown);
            // 
            // btn_addОтдел
            // 
            this.btn_addОтдел.Location = new System.Drawing.Point(26, 74);
            this.btn_addОтдел.Name = "btn_addОтдел";
            this.btn_addОтдел.Size = new System.Drawing.Size(100, 33);
            this.btn_addОтдел.TabIndex = 2;
            this.btn_addОтдел.Text = "Добавить";
            this.btn_addОтдел.UseVisualStyleBackColor = true;
            this.btn_addОтдел.Click += new System.EventHandler(this.btn_addОтдел_Click);
            // 
            // DepartmentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 128);
            this.Controls.Add(this.btn_addОтдел);
            this.Controls.Add(this.txtbx_отдел);
            this.Controls.Add(this.label1);
            this.Name = "DepartmentAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_отдел;
        private System.Windows.Forms.Button btn_addОтдел;
    }
}