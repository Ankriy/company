using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Drawing.Printing;

namespace company
{
    public partial class workscreenUser : Form
    {
        DAL dal = new DAL();
        public ArrayList al = new ArrayList();
        public ArrayList al2 = new ArrayList();
        public ArrayList alотдел = new ArrayList();
        public ArrayList alдолжность = new ArrayList();
        public ArrayList alФИОСотрудники = new ArrayList();
        public ArrayList alDepartmentOfSales = new ArrayList();
        public ArrayList alClientsForSales = new ArrayList();
        public ArrayList alServiceForSales = new ArrayList();
        //public List<object> al = new List<object>();

        public string PathPicture1 = Application.StartupPath;
        public string PathPicture2 = Application.StartupPath;

        //public int users = 1;
        public workscreenUser()
        {
            InitializeComponent();

            //dgv_сотрудники.ReadOnly = false;
            dgv_сотрудники.DataSource = dal.GetAllWorker();
            dgv_отделы.DataSource = dal.GetAllDepartments();
            dgv_должности.DataSource = dal.GetAllPositions();
            dgv_продажи.DataSource = dal.GetAllSales();
            dgv_услуги.DataSource = dal.GetAllServices();
            dgv_клиенты.DataSource = dal.GetAllClients();

            this.StartPosition = FormStartPosition.CenterScreen;

            TableProperties();

            saveFileDialog1.Filter = "Text files(*.csv)|*.csv|All files(*.*)|*.*";

            OtherProperties();

            AllArrayLists();

            PathPicture1 = PathPicture1.Replace("bin\\Debug", "Resources\\lru.jpg");
            PathPicture2 = PathPicture2.Replace("bin\\Debug", "Resources\\len.jpg");

            //cbBx_отдел.SelectedItem = "а";
            //dgv_сотрудники.Columns[0].Visible = false;

            
        }
        #region ArrayLists and settings dgv
        private void permissionUsers()
        {

            tabPage1.Parent = null;
            //tabPage5.Parent = null;
            tabPage3.Parent = null;
            btn_delateSale.Visible = false;
            btn_deleteКлиенты.Visible = false;
            btn_deleteУслуги.Visible = false;
            btn_addУслуги.Visible = false;
            btn_saveпродажи.Visible = false;
            btn_saveклиенты.Visible = false;
            btn_saveуслуги.Visible = false;

            графикиToolStripMenuItem.Visible = false;
            импортироватьToolStripMenuItem.Visible = false;


        }
        private void AllArrayLists()
        {
            int countrow = dgv_отделы.Rows.Count;
            for (int i = 0; i < countrow; i++)
            {
                al.Add(dgv_отделы[1, i].Value);
                cbBx_отдел.Items.Add(dgv_отделы[1, i].Value);
            }
            int countrow2 = dgv_должности.Rows.Count;
            for (int i = 0; i < countrow2; i++)
            {
                al2.Add(dgv_должности[1, i].Value);
                cbBx_должность.Items.Add(dgv_должности[1, i].Value);
            }
            for (int i = 0; i < dgv_отделы.Rows.Count; i++)
            {
                alотдел.Add(dgv_отделы[0, i].Value);
            }
            for (int i = 0; i < dgv_должности.Rows.Count; i++)
            {
                alдолжность.Add(dgv_должности[0, i].Value);
            }
            for (int i = 0; i < dgv_сотрудники.Rows.Count; i++)
            {
                alФИОСотрудники.Add(dgv_сотрудники[1, i].Value);
            }

            for (int i = 0; i < dgv_сотрудники.Rows.Count; i++)
            {
                if (dgv_сотрудники["Отдел", i].Value.ToString().Trim() == "Отдел продаж")
                    alDepartmentOfSales.Add(dgv_сотрудники[1, i].Value);
            }
            for (int i = 0; i < dgv_клиенты.Rows.Count; i++)
            {
                alClientsForSales.Add(dgv_клиенты[1, i].Value);
            }
            for (int i = 0; i < dgv_услуги.Rows.Count; i++)
            {
                alServiceForSales.Add(dgv_услуги[1, i].Value);
            }
        }
        private void OtherProperties()
        {
            cbBx_должность.Text = "Все";
            cbBx_должность.Items.Add("Все");
            cbBx_отдел.Text = "Все";
            cbBx_отдел.Items.Add("Все");
            cbBx_должность.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBx_отдел.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBx_должность.FlatStyle = FlatStyle.Popup;
            cbBx_отдел.FlatStyle = FlatStyle.Popup;
            cbBx_должность.SelectedIndex = 0;
            cbBx_отдел.SelectedIndex = 0;



            txtbx_ФИО.BorderStyle = BorderStyle.Fixed3D;
            tabPage3.BorderStyle = BorderStyle.Fixed3D;
        }
        private void TableProperties()
        {
            try
            {
                //dgv_сотрудники.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //dgv_сотрудники.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
                dgv_отделы.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_должности.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //dgv_продажи.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //dgv_услуги.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_клиенты.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgv_услуги.Columns[0].Width = 40;
                dgv_услуги.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_услуги.Columns[2].Width = 110;
                dgv_услуги.Font = new Font(" ", 12, FontStyle.Regular);

                dgv_продажи.Columns[0].Width = 40;
                dgv_продажи.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_продажи.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_продажи.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_продажи.Columns[4].Width = 70;
                //dgv_продажи.Font = new Font(" ", 12, FontStyle.Regular);

                dgv_сотрудники.Columns[0].Width = 40;
                dgv_сотрудники.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_сотрудники.Columns[2].Width = 45;
                dgv_сотрудники.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_сотрудники.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_сотрудники.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_сотрудники.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_сотрудники.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_сотрудники.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_сотрудники.Columns[9].Width = 45;

                dgv_сотрудники.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv_сотрудники.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



                //dgv_сотрудники.Columns[4].Width = 70;

                //dgv_сотрудники.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red ;
                dgv_сотрудники.BorderStyle = BorderStyle.Fixed3D;

                dgv_сотрудники.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgv_сотрудники.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgv_сотрудники.Columns[0].Visible = false;
                dgv_должности.Columns[0].Visible = false;
                dgv_отделы.Columns[0].Visible = false;
                dgv_сотрудники.Columns["Отдел"].Visible = false;
                dgv_сотрудники.Columns["Должность"].Visible = false;
                dgv_сотрудники.Columns["Опыт работы"].Visible = false;
                dgv_сотрудники.Columns["Специальность"].Visible = false;
                dgv_сотрудники.Columns["Диплом"].Visible = false;
                dgv_сотрудники.Columns["Образование"].Visible = false;
                dgv_сотрудники.Columns["Семейное положение"].Visible = false;
                dgv_сотрудники.Columns["Адрес"].Visible = false;
                dgv_сотрудники.Columns["Дата рождения"].Visible = false;
                dgv_сотрудники.Columns["Пол"].Visible = false;

            }
            catch
            {

            }
            try
            {


                dgv_услуги.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgv_услуги.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dgv_продажи.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgv_продажи.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgv_продажи.Columns[2].Visible = false;
            }

            catch
            {

            }
        }
        private void arraylistsотделы()
        {
            int countrow = dgv_отделы.Rows.Count;
            for (int i = 0; i < countrow; i++)
            {
                al.Add(dgv_отделы[1, i].Value);
                cbBx_отдел.Items.Add(dgv_отделы[1, i].Value);
            }
        }
        private void arraylistsдолжности()
        {
            int countrow2 = dgv_должности.Rows.Count;
            for (int i = 0; i < countrow2; i++)
            {
                al2.Add(dgv_должности[1, i].Value);
                cbBx_должность.Items.Add(dgv_должности[1, i].Value);
            }
        }
        private void forAddSales()
        {
            for (int i = 0; i < dgv_сотрудники.Rows.Count; i++)
            {
                if (dgv_сотрудники["Отдел", i].Value.ToString() == "Отдел продаж")
                    alDepartmentOfSales.Add(dgv_сотрудники[1, i].Value);
            }
        }
        #endregion
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0); //закрытие прилежения полностью при нажатии на крестик
        }
        int num = new int();
        #region btn_save_click
        private void btn_save_Click(object sender, EventArgs e)
        {
            num = 1;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            //ds.WriteXml(filename);
            //ds.WriteXmlSchema("DSschema.xsd");
            if (dal.SaveBD(filename, num))
                MessageBox.Show("Данные БД были успешно сохранены", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Данные БД не были сохранены", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

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
            if(dal.SaveBD(filename, num))
                MessageBox.Show("Данные БД были успешно сохранены", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Данные БД не были сохранены", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void btn_saveдолжности_Click(object sender, EventArgs e)
        {
            num = 3;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            if(dal.SaveBD(filename, num))
                MessageBox.Show("Данные БД были успешно сохранены", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Данные БД не были сохранены", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
        private void btn_saveпродажи_Click(object sender, EventArgs e)
        {
            num = 4;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            if (dal.SaveBD(filename, num))
                MessageBox.Show("Данные БД были успешно сохранены", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Данные БД не были сохранены", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void btn_saveуслуги_Click(object sender, EventArgs e)
        {
            num = 5;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            if(dal.SaveBD(filename, num))
                MessageBox.Show("Данные БД были успешно сохранены", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Данные БД не были сохранены", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
        private void btn_addсотрудника_Click(object sender, EventArgs e)
        {

            FmAddсотрудника u = new FmAddсотрудника();

            if (u.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Добавлен новый сотрудник", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                dgv_сотрудники.DataSource = dal.GetAllWorker();
                dgv_сотрудники.Columns[0].Visible = false;
                forAddSales();

            }
            else
                MessageBox.Show("Не получилось добавить сотрудника", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

        }
        
        private void btn_searchсотрудника_Click(object sender, EventArgs e)
        {
            dgv_сотрудники.DataSource = dal.Searchсотрудник(txtbx_ФИО.Text);
            TableProperties();
        }

        private void btn_cancelSearch_Click(object sender, EventArgs e)
        {
            dgv_сотрудники.DataSource = dal.GetAllWorker();
            txtbx_ФИО.Clear();
            TableProperties();
        }
        bool booll = new bool();
        private void btn_changelanguage_Click(object sender, EventArgs e)
        {
            if (booll == true)
            {
                                                                                   //string b = System.Reflection.Assembly.GetExecutingAssembly().Location;
                btn_changelanguage.BackgroundImage = Image.FromFile(PathPicture2); //btn_changelanguage.BackgroundImage = Image.FromFile(@"D:\курсовой проект\company\Resources\lru.jpg");                                                                              
                booll = false;
                
            }
            else
            {

                btn_changelanguage.BackgroundImage = Image.FromFile(PathPicture1); //btn_changelanguage.BackgroundImage = Image.FromFile(@"\курсовой проект\company\Resources\len.jpg");
                booll = true;
                tabControl1.TabPages[0].Text = "Workers"; tabControl1.TabPages[1].Text = "Department"; tabControl1.TabPages[2].Text = "Post"; tabControl1.TabPages[3].Text = "Sales"; tabControl1.TabPages[4].Text = "Services";

            }

        }

        #endregion
        #region btn
        private void btn_watchDismissedWorker_Click(object sender, EventArgs e)
        {
            DismissedWorker dw = new DismissedWorker();
            dw.ShowDialog();
        }

        private void btn_dismissWorker_Click(object sender, EventArgs e)
        {
            DismissWorker dw = new DismissWorker();
            int selectedIndex = dgv_сотрудники.CurrentRow.Index;
            int rowID = int.Parse(dgv_сотрудники[0, selectedIndex].Value.ToString());
            string Отдел = (dgv_сотрудники["Отдел", selectedIndex].Value.ToString());
            int отдел = 0;
            string Должность = (dgv_сотрудники["Должность", selectedIndex].Value.ToString());
            int должность = 0;
            string ФИО = (dgv_сотрудники["ФИО", selectedIndex].Value.ToString());

            for (int i = 0; i < dgv_отделы.Rows.Count; i++)
                if (dgv_отделы[1, i].Value.ToString() == Отдел)
                    отдел = Convert.ToInt32(dgv_отделы[0, i].Value.ToString());
            for (int i = 0; i < dgv_должности.Rows.Count; i++)
                if (dgv_должности[1, i].Value.ToString() == Должность)
                    должность = Convert.ToInt32(dgv_должности[0, i].Value.ToString());
            dw.ID = rowID;
            dw.Отдел = Отдел;
            dw.Должность = Должность;
            dw.ФИО = ФИО;
            dw.отдел = отдел;
            dw.должность = должность;



            if (dw.ShowDialog() == DialogResult.OK)
            {
                if (dal.DeleteWorker(rowID))
                {
                    dgv_сотрудники.DataSource = dal.GetAllWorker();
                    MessageBox.Show("Сотрудник уволен", "admin", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                }
                else
                    MessageBox.Show("Не получилось уволить сотрудника", "admin", MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }
            else
                MessageBox.Show("Не получилось уволить сотрудника", "admin", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);

        }

        private void btn_addОтдел_Click(object sender, EventArgs e)
        {
            DepartmentAdd u = new DepartmentAdd();

            if (u.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Добавлен новый отдел", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                dgv_отделы.DataSource = dal.GetAllDepartments();
                cbBx_отдел.Items.Clear();
                cbBx_отдел.Text = "Все";
                cbBx_отдел.Items.Add("Все");
                arraylistsотделы();
                cbBx_отдел.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Не получилось добавить отдел", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

        }

        private void btn_deleteОтдел_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgv_отделы.CurrentRow.Index;
            int rowID = int.Parse(dgv_отделы[0, selectedIndex].Value.ToString());

            if (MessageBox.Show("Подтвердите удаление отдела", "Admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                if (dal.DeleteDepartment(rowID))
                {
                    dgv_отделы.DataSource = dal.GetAllDepartments();
                    cbBx_отдел.Items.Clear();
                    cbBx_отдел.Text = "Все";
                    cbBx_отдел.Items.Add("Все");
                    arraylistsотделы();
                    cbBx_отдел.SelectedIndex = 0;
                    MessageBox.Show("Отдел удалён", "admin", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                }
                else
                    MessageBox.Show("Отдел принадлежит одному из сотрудников", "admin", MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void btn_addДолжность_Click(object sender, EventArgs e)
        {
            PositionAdd u = new PositionAdd();

            if (u.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Добавлен новая должность", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                dgv_должности.DataSource = dal.GetAllPositions();
                cbBx_должность.Items.Clear();
                cbBx_должность.Text = "Все";
                cbBx_должность.Items.Add("Все");
                arraylistsдолжности();
                cbBx_должность.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Не получилось добавить должность", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void btn_deleteДолжность_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgv_должности.CurrentRow.Index;
            int rowID = int.Parse(dgv_должности[0, selectedIndex].Value.ToString());

            if (MessageBox.Show("Подтвердите удаление должности", "Admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                if (dal.DeletePosition(rowID))
                {
                    dgv_должности.DataSource = dal.GetAllPositions();
                    cbBx_должность.Items.Clear();
                    cbBx_должность.Text = "Все";
                    cbBx_должность.Items.Add("Все");
                    arraylistsдолжности();
                    cbBx_должность.SelectedIndex = 0;
                    MessageBox.Show("Должность удалёна", "admin", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                }
                else
                    MessageBox.Show("Должность принадлежит одному из сотрудников", "admin", MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void btn_addSales_Click(object sender, EventArgs e)
        {
            AddSales adds = new AddSales();
            adds.worker = alDepartmentOfSales;
            adds.client = alClientsForSales;
            adds.service = alServiceForSales;
            if (adds.ShowDialog() == DialogResult.OK)
            {
                dgv_продажи.DataSource = dal.GetAllSales();
                MessageBox.Show("Продажа добавлена", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            else
                MessageBox.Show("Не получилось добавить продажу", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private void btn_delateSale_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgv_продажи.CurrentRow.Index;
            int rowID = int.Parse(dgv_продажи[0, selectedIndex].Value.ToString());

            if (MessageBox.Show("Подтвердите удаление записи", "Admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                if (dal.DeleteSales(rowID))
                {
                    dgv_продажи.DataSource = dal.GetAllSales();
                    MessageBox.Show("Запись удалёна", "admin", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                }
                else
                    MessageBox.Show("Не получилось удалить запись", "admin", MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void btn_addУслуги_Click(object sender, EventArgs e)
        {
            AddУслуги add = new AddУслуги();
            if (add.ShowDialog() == DialogResult.OK)
            {
                dgv_услуги.DataSource = dal.GetAllServices();
                MessageBox.Show("Услуга добавлена", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            else
                MessageBox.Show("Не получилось добавить услугу", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

        }

        private void btn_deleteУслуги_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgv_услуги.CurrentRow.Index;
            int rowID = int.Parse(dgv_услуги[0, selectedIndex].Value.ToString());

            if (MessageBox.Show("Подтвердите удаление записи", "Admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                if (dal.DeleteService(rowID))
                {
                    dgv_услуги.DataSource = dal.GetAllServices();
                    MessageBox.Show("Запись удалёна", "admin", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                }
                else
                    MessageBox.Show("Не получилось удалить запись", "admin", MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void btn_addКлиенты_Click(object sender, EventArgs e)
        {
            AddКлиенты add = new AddКлиенты();
            if (add.ShowDialog() == DialogResult.OK)
            {
                dgv_клиенты.DataSource = dal.GetAllClients();
                MessageBox.Show("Клиент добавлен", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            else
                MessageBox.Show("Не получилось добавить клиента", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

        }

        private void btn_deleteКлиенты_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgv_клиенты.CurrentRow.Index;
            int rowID = int.Parse(dgv_клиенты[0, selectedIndex].Value.ToString());

            if (MessageBox.Show("Подтвердите удаление записи", "Admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                if (dal.DeleteClient(rowID))
                {
                    dgv_клиенты.DataSource = dal.GetAllClients();
                    MessageBox.Show("Запись удалёна", "admin", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                }
                else
                    MessageBox.Show("Не получилось удалить запись", "admin", MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }
        }
        private void btn_AddInfoсотрудник_Click(object sender, EventArgs e)
        {

            Additional_Info adinf = new Additional_Info();
            adinf.info = false;
            adinf.Show();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            dgv_продажи.DataSource = dal.GetAllSales();
            txtbx_ФИОклинетыSales.Clear();
            txtbx_ФИОсотрудникSales.Clear();
        }
        bool countt = new bool();
        private void btn_searchSales_Click(object sender, EventArgs e)
        {
            searchSales();
        }
        private void btn_deleteсотрудник_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgv_сотрудники.CurrentRow.Index;
            int rowID = int.Parse(dgv_сотрудники[0, selectedIndex].Value.ToString());

            if (MessageBox.Show("Подтвердите удаление сотрудника", "Admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                if (dal.DeleteWorker(rowID))
                {
                    dgv_сотрудники.DataSource = dal.GetAllWorker();
                    MessageBox.Show("Сотрудник удалён", "admin", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                }
                else
                    MessageBox.Show("Не получилось удалить сотрудника", "admin", MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }
        }
        #endregion
        #region toolStrip
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgv_сотрудники.Rows[point.Y].Index;
            int rowID = int.Parse(dgv_сотрудники[0, selectedIndex].Value.ToString());

            if (MessageBox.Show("Подтвердите удаление сотрудника", "admin", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                if (dal.DeleteWorker(rowID))
                {
                    dgv_продажи.DataSource = dal.GetAllSales();
                    dgv_сотрудники.DataSource = dal.GetAllWorker();
                    MessageBox.Show("Сотрудник удалён", "admin", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                }
                else
                {
                    dgv_продажи.DataSource = dal.GetAllSales();
                    dgv_сотрудники.DataSource = dal.GetAllWorker();
                    MessageBox.Show("Не получилось удалить сотрудника", "admin", MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
                }
            }
        }
        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_сотрудники.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try
                {
                    Clipboard.SetDataObject(dgv_сотрудники[point.X, point.Y].EditedFormattedValue);//GetClipboardContent()
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    MessageBox.Show("Копирование невозможно");
                }
            }
        }

        private void уволитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DismissWorker dw = new DismissWorker();
            int selectedIndex = dgv_сотрудники.Rows[point.Y].Index;
            int rowID = int.Parse(dgv_сотрудники[0, selectedIndex].Value.ToString());
            string Отдел = (dgv_сотрудники["Отдел", selectedIndex].Value.ToString());
            int отдел = 0;
            string Должность = (dgv_сотрудники["Должность", selectedIndex].Value.ToString());
            int должность = 0;
            string ФИО = (dgv_сотрудники["ФИО", selectedIndex].Value.ToString());

            for (int i = 0; i < dgv_отделы.Rows.Count; i++)
                if (dgv_отделы[1, i].Value.ToString() == Отдел)
                    отдел = Convert.ToInt32(dgv_отделы[0, i].Value.ToString());
            for (int i = 0; i < dgv_должности.Rows.Count; i++)
                if (dgv_должности[1, i].Value.ToString() == Должность)
                    должность = Convert.ToInt32(dgv_должности[0, i].Value.ToString());
            dw.ID = rowID;
            dw.Отдел = Отдел;
            dw.Должность = Должность;
            dw.ФИО = ФИО;
            dw.отдел = отдел;
            dw.должность = должность;



            if (dw.ShowDialog() == DialogResult.OK)
            {
                if (dal.DeleteWorker(rowID))
                {
                    dgv_сотрудники.DataSource = dal.GetAllWorker();
                    MessageBox.Show("Сотрудник уволен", "admin", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                }
                else
                    MessageBox.Show("Не получилось уволить сотрудника", "admin", MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }
            else
                MessageBox.Show("Не получилось уволить сотрудника", "admin", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);

        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            УслугиChangeCell adInCh = new УслугиChangeCell();
            adInCh.NameColumn = dgv_услуги.Columns[point.X].Name;
            //добавить [] в начало и конец
            adInCh.NameColumn = "[" + adInCh.NameColumn + "]";

            adInCh.ID = int.Parse(dgv_услуги[0, point.Y].Value.ToString());
            if (adInCh.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Запись изменена", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                dgv_услуги.DataSource = dal.GetAllServices();
                //checkBool();
            }
            else
                MessageBox.Show("Не получилось изменить", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

        }
        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            //    return;

            //string filename = openFileDialog1.FileName;

            //Process printProcess = new Process();
            //printProcess.StartInfo.FileName = filename;
            //printProcess.StartInfo.Verb = "Print";
            //printProcess.StartInfo.CreateNoWindow = true;
            //printProcess.Start();



            //ProcessStartInfo psi = new ProcessStartInfo(filename)
            //{
            //    UseShellExecute = true,
            //    Verb = "print",
            //    RedirectStandardOutput = false,
            //    CreateNoWindow = true
            //};
            //using (Process p = new Process {StartInfo = psi })
            //{
            //    p.Start();
            //    p.WaitForExit();
            //}


            printDialog1.Document = printDocument1;
            printDialog1.AllowSelection = true;
            printDialog1.AllowSomePages = true;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DocumentName = "р";
                printDocument1.Print();
            }

        }
        private void показатьДопИнфоToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Additional_Info ai = new Additional_Info();
            ai.info = true;
            int selectedIndex = dgv_сотрудники.Rows[point.Y].Index;
            ai.IDсотрудник = int.Parse(dgv_сотрудники[0, selectedIndex].Value.ToString());
            ai.Show();

        }
        #endregion
        #region
        private void cbBx_отдел_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBx_должность.SelectedIndex == 0 && !(cbBx_отдел.SelectedIndex == 0))
            {
                dgv_сотрудники.DataSource = dal.SortByОтдел(Convert.ToInt32(alотдел[cbBx_отдел.SelectedIndex - 1]));
                TableProperties();
            }
            else if (!(cbBx_отдел.SelectedIndex == 0) && !(cbBx_должность.SelectedIndex == 0))
            {
                dgv_сотрудники.DataSource = dal.SortByОтдел(cbBx_отдел.SelectedIndex, cbBx_должность.SelectedIndex);
                TableProperties();
            }
            else
            {
                dgv_сотрудники.DataSource = dal.GetAllWorker();
                TableProperties();
            }
            
        }

        private void cbBx_должность_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBx_отдел.SelectedIndex == 0 && !(cbBx_должность.SelectedIndex == 0))
            {
                dgv_сотрудники.DataSource = dal.SortByДолжность(Convert.ToInt32(alдолжность[cbBx_должность.SelectedIndex - 1]));
                TableProperties();
            }

            else if (!(cbBx_отдел.SelectedIndex == 0) && !(cbBx_должность.SelectedIndex == 0))
            {
                dgv_сотрудники.DataSource = dal.SortByОтдел(Convert.ToInt32(alотдел[cbBx_отдел.SelectedIndex - 1]),
                    Convert.ToInt32(alдолжность[cbBx_должность.SelectedIndex - 1]));
                TableProperties();
            }
            else
            {
                dgv_сотрудники.DataSource = dal.GetAllWorker();
                TableProperties();
            }

        }
        private void txtbx_ФИОклинетыSales_Click(object sender, EventArgs e)
        {
            txtbx_ФИОсотрудникSales.Clear();
            countt = true;
        }

        private void txtbx_ФИОсотрудникSales_Click(object sender, EventArgs e)
        {
            txtbx_ФИОклинетыSales.Clear();
            countt = false;
        }

        private void txtbx_ФИОклинетыSales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchSales();

        }

        private void txtbx_ФИОсотрудникSales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchSales();
        }
        #endregion
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Environment.Exit(0);
            MainScreen ms = new MainScreen();
            ms.Show();
            this.Hide();
        }

        private void экспортироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dal.SaveAllBD())
                MessageBox.Show("Данные БД были успешно сохранены", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Данные БД не были сохранены", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            
        }

        private void dgv_сотрудники_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                e.Cancel = true;
            }
        }

        Point point = new Point();
        private void dgv_сотрудники_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            point.X = e.ColumnIndex; point.Y = e.RowIndex;
        }
        
        private void dgv_услуги_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            point.X = e.ColumnIndex; point.Y = e.RowIndex;
        }
        
        private void searchSales()
        {
            dgv_продажи.DataSource = dal.GetAllSales();
            if (countt == true)
                dgv_продажи.DataSource = dal.SearchSales(txtbx_ФИОклинетыSales.Text);
            else
                dgv_продажи.DataSource = dal.SearchSales2(txtbx_ФИОсотрудникSales.Text);
        }

        private void прибыльПоМесяцамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphSalesMonths gsm = new graphSalesMonths();
            gsm.ShowDialog();
        }

        

        private void workscreenUser_Shown(object sender, EventArgs e)
        {
            if(dgv_сотрудники.Columns.Count == 0 && dgv_отделы.Columns.Count == 0)
            {
                //permissionUsers();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int kl = 0;
            groupBox2.Width -= 80;
            while (dgv_сотрудники.Controls.OfType<VScrollBar>().First().Visible)
            {
                groupBox2.Height += 120;
                kl += 120;
            }
            //e.HasMorePages = true;
            Bitmap image = new Bitmap(dgv_сотрудники.Width, dgv_сотрудники.Height);
            dgv_сотрудники.DrawToBitmap(image, dgv_сотрудники.ClientRectangle);
            e.Graphics.DrawImage(image, 10, 10);
            groupBox2.Height -= kl;
            groupBox2.Width += 80;
            
            
        }
        

        private void btn_printWorker_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            printDialog1.AllowSelection = true;
            printDialog1.AllowSomePages = true;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DocumentName = "р";
                printDocument1.Print();
            }

            
        }

        private void dgv_сотрудники_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (!(dgv_сотрудники.CurrentRow.Index == null))
                {
                    int CurrentRow = dgv_сотрудники.CurrentRow.Index;
                    txtbx_ID.Text = dgv_сотрудники["ID", CurrentRow].Value.ToString();
                    txtbx_отдел.Text = dgv_сотрудники["Отдел", CurrentRow].Value.ToString();
                    txtbx_должность.Text = dgv_сотрудники["Должность", CurrentRow].Value.ToString();
                    txtbx_опытработы.Text = dgv_сотрудники["Опыт работы", CurrentRow].Value.ToString();
                    txtbx_специальность.Text = dgv_сотрудники["Специальность", CurrentRow].Value.ToString();
                    txtbx_димплом.Text = dgv_сотрудники["Диплом", CurrentRow].Value.ToString();
                    txtbx_образование.Text = dgv_сотрудники["Образование", CurrentRow].Value.ToString();
                    txtbx_Семейноеположение.Text = dgv_сотрудники["Семейное положение", CurrentRow].Value.ToString();
                    rtxtbx_адрес.Text = dgv_сотрудники["Адрес", CurrentRow].Value.ToString();
                    txtbx_датаРождения.Text = dgv_сотрудники["Дата рождения", CurrentRow].Value.ToString();
                    txtbx_пол.Text = dgv_сотрудники["Пол", CurrentRow].Value.ToString();
                    txtbx_фиосотрудника.Text = dgv_сотрудники["ФИО", CurrentRow].Value.ToString();
                }
            }
            catch
            {

            }
            
        }
        private bool checkedtxtbx = false;
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(checkedtxtbx == false)
            {
                btn_saveChange.Visible = true;
                txtbx_фиосотрудника.Enabled = true;
                txtbx_пол.Enabled = true;
                txtbx_отдел.Enabled = true;
                txtbx_опытработы.Enabled = true;
                txtbx_образование.Enabled = true;
                txtbx_должность.Enabled = true;
                txtbx_димплом.Enabled = true;
                txtbx_датаРождения.Enabled = true;
                txtbx_специальность.Enabled = true;
                rtxtbx_адрес.Enabled = true;
                txtbx_Семейноеположение.Enabled = true;

                checkedtxtbx = true;
            }
            else
            {
                btn_saveChange.Visible = false;
                txtbx_фиосотрудника.Enabled = false;
                txtbx_пол.Enabled = false;
                txtbx_отдел.Enabled = false;
                txtbx_опытработы.Enabled = false;
                txtbx_образование.Enabled = false;
                txtbx_должность.Enabled = false;
                txtbx_димплом.Enabled = false;
                txtbx_датаРождения.Enabled = false;
                txtbx_специальность.Enabled = false;
                rtxtbx_адрес.Enabled = false;
                txtbx_Семейноеположение.Enabled = false;

                checkedtxtbx = false;
            }
        }

        private void btn_saveChange_Click(object sender, EventArgs e)
        {
            
            btn_saveChange.Visible = false;
            txtbx_фиосотрудника.Enabled = false;
            txtbx_пол.Enabled = false;
            txtbx_отдел.Enabled = false;
            txtbx_опытработы.Enabled = false;
            txtbx_образование.Enabled = false;
            txtbx_должность.Enabled = false;
            txtbx_димплом.Enabled = false;
            txtbx_датаРождения.Enabled = false;
            txtbx_специальность.Enabled = false;
            rtxtbx_адрес.Enabled = false;
            txtbx_Семейноеположение.Enabled = false;
            try
            {
                if (dal.UpdateWorkerInfo(Convert.ToInt32(txtbx_ID.Text), txtbx_фиосотрудника.Text, txtbx_пол.Text, Convert.ToDateTime(txtbx_датаРождения.Text), rtxtbx_адрес.Text,
                    txtbx_Семейноеположение.Text, txtbx_образование.Text, txtbx_специальность.Text, txtbx_димплом.Text, Convert.ToInt32(txtbx_опытработы.Text)))
                {
                    MessageBox.Show("Запись изменена", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    dgv_сотрудники.DataSource = dal.GetAllWorker();
                    //dgv_сотрудники.Columns[0].Visible = false;
                }
                else
                    MessageBox.Show("Не получилось изменить", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch
            {
                MessageBox.Show("Не получилось изменить", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            checkedtxtbx = false;

        }
    }
}
