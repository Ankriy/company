
namespace company
{
    partial class AddУслуги
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
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_services = new System.Windows.Forms.TextBox();
            this.txtbx_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_гарантия = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(149, 119);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 45);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Добавить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Услуга";
            // 
            // txtbx_services
            // 
            this.txtbx_services.Location = new System.Drawing.Point(40, 68);
            this.txtbx_services.Name = "txtbx_services";
            this.txtbx_services.Size = new System.Drawing.Size(100, 22);
            this.txtbx_services.TabIndex = 2;
            this.txtbx_services.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_services_KeyDown);
            // 
            // txtbx_price
            // 
            this.txtbx_price.Location = new System.Drawing.Point(149, 67);
            this.txtbx_price.Name = "txtbx_price";
            this.txtbx_price.Size = new System.Drawing.Size(100, 22);
            this.txtbx_price.TabIndex = 4;
            this.txtbx_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_price_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цена";
            // 
            // txtbx_гарантия
            // 
            this.txtbx_гарантия.Location = new System.Drawing.Point(258, 67);
            this.txtbx_гарантия.Name = "txtbx_гарантия";
            this.txtbx_гарантия.Size = new System.Drawing.Size(100, 22);
            this.txtbx_гарантия.TabIndex = 6;
            this.txtbx_гарантия.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_гарантия_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Гарантия, месяцев";
            // 
            // AddУслуги
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 211);
            this.Controls.Add(this.txtbx_гарантия);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_services);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Name = "AddУслуги";
            this.Load += new System.EventHandler(this.AddУслуги_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_services;
        private System.Windows.Forms.TextBox txtbx_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_гарантия;
        private System.Windows.Forms.Label label3;
    }
}