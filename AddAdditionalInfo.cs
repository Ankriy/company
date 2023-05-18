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
    public partial class AddAdditionalInfo : Form
    {
        DAL dal = new DAL();
        workscreenUser wsu = new workscreenUser();
        Additional_Info ai = new Additional_Info();
        ArrayList alСотрудник = new ArrayList();
        public AddAdditionalInfo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            alСотрудник = wsu.alФИОСотрудники;
            
            for (int i = 0; i < wsu.alФИОСотрудники.Count; i++)
            {

                for (int j = 0; j < ai.alФИОAddedСотрудник.Count; j++)
                {
                    if (wsu.alФИОСотрудники[i].ToString() == ai.alФИОAddedСотрудник[j].ToString())
                    {
                        alСотрудник.Remove(wsu.alФИОСотрудники[i]);
                    }
                }
            }
            for (int i = 0; i < alСотрудник.Count; i++)
                ltbx_Сотрудники.Items.Add(alСотрудник[i]);

        }

        private void txtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8)) //!=8 чтобы работала кнопка стирания
                e.Handled = true;
            
        }

        private void txtbx_numpas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtbx_numtrud.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                txtbx_numtrud.Focus();
            }
        }

        private void txtbx_numtrud_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtbx_date1.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                txtbx_numpas.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                txtbx_date1.Focus();
            }
        }

        private void txtbx_date_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtbx_phone.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                txtbx_numtrud.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                txtbx_phone.Focus();
            }
        }

        private void txtbx_phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtbx_гражданство.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                txtbx_date1.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                txtbx_гражданство.Focus();
            }
        }

        private void txtbx_гражданство_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtbx_ИНН.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                txtbx_phone.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                txtbx_ИНН.Focus();
            }
        }

        private void txtbx_ИНН_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtbx_снилс.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                txtbx_гражданство.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                txtbx_снилс.Focus();
            }
        }

        private void txtbx_снилс_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtbx_ИНН.Focus();
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtbx_date1.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (dal.SaveAdditionalInfo(ltbx_Сотрудники.SelectedItem.ToString(), txtbx_numpas.Text, txtbx_numtrud.Text, Convert.ToDateTime(txtbx_date.Text),
                    txtbx_phone.Text, txtbx_гражданство.Text, txtbx_ИНН.Text, txtbx_снилс.Text))
                    this.DialogResult = DialogResult.OK;
                else
                    this.DialogResult = DialogResult.No;
            }
            catch
            {
                this.DialogResult = DialogResult.No;
            }
        }
    }
}
