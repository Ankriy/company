using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace company
{
    public partial class Additional_Info : Form
    {
        DAL dal = new DAL();
        workscreenUser wsu = new workscreenUser();
        public bool info = new bool();
        public int IDсотрудник = new int();
        public ArrayList alФИОAddedСотрудник = new ArrayList();
        public Additional_Info()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dgv_addinfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_addinfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_addinfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            load_dgv();

            pcr_Bx_сотрудник.BackgroundImageLayout = ImageLayout.Stretch;
            pcr_Bx_сотрудник.BringToFront();

        }

        private void load_dgv()
        {
            if (info == true)
            {
                dgv_addinfo.DataSource = dal.GetWorkerAddInfo(IDсотрудник);
                if (dgv_addinfo.Rows.Count == 0)
                    if (MessageBox.Show("Нет дополнительной информации о сотруднике", "Admin",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                        this.Close();
                if (!(dgv_addinfo.Rows.Count == 0))
                {
                    dgv_addinfo.Columns["ID"].Visible = false;              //скрываем колонку
                    dgv_addinfo.Columns["Фото"].Visible = false;         //contextMenuStrip1.Items[1].Enabled = false;
                    dgv_addinfo.Visible = false;
                    groupBox1.Visible = false;

                    this.Height = 380;
                    this.Width = 400;
                    btn_AddAdditionalInfo.Visible = false;
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                }
            }
            else
            {
                
                dgv_addinfo.DataSource = dal.GetAllWorkerAddInfo();
                if (!(dgv_addinfo.Rows.Count == 0))
                {
                    dgv_addinfo.Columns[0].Visible = false;
                    dgv_addinfo.Columns[2].Visible = false;
                    dgv_addinfo.Columns[3].Visible = false;
                    dgv_addinfo.Columns[4].Visible = false;
                    dgv_addinfo.Columns[5].Visible = false;
                    dgv_addinfo.Columns[6].Visible = false;
                    dgv_addinfo.Columns[7].Visible = false;
                    dgv_addinfo.Columns[8].Visible = false;
                    dgv_addinfo.Columns["Фото"].Visible = false;
                }
                

            }
            for (int i = 0; i < dgv_addinfo.Rows.Count; i++)
            {
                alФИОAddedСотрудник.Add(dgv_addinfo[1, i].Value);
            }
        }

        private void Additional_Info_Load(object sender, EventArgs e)
        {
            load_dgv();
        }
        
        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Additional_InfoChangeCell adInCh = new Additional_InfoChangeCell();
            adInCh.NameColumn = dgv_addinfo.Columns[point.X].Name;
            //добавить [] в начало и конец
            adInCh.NameColumn = "[" + adInCh.NameColumn + "]";

            adInCh.ID = int.Parse(dgv_addinfo[0, point.Y].Value.ToString());
            if (adInCh.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Запись изменена", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                //dgv_сотрудники.DataSource = dal.GetAllWorker();
                checkBool();
            }
            else
                MessageBox.Show("Не получилось изменить", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

        }
        Point point = new Point();
        private void dgv_addinfo_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            point.X = e.ColumnIndex; point.Y = e.RowIndex;
        }

        private void удалитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgv_addinfo.Rows[point.Y].Index;
            int rowID = int.Parse(dgv_addinfo[0, selectedIndex].Value.ToString());

            if (MessageBox.Show("Подтвердите удаление строки", "Admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                if (dal.DeleteAdditionalInfo(rowID))
                    checkBool();
            }
        }
        private void checkBool()
        {
            if (info == true)
            {
                dgv_addinfo.DataSource = dal.GetWorkerAddInfo(IDсотрудник);
            }
            else
            {
                dgv_addinfo.DataSource = dal.GetAllWorkerAddInfo();
            }
        }
        private void btn_AddAdditionalInfo_Click(object sender, EventArgs e)
        {
            AddAdditionalInfo aai = new AddAdditionalInfo();
            if (aai.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Добавлена дополнительная информация", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                checkBool();
            }
            else
                MessageBox.Show("Не получилось добавить дополнительную информацию", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_addinfo.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    Clipboard.SetDataObject(dgv_addinfo[point.X, point.Y].EditedFormattedValue);//GetClipboardContent()
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    MessageBox.Show("Копирование невозможно");
                }
            }
        }

        private void btn_addImage_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgv_addinfo.CurrentRow.Index;
            int rowID = int.Parse(dgv_addinfo[0, selectedIndex].Value.ToString());
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            MemoryStream Memostr = new MemoryStream();
            Image Img = Image.FromFile(filename);
            Img.Save(Memostr, Img.RawFormat);
            byte[] arrayimg2 = Memostr.ToArray();
            //Convert.ToBase64String(arrayimg2);
            dal.UpdatePhoto(Convert.ToBase64String(arrayimg2), rowID);
            load_dgv();

        }
        private void lbl_addInfo(int selectedIndex)
        {
            lbl_ID.Text = dgv_addinfo["ID", selectedIndex].Value.ToString();
            lbl_ФИО.Text = dgv_addinfo["ФИО", selectedIndex].Value.ToString();
            lbl_паспорт.Text = dgv_addinfo["НомерСерияПаспорта", selectedIndex].Value.ToString();
            lbl_трудовая.Text = dgv_addinfo["НомерТрудовойКнижки", selectedIndex].Value.ToString();
            lbl_датаПриёма.Text = ((DateTime)dgv_addinfo["Дата приёма на работу", selectedIndex].Value).ToShortDateString();
            lbl_телефон.Text = dgv_addinfo["Номер телефона", selectedIndex].Value.ToString();
            lbl_гражданство.Text = dgv_addinfo["Гражданство", selectedIndex].Value.ToString();
            lbl_ИНН.Text = dgv_addinfo["ИНН", selectedIndex].Value.ToString();
            lbl_снилс.Text = dgv_addinfo["СНИЛС", selectedIndex].Value.ToString();
        }
        private void lbl_addInfoFault()
        {
            lbl_ID.Text = " ";
            lbl_ФИО.Text = "Ошибка";
            lbl_паспорт.Text = " ";
            lbl_трудовая.Text = " ";
            lbl_датаПриёма.Text = " ";
            lbl_телефон.Text = " ";
            lbl_гражданство.Text = " ";
            lbl_ИНН.Text = " ";
            lbl_снилс.Text = " ";
        }

        private void dgv_addinfo_SelectionChanged(object sender, EventArgs e)
        {
            selectedIndex = dgv_addinfo.CurrentRow.Index;

            try
            {
                byte[] arrayimg = Convert.FromBase64String(dgv_addinfo["Фото", selectedIndex].Value.ToString());
                pcr_Bx_сотрудник.BackgroundImage = Image.FromStream(new MemoryStream(arrayimg));
            }
            catch
            {
                pcr_Bx_сотрудник.BackgroundImage = global::company.Properties.Resources.no_image;
            }
            try
            {
                lbl_addInfo(selectedIndex);
            }
            catch
            {
                lbl_addInfoFault();
            }
        }
        bool chekedtxtbx = true;
        int selectedIndex;
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (chekedtxtbx == true)
            {
                btn_edit.BackgroundImage = global::company.Properties.Resources.Cancel_icon_icons_com_55947;
                groupBox1.Enabled = false;
                btn_saveChange.Visible = true;
                btn_addImage.Enabled = false;
                btn_AddAdditionalInfo.Enabled = false;

                txtbx_ID.Visible = true;
                txtbx_ФИО.Visible = true;
                txtbx_паспорт.Visible = true;
                txtbx_номертрудовой.Visible = true;
                txtbx_date.Visible = true;
                txtbx_телефон.Visible = true;
                txtbx_гражданство.Visible = true;
                txtbx_ИНН.Visible = true;
                txtbx_снилс.Visible = true;

                txtbx_ID.Text = lbl_ID.Text;
                txtbx_ФИО.Text = lbl_ФИО.Text;
                txtbx_паспорт.Text = lbl_паспорт.Text;
                txtbx_номертрудовой.Text = lbl_трудовая.Text;
                txtbx_date.Text = lbl_датаПриёма.Text;
                txtbx_телефон.Text = lbl_телефон.Text;
                txtbx_гражданство.Text = lbl_гражданство.Text;
                txtbx_ИНН.Text = lbl_ИНН.Text;
                txtbx_снилс.Text = lbl_снилс.Text;

                lbl_addInfoFault();
                txtbx_снилс.Visible = true;
                chekedtxtbx = false;
            }
            else
            {
                btn_edit.BackgroundImage = global::company.Properties.Resources._94387;
                groupBox1.Enabled = true;
                btn_saveChange.Visible = false;
                btn_addImage.Enabled = true;
                btn_AddAdditionalInfo.Enabled = true;

                lbl_addInfo(selectedIndex);
                txtbx_ID.Visible = false;
                txtbx_ФИО.Visible = false;
                txtbx_паспорт.Visible = false;
                txtbx_номертрудовой.Visible = false;
                txtbx_date.Visible = false;
                txtbx_телефон.Visible = false;
                txtbx_гражданство.Visible = false;
                txtbx_ИНН.Visible = false;
                txtbx_снилс.Visible = false;

                chekedtxtbx = true;
            }
        }

        private void btn_saveChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (dal.UpdateAllAddInfo(txtbx_паспорт.Text, txtbx_номертрудовой.Text, Convert.ToDateTime(txtbx_date.Text), txtbx_телефон.Text,
                    txtbx_гражданство.Text, txtbx_ИНН.Text, txtbx_снилс.Text, Convert.ToInt32(txtbx_ID.Text)))
                {
                    MessageBox.Show("Запись изменена", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    dgv_addinfo.DataSource = dal.GetAllWorkerAddInfo();
                    btn_edit.BackgroundImage = global::company.Properties.Resources._94387;

                    btn_saveChange.Visible = false;
                    btn_addImage.Enabled = true;
                    btn_AddAdditionalInfo.Enabled = true;
                    groupBox1.Enabled = true;
                    lbl_addInfo(selectedIndex);
                    txtbx_ID.Visible = false;
                    txtbx_ФИО.Visible = false;
                    txtbx_паспорт.Visible = false;
                    txtbx_номертрудовой.Visible = false;
                    txtbx_date.Visible = false;
                    txtbx_телефон.Visible = false;
                    txtbx_гражданство.Visible = false;
                    txtbx_ИНН.Visible = false;
                    txtbx_снилс.Visible = false;
                    chekedtxtbx = true;

                }
                else
                    MessageBox.Show("Не получилось изменить", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch
            {
                MessageBox.Show("Не получилось изменить", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void dgv_addinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
