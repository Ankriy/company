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
    public partial class AddУслуги : Form
    {
        DAL dal = new DAL();
        public AddУслуги()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AddУслуги_Load(object sender, EventArgs e)
        {

        }
        private void save()
        {
            try
            {
                if (dal.AddServices(txtbx_services.Text.ToString(), Convert.ToInt32(txtbx_price.Text), Convert.ToInt32(txtbx_гарантия.Text)))
                    this.DialogResult = DialogResult.OK;
                else
                    this.DialogResult = DialogResult.No;
            }
            catch
            {
                this.DialogResult = DialogResult.No;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            save();
        }

        private void txtbx_services_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                txtbx_price.Focus();
        }

        private void txtbx_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                txtbx_гарантия.Focus();
            if (e.KeyCode == Keys.Left)
                txtbx_services.Focus();
        }

        private void txtbx_гарантия_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                txtbx_price.Focus();
            if (e.KeyCode == Keys.Enter)
                save();
        }
    }
}
