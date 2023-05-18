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
    public partial class DismissWorker : Form
    {
        DAL dal = new DAL();
        public int ID;
        public string ФИО;
        public string Отдел;
        public string Должность;
        public int отдел;
        public int должность;
        public DismissWorker()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btn_dismissworker_Click(object sender, EventArgs e)
        {
            try
            {
                if (dal.AddDismissWorker(ID, ФИО, отдел, должность, txtbx_article.Text, txtbx_cause.Text, Convert.ToDateTime(txtbx_date.Text)))
                {
                    dal.UpdateSales(ID);
                    this.DialogResult = DialogResult.OK;
                }
                else
                    this.DialogResult = DialogResult.No;
            }
            catch
            {
                this.DialogResult = DialogResult.No;
            }
        }

        private void DismissWorker_Load(object sender, EventArgs e)
        {
            txtbx_ID.Enabled = false; txtbx_ID.Text = ID.ToString();
            txtbx_ФИО.Enabled = false; txtbx_ФИО.Text = ФИО;
            txtbx_отдел.Enabled = false; txtbx_отдел.Text = Отдел.ToString();
            txtbx_должность.Enabled = false; txtbx_должность.Text = Должность.ToString();
        }

        private void txtbx_article_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtbx_cause.Focus();
            if (e.KeyCode == Keys.Down)
                txtbx_cause.Focus();
        }

        private void txtbx_cause_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtbx_date.Focus();
            if (e.KeyCode == Keys.Up)
                txtbx_article.Focus();
            if (e.KeyCode == Keys.Down)
                txtbx_date.Focus();
        }

        private void txtbx_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                txtbx_cause.Focus();
        }
    }
}
