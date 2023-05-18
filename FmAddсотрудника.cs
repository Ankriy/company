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
    public partial class FmAddсотрудника : Form
    {
        DAL dal = new DAL();
        workscreenUser wsu = new workscreenUser();
        
        public FmAddсотрудника()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            
            for(int i=0;i<wsu.al.Count;i++)
                cmbBx_Отдел.Items.Add(wsu.al[i]);
            for (int i = 0; i < wsu.al2.Count; i++)
                cmbBx_Должность.Items.Add(wsu.al2[i]);

            cmbBx_Должность.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBx_Отдел.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBx_Должность.FlatStyle = FlatStyle.Popup;
            cmbBx_Отдел.FlatStyle = FlatStyle.Popup;

            button1.FlatStyle = FlatStyle.Popup;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dal.SaveNewWorker(txtbx_фио.Text, txtbx_пол.Text, Convert.ToDateTime(txtbx_др.Text), txtbx_адрес.Text, txtbx_сп.Text,
                    txtbx_Образование.Text, txtbx_спец.Text, txtbx_диплом.Text, Convert.ToInt32(txtbx_ор.Text),
                    Convert.ToInt32(wsu.alотдел[cmbBx_Отдел.SelectedIndex]), Convert.ToInt32(wsu.alдолжность[cmbBx_Должность.SelectedIndex])))   //listBox1.SelectedIndex
                    this.DialogResult = DialogResult.OK;
                else
                    this.DialogResult = DialogResult.No;
            }
            catch
            {
                
                 this.DialogResult = DialogResult.No;
            }
            
        }

        private void txtbx_фио_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtbx_пол.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                txtbx_адрес.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                txtbx_пол.Focus();
            }
        }
        private void txtbx_пол_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtbx_фио.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                txtbx_др.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                txtbx_сп.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                txtbx_др.Focus();
            }
        }
        private void txtbx_др_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtbx_пол.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                txtbx_Образование.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                txtbx_адрес.Focus();
            }
        }

        private void txtbx_Образование_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtbx_сп.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                txtbx_ор.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                txtbx_др.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                txtbx_спец.Focus();
            }
        }

        private void txtbx_сп_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtbx_адрес.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                txtbx_Образование.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                txtbx_диплом.Focus();
            }
            if(e.KeyCode == Keys.Left)
            {
                txtbx_пол.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                txtbx_Образование.Focus();
            }
        }
        private void txtbx_адрес_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtbx_сп.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                txtbx_спец.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                txtbx_фио.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                txtbx_сп.Focus();
            }
        }
        private void txtbx_спец_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Down)
            {
                txtbx_диплом.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                cmbBx_Отдел.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                txtbx_адрес.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                txtbx_диплом.Focus();
            }
        }
        private void txtbx_диплом_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtbx_спец.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                txtbx_ор.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                cmbBx_Должность.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                txtbx_сп.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                txtbx_ор.Focus();
            }
        }

        private void txtbx_ор_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtbx_диплом.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                cmbBx_Должность.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                txtbx_Образование.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                cmbBx_Отдел.Focus();
            }
        }

        private void cmbBx_Отдел_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                txtbx_спец.Focus();
            }
        }

        private void cmbBx_Должность_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                txtbx_диплом.Focus();
            }
        }

        private void cmbBx_Отдел_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbBx_Должность.Focus();
            
        }
    }
}
