
namespace company
{
    partial class Password2
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
            this.btn_password2 = new System.Windows.Forms.Button();
            this.txtbx_password2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_password2
            // 
            this.btn_password2.Location = new System.Drawing.Point(116, 83);
            this.btn_password2.Name = "btn_password2";
            this.btn_password2.Size = new System.Drawing.Size(143, 43);
            this.btn_password2.TabIndex = 3;
            this.btn_password2.Text = "подтвердить";
            this.btn_password2.UseVisualStyleBackColor = true;
            this.btn_password2.Click += new System.EventHandler(this.btn_password2_Click);
            // 
            // txtbx_password2
            // 
            this.txtbx_password2.Location = new System.Drawing.Point(116, 43);
            this.txtbx_password2.Name = "txtbx_password2";
            this.txtbx_password2.Size = new System.Drawing.Size(147, 22);
            this.txtbx_password2.TabIndex = 2;
            this.txtbx_password2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_password2_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите пароль";
            // 
            // Password2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 169);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_password2);
            this.Controls.Add(this.txtbx_password2);
            this.Name = "Password2";
            this.Text = "Password2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_password2;
        private System.Windows.Forms.TextBox txtbx_password2;
        private System.Windows.Forms.Label label1;
    }
}