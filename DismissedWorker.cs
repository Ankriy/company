using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace company
{
    public partial class DismissedWorker : Form
    {
        DAL dal = new DAL();
        public DismissedWorker()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dgv_dismissed.DataSource = dal.GetAllDismissedWorker();

            dgv_dismissed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_dismissed.BorderStyle = BorderStyle.Fixed3D;
            dgv_dismissed.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_dismissed.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|Text files(*.DOC)|*.DOC|All files(*.*)|*.*";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            //    return;
            //string filename2 = saveFileDialog1.FileName;
            int selectedIndex = dgv_dismissed.CurrentRow.Index;
            string[] text = {"№док", "ID", "ФИОсот", "IDотдел", "IDдолжность", "СтатьяСот", "ПричинаСот", "ДатаУвол","ДатаРас"};
            string[] replace = new string[9];
            replace[8] = DateTime.Now.ToString();
            for (int i = 0; i < 8; i++)
                replace[i] = dgv_dismissed[i,selectedIndex].Value.ToString();
            

            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Object filename = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\Templates\\" + "увольнение.docx";
            Object confirmConversions = Type.Missing;
            Object readOnly = Type.Missing;
            Object addToRecentFiles = Type.Missing;
            Object passwordDocument = Type.Missing;
            Object passwordTemplate = Type.Missing;
            Object revert = Type.Missing;
            Object writePasswordDocument = Type.Missing;
            Object writePasswordTemplate = Type.Missing;
            Object format = Type.Missing;
            Object encoding = Type.Missing;
            Object visible = Type.Missing;
            Object openConflictDocument = Type.Missing;
            Object openAndRepair = Type.Missing;
            Object documentDirection = Type.Missing;
            Object noEncodingDialog = Type.Missing;
            app.Documents.Open(ref filename, ref confirmConversions, ref readOnly, ref addToRecentFiles,
                ref passwordDocument, ref passwordTemplate, ref revert, ref writePasswordDocument, ref writePasswordTemplate,
                ref format, ref encoding, ref visible, ref openConflictDocument, ref openAndRepair, ref documentDirection, ref noEncodingDialog);

            Microsoft.Office.Interop.Word.Find find = app.Selection.Find;

            find.ClearFormatting();
            find.Replacement.ClearFormatting();

            for(int i=8; i >=0; i--)
            {
                find.Text = text[i];
                find.Replacement.Text = replace[i];
                object missing = Type.Missing;
                object replaceAll = Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll;
                find.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing, ref missing,
                        ref replaceAll, ref missing, ref missing, ref missing, ref missing);
            }

            

            //object missing2 = Type.Missing;
            //object missing3 = false;
            //app.Quit(ref missing3, ref missing2, ref missing2);
            //app.PrintOut(ref missing2, ref missing2, ref missing2, ref missing2, ref missing2,
            //            ref missing2, ref missing2, ref missing2, ref missing2, ref missing2,
            //            ref missing2, ref missing2, ref missing2, ref missing2, ref missing2, ref missing2, ref missing2, ref missing2, ref missing2);

        }
        //Point point = new Point();
        private void dgv_dismissed_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //point.X = e.ColumnIndex; point.Y = e.RowIndex;
        }

        
    }
}
