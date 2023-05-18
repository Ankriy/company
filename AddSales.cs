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
    public partial class AddSales : Form
    {
        DAL dal = new DAL();
        public ArrayList worker = new ArrayList();
        public ArrayList client = new ArrayList();
        public ArrayList service = new ArrayList();
        public AddSales()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void AddSales_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < worker.Count; i++)
                ltbx_Worker.Items.Add(worker[i]);
            for (int i = 0; i < client.Count; i++)
                ltbx_client.Items.Add(client[i]);
            for (int i = 0; i < service.Count; i++)
                ltbx_Услуги.Items.Add(service[i]);
        }

        private void btn_addNewSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (dal.AddSales(null/*ltbx_Worker.SelectedItem.ToString()*/, ltbx_client.SelectedItem.ToString(), ltbx_Услуги.SelectedItem.ToString().Trim(), 
                    Convert.ToDateTime(txtbx_date.Text.ToString())))
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
