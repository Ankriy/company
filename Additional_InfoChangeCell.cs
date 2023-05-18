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
    public partial class Additional_InfoChangeCell : Form
    {
        DAL dal = new DAL();
        public string NameColumn;
        public int ID;
        public Additional_InfoChangeCell()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            save();
        }
        private void save()
        {
            if (dal.Additional_Info_ChangeCell(NameColumn, txtbx_1.Text, ID))
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }
        private void txtbx_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                save();
            }
        }
    }
}
