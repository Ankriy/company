using System;
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
    public partial class AddКлиенты : Form
    {
        DAL dal = new DAL();
        public AddКлиенты()
        {
            InitializeComponent();
        }

        private void save()
        {
            if (dal.AddClient(txtbx_ФИО.Text.ToString(), Convert.ToDateTime(txtbx_date.Text), txtbx_phone.Text.ToString()))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            save();
        }

        private void txtbx_ФИО_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                txtbx_date1.Focus();
        }

        private void txtbx_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                txtbx_phone.Focus();
            if (e.KeyCode == Keys.Left)
                txtbx_ФИО.Focus();
        }

        private void txtbx_phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                txtbx_date1.Focus();
            if (e.KeyCode == Keys.Enter)
                save();
        }
    }
}
