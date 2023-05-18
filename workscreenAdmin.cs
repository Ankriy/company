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
    public partial class workscreenAdmin : Form
    {
        DAL dal = new DAL();
        public workscreenAdmin()
        {
            InitializeComponent();

            dgv_сотрудники.DataSource = dal.GetAllWorker();
            dgv_отделы.DataSource = dal.GetAllDepartments();
            dgv_должности.DataSource = dal.GetAllPositions();
            dgv_продажи.DataSource = dal.GetAllSales();
            dgv_услуги.DataSource = dal.GetAllServices();

            this.StartPosition = FormStartPosition.CenterScreen;

            dgv_сотрудники.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_отделы.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_должности.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_продажи.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_услуги.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            saveFileDialog1.Filter = "Text files(*.csv)|*.csv|All files(*.*)|*.*";

        }

        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0); //закрытие прилежения полностью при нажатии на крестик
        }
        int num = new int();
        private void button1_Click(object sender, EventArgs e)
        {
            num = 1;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            //ds.WriteXml(filename);
            //ds.WriteXmlSchema("DSschema.xsd");
            if (dal.SaveBD(filename, num))
                MessageBox.Show("Данные БД были успешно сохранены", "Bank meneger", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Данные БД не были сохранены", "Bank meneger", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void btn_open_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            //dgv_должности.DataSource = System.IO.File.rea (filename);
            //ds.ReadXml(filename);

        }
        private void btn_saveотделы_Click(object sender, EventArgs e)
        {
            num = 2;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            if (dal.SaveBD(filename, num))
                MessageBox.Show("Данные БД были успешно сохранены", "Bank meneger", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Данные БД не были сохранены", "Bank meneger", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void btn_saveдолжности_Click(object sender, EventArgs e)
        {
            num = 3;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            if (dal.SaveBD(filename, num))
                MessageBox.Show("Данные БД были успешно сохранены", "Bank meneger", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Данные БД не были сохранены", "Bank meneger", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
        private void btn_saveпродажи_Click(object sender, EventArgs e)
        {
            num = 4;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            if (dal.SaveBD(filename, num))
                MessageBox.Show("Данные БД были успешно сохранены", "Bank meneger", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Данные БД не были сохранены", "Bank meneger", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void btn_saveуслуги_Click(object sender, EventArgs e)
        {
            num = 5;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            if (dal.SaveBD(filename, num))
                MessageBox.Show("Данные БД были успешно сохранены", "Bank meneger", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Данные БД не были сохранены", "Bank meneger", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void экспортироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dal.SaveAllBD())
                MessageBox.Show("Данные БД были успешно сохранены", "Bank meneger", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Данные БД не были сохранены", "Bank meneger", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

        }
    }
}
