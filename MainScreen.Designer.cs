
namespace company
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.label2 = new System.Windows.Forms.Label();
            this.cbBx_1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_password = new System.Windows.Forms.Button();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.btn_свернуть = new System.Windows.Forms.Button();
            this.btn_resize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.SpringGreen;
            this.label2.Location = new System.Drawing.Point(12, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Выберите должность";
            this.label2.Visible = false;
            // 
            // cbBx_1
            // 
            this.cbBx_1.FormattingEnabled = true;
            this.cbBx_1.Location = new System.Drawing.Point(15, 374);
            this.cbBx_1.Name = "cbBx_1";
            this.cbBx_1.Size = new System.Drawing.Size(143, 24);
            this.cbBx_1.TabIndex = 11;
            this.cbBx_1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(12, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите пароль";
            this.label1.Visible = false;
            // 
            // btn_password
            // 
            this.btn_password.Location = new System.Drawing.Point(15, 533);
            this.btn_password.Name = "btn_password";
            this.btn_password.Size = new System.Drawing.Size(143, 43);
            this.btn_password.TabIndex = 9;
            this.btn_password.Text = "подтвердить";
            this.btn_password.UseVisualStyleBackColor = true;
            this.btn_password.Visible = false;
            // 
            // txtbx_password
            // 
            this.txtbx_password.Location = new System.Drawing.Point(15, 493);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.Size = new System.Drawing.Size(143, 22);
            this.txtbx_password.TabIndex = 8;
            this.txtbx_password.Visible = false;
            // 
            // btn_свернуть
            // 
            this.btn_свернуть.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_свернуть.BackgroundImage = global::company.Properties.Resources.icons8_свернуть_окно_100__1_;
            this.btn_свернуть.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_свернуть.Location = new System.Drawing.Point(920, 12);
            this.btn_свернуть.Name = "btn_свернуть";
            this.btn_свернуть.Size = new System.Drawing.Size(35, 35);
            this.btn_свернуть.TabIndex = 16;
            this.btn_свернуть.UseVisualStyleBackColor = true;
            this.btn_свернуть.Click += new System.EventHandler(this.btn_свернуть_Click);
            // 
            // btn_resize
            // 
            this.btn_resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_resize.BackgroundImage = global::company.Properties.Resources.icons8_развернуть_окно_100__1_;
            this.btn_resize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_resize.Location = new System.Drawing.Point(961, 12);
            this.btn_resize.Name = "btn_resize";
            this.btn_resize.Size = new System.Drawing.Size(35, 35);
            this.btn_resize.TabIndex = 15;
            this.btn_resize.UseVisualStyleBackColor = true;
            this.btn_resize.Click += new System.EventHandler(this.btn_resize_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackgroundImage = global::company.Properties.Resources.icons8_закрыть_окно_100__1_;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.Location = new System.Drawing.Point(1002, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 35);
            this.btn_close.TabIndex = 14;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackgroundImage = global::company.Properties.Resources._25888_removebg_preview;
            this.btn_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_2.Location = new System.Drawing.Point(681, 372);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(356, 102);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "директор";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Visible = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackgroundImage = global::company.Properties.Resources._25888_removebg_preview;
            this.btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_1.Location = new System.Drawing.Point(777, 480);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(260, 72);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "Войти";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::company.Properties.Resources.e2aec645e3f805bfeef5468bc9bf3a34;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.BackgroundImage = global::company.Properties.Resources.cogs_gears;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 592);
            this.Controls.Add(this.btn_свернуть);
            this.Controls.Add(this.btn_resize);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBx_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_password);
            this.Controls.Add(this.txtbx_password);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.Resize += new System.EventHandler(this.Screen_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBx_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_password;
        private System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_resize;
        private System.Windows.Forms.Button btn_свернуть;
    }
}