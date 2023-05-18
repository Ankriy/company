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
    public partial class DepartmentAdd : Form
    {
        DAL dal = new DAL();
        public DepartmentAdd()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_addОтдел_Click(object sender, EventArgs e)
        {
            addDep();
        }
        private void addDep()
        {
            if (dal.AddDepartments(txtbx_отдел.Text.ToString()))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }
        private void txtbx_отдел_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addDep();
        }

        private void txtbx_отдел_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
