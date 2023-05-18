using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace company
{
    public partial class Password : Form
    {
        
        public Password()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            txtbx_password.UseSystemPasswordChar = true;
            


        }

        private void btn_password_Click(object sender, EventArgs e)
        {
            btn_passwordvoid();
        }
        private void txtbx_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_passwordvoid();
            }
            if (e.KeyCode == Keys.Up)
                txtbx_log.Focus();
        }
        private void txtbx_log_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtbx_password.Focus();
            if (e.KeyCode == Keys.Down)
                txtbx_password.Focus();
        }
        //public int users;
        private void btn_passwordvoid()
        {
            Pas.log = txtbx_log.Text;
            Pas.password = txtbx_password.Text;
            DAL dal = new DAL();
            if (!dal.password())
            {
                this.DialogResult = DialogResult.No;
            }
            else
                this.DialogResult = DialogResult.OK;


            //if (!(dal.password(txtbx_log.Text, txtbx_password.Text).Count == 0))
            //{
            //    dgv_1.DataSource = dal.password(txtbx_log.Text, txtbx_password.Text);
            //    if (dgv_1[0, 0].Value.ToString() == "user")
            //    {
            //        users = 1;
            //    }
            //    if(dgv_1[0, 0].Value.ToString() == "admin")
            //    {
            //        users = 2;
            //    }
            //    this.DialogResult = DialogResult.OK;
            //}
            //else
            //    this.DialogResult = DialogResult.No;
        }

        private void Password_Shown(object sender, EventArgs e)
        {
            txtbx_log.Focus();
        }
    }
}
