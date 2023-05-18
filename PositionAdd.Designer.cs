
namespace company
{
    partial class PositionAdd
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
            this.btn_addPosition = new System.Windows.Forms.Button();
            this.txtbx_должность = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_addPosition
            // 
            this.btn_addPosition.Location = new System.Drawing.Point(50, 73);
            this.btn_addPosition.Name = "btn_addPosition";
            this.btn_addPosition.Size = new System.Drawing.Size(100, 33);
            this.btn_addPosition.TabIndex = 5;
            this.btn_addPosition.Text = "Добавить";
            this.btn_addPosition.UseVisualStyleBackColor = true;
            this.btn_addPosition.Click += new System.EventHandler(this.btn_addPosition_Click);
            // 
            // txtbx_должность
            // 
            this.txtbx_должность.Location = new System.Drawing.Point(30, 45);
            this.txtbx_должность.Name = "txtbx_должность";
            this.txtbx_должность.Size = new System.Drawing.Size(144, 22);
            this.txtbx_должность.TabIndex = 4;
            this.txtbx_должность.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_должность_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название должности";
            // 
            // PositionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 144);
            this.Controls.Add(this.btn_addPosition);
            this.Controls.Add(this.txtbx_должность);
            this.Controls.Add(this.label1);
            this.Name = "PositionAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addPosition;
        private System.Windows.Forms.TextBox txtbx_должность;
        private System.Windows.Forms.Label label1;
    }
}