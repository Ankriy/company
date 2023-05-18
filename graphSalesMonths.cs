using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace company
{
    public partial class graphSalesMonths : Form
    {
        DAL dal = new DAL();
        public graphSalesMonths()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cbBx_graph.Items.Add("Сплайн-диаграмма");
            cbBx_graph.Items.Add("Круговая диаграмма");
            cbBx_graph.SelectedIndex = 0;
            listView1.View = View.SmallIcon;
            listView1.Visible = false;
        }

        private void cbBx_graph_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBx_graph.SelectedIndex == 0)
            {
                //создаем элемент Chart
                Chart myChart = new Chart();
                gpbx_гистограмма.Controls.Clear();
                
                //кладем его на форму и растягиваем на все окно.
                //myChart.Parent = this;
                myChart.Parent = null;
                myChart.Parent = gpbx_гистограмма;
                myChart.Dock = DockStyle.Fill;
                //добавляем в Chart область для рисования графиков, их может быть
                //много, поэтому даем ей имя.
                myChart.ChartAreas.Add(new ChartArea("First"));
                //Создаем и настраиваем набор точек для рисования графика, в том
                //не забыв указать имя области на которой хотим отобразить этот
                //набор точек.
                Series mySeries = new Series("Гистограмма");
                mySeries.ChartType = SeriesChartType.Spline;
                mySeries.ChartArea = "First";
                for (int i = 1; i <= 12; i++)
                {
                    //mySeriesOfPoint.Points.Add(i);
                    mySeries.Points.AddXY(i, dal.SummCostSalesOfMonth(i.ToString()));
                }

                //Добавляем созданный набор точек в Chart
                myChart.Series.Add(mySeries);
                myChart.Series[0].BorderWidth = 3;
                myChart.Series[0].Color = Color.Green;

                myChart.ChartAreas["First"].AxisX.Title = "Месяц";
                myChart.ChartAreas["First"].AxisX.Maximum = 12;
                myChart.ChartAreas["First"].AxisX.Minimum = 1;
                myChart.ChartAreas["First"].AxisX.TitleFont = new Font(" ", 12, FontStyle.Regular);
                myChart.ChartAreas["First"].AxisX.TitleForeColor = Color.Red;


                myChart.ChartAreas["First"].AxisY.Title = "Доход, руб";
                myChart.ChartAreas["First"].AxisY.TitleFont = new Font(" ", 12, FontStyle.Regular);
                myChart.ChartAreas["First"].AxisY.TitleForeColor = Color.Red;
                //myChart.ChartAreas["First"].AxisY.Interval = 2000;
                //myChart.ChartAreas["First"].AxisX.IntervalType = DateTimeIntervalType.Months;
            }
            if (cbBx_graph.SelectedIndex == 1)
            {
                listView1.Visible = true;
                Chart myChart = new Chart();
                gpbx_гистограмма.Controls.Clear();
                myChart.Parent = gpbx_гистограмма;
                myChart.Dock = DockStyle.Fill;
                myChart.ChartAreas.Add(new ChartArea("Second"));
                Series mySeries2 = new Series("Диаграмма");
                mySeries2.ChartType = SeriesChartType.Pie;
                mySeries2.ChartArea = "Second";
                for (int i = 1; i <= 12; i++)
                {
                    //mySeriesOfPoint.Points.Add(i);
                    mySeries2.Points.AddXY(string.Format("{0}", i), dal.SummCostSalesOfMonth(i.ToString()));
                    //mySeries.Points.AddXY(dal.SummCostSalesOfMonth(i.ToString()), string.Format("{0}", i) + " (" + dal.SummCostSalesOfMonth(i.ToString()).ToString() + ")");
                    mySeries2.Font = new Font(" ", 8, FontStyle.Regular);
                    
                }
                
                for (int i = 1; i <= 12; i++)
                {
                    listView1.Items.Add(string.Format("{0}", i) + " мес. " + dal.SummCostSalesOfMonth(i.ToString()).ToString() + " руб.", dal.SummCostSalesOfMonth(i.ToString()));
                }
                //Добавляем созданный набор точек в Chart
                myChart.Series.Add(mySeries2);
                //myChart.ChartAreas["Second"].AxisX.
                myChart.ChartAreas["Second"].AxisX.Title = "Месяц";
                myChart.ChartAreas["Second"].AxisY.Title = "Мес";
                myChart.ChartAreas["Second"].AxisY2.Title = "авпарп";
            }
            else
            {
                listView1.Visible = false;
                listView1.Items.Clear();
            }
        }
    }
}
