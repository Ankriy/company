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
    public partial class Password2 : Form
    {
        public Password2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_password2_Click(object sender, EventArgs e)
        {
            btn_passwordvoid();
        }


        private void btn_passwordvoid()
        {
            if (txtbx_password2.Text.ToString() == "999")
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }

        private void txtbx_password2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_passwordvoid();
            }
        }
    }
}
