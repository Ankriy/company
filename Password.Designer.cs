
namespace company
{
    partial class Password
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
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.btn_password = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_log = new System.Windows.Forms.TextBox();
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbx_password
            // 
            this.txtbx_password.Location = new System.Drawing.Point(15, 74);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.Size = new System.Drawing.Size(143, 22);
            this.txtbx_password.TabIndex = 0;
            this.txtbx_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_password_KeyDown);
            // 
            // btn_password
            // 
            this.btn_password.Location = new System.Drawing.Point(15, 114);
            this.btn_password.Name = "btn_password";
            this.btn_password.Size = new System.Drawing.Size(143, 43);
            this.btn_password.TabIndex = 1;
            this.btn_password.Text = "подтвердить";
            this.btn_password.UseVisualStyleBackColor = true;
            this.btn_password.Click += new System.EventHandler(this.btn_password_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Логин";
            // 
            // txtbx_log
            // 
            this.txtbx_log.Location = new System.Drawing.Point(15, 29);
            this.txtbx_log.Name = "txtbx_log";
            this.txtbx_log.Size = new System.Drawing.Size(143, 22);
            this.txtbx_log.TabIndex = 8;
            this.txtbx_log.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_log_KeyDown);
            // 
            // dgv_1
            // 
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Enabled = false;
            this.dgv_1.Location = new System.Drawing.Point(237, 44);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.RowHeadersWidth = 51;
            this.dgv_1.RowTemplate.Height = 24;
            this.dgv_1.Size = new System.Drawing.Size(81, 42);
            this.dgv_1.TabIndex = 12;
            this.dgv_1.Visible = false;
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(179, 174);
            this.Controls.Add(this.dgv_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_password);
            this.Controls.Add(this.txtbx_password);
            this.Name = "Password";
            this.Shown += new System.EventHandler(this.Password_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.Button btn_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_log;
        private System.Windows.Forms.DataGridView dgv_1;
    }
}