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
    public partial class SplashScreen : Form
    {
        System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer() { Interval = 2500 };
        public SplashScreen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;    // форма по центру
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //отключает рамку

            ProgressBarProperties();

            Label lbl = new Label() { Text = "Opecar Service" }; // создаётся метка
            //lbl.AutoSize = true;
            lbl.Size = new Size(300, 60);
            lbl.Font = new Font("Times New Roman", 30, FontStyle.Bold); //указывается (шрифт, размер, тип)
            lbl.ForeColor = Color.White;
            lbl.Location = new Point((this.Width - lbl.Width) / 2, (this.Height - lbl.Height) / 2); // метка помещается в центр
            this.Controls.Add(lbl); //на форму помещается метка
            tmr.Tick += tmr_Tick;
            tmr.Start();

            
        }
        private void ProgressBarProperties()
        {
            //progressBarEx_load.ForeColor = Color.FromArgb(255, 255, 255);
            //progressBarEx_load.BackColor = Color.FromArgb(0, 0, 0);
            progressBarEx_load.ForeColor = Color.Green;
            progressBarEx_load.BackColor = Color.Black;
            progressBarEx_load.Minimum = 0;
            progressBarEx_load.Maximum = 100;
            progressBarEx_load.Value = 0;
            progressBarEx_load.Step = 10;
            //progressBarEx_load.Show();
        
        }
        void tmr_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private async void SplashScreen_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < 101; i++)
            {
                progressBarEx_load.Value = i;
                await Task.Delay(17);
                //Thread.Sleep(25);
            }
        }
    }
}
