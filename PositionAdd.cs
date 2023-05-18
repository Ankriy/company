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
    public partial class PositionAdd : Form
    {
        DAL dal = new DAL();
        public PositionAdd()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void addposit()
        {
            if (dal.AddPosition(txtbx_должность.Text.ToString()))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }
        private void btn_addPosition_Click(object sender, EventArgs e)
        {
            addposit();
        }

        private void txtbx_должность_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addposit();
        }
    }
}
