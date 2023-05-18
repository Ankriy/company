using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace company
{
    public partial class MainScreen : Form
    {
        
        public MainScreen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //btn_1.Location = new Point((this.Width - btn_1.Width - 365) / 2, (this.Height - btn_1.Height) / 2);
            //btn_2.Location = new Point((this.Width - btn_2.Width + 356) / 2, (this.Height - btn_2.Height) / 2);

            btn_1.Location = new Point((this.Width - btn_1.Width) / 2, (this.Height - btn_1.Height - 100) / 2);
            btn_2.Location = new Point((this.Width - btn_2.Width + 356) / 2, (this.Height - btn_2.Height) / 2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Password password = new Password();
            if (password.ShowDialog() == DialogResult.OK) //ShowDialog() - Отображает форму как модальное диалоговое окно
            {                                               //Если пароль совпал, то выполняется условие
                workscreenUser form1 = new workscreenUser();
                form1.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            Password2 password2 = new Password2();
            if (password2.ShowDialog() == DialogResult.OK) //ShowDialog() - Отображает форму как модальное диалоговое окно
            {
                workscreenAdmin form1 = new workscreenAdmin();
                form1.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Пароль не верный", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        

        private void Screen_Resize(object sender, EventArgs e) //привязка кнопок с размеру программы с задержкой 2 мс
        {
            btn_1.Location = new Point((this.Width - btn_1.Width) / 2, (this.Height - btn_1.Height - 100) / 2);
            btn_2.Location = new Point((this.Width - btn_2.Width + 356) / 2, (this.Height - btn_2.Height) / 2);
            //btn_1.Location = new Point((this.Width - btn_1.Width - 365) / 2, (this.Height - btn_1.Height) / 2);
            //btn_2.Location = new Point((this.Width - btn_2.Width + 356) / 2, (this.Height - btn_2.Height) / 2);
            Thread.Sleep(3);
        }

        private void btn_свернуть_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        bool resize = true;
        private void btn_resize_Click(object sender, EventArgs e)
        {
            if (resize == true)
            {
                this.WindowState = FormWindowState.Maximized;
                resize = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                resize = true;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
