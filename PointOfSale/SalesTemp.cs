using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class SalesTemp : Form
    {
        public SalesTemp()
        {
            InitializeComponent();
            cartesianChart1.Series = new SeriesCollection {
                new ColumnSeries
                {
                    Title = "Total",
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(10),
                        new ObservableValue(7),
                        new ObservableValue(3),
                        new ObservableValue(6),
                        new ObservableValue(8),
                    },
                }
            };

            ColumnSeries sample = new ColumnSeries
            {
                Title = "Total",
                Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(10000),
                        new ObservableValue(800),
                        new ObservableValue(200),
                        new ObservableValue(600),
                        new ObservableValue(100),
                    },

            };
            cartesianChart1.Series.Clear();
            cartesianChart1.Series.Add(sample);
            

            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = new[]
              {
                    "Shea Ferriera",
                    "Maurita Powel",
                    "Scottie Brogdon",
                    "Teresa Kerman",
                    "Nell Venuti",
                    "Anibal Brothers",
                    "Anderson Dillman"
                },
                Separator = new Separator // force the separator step to 1, so it always display all labels
                {
                    Step = 1,
                    IsEnabled = false //disable it to make it invisible.
                },
                LabelsRotation = 15
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "SALES",
                LabelFormatter = value => value + ".00K items",
                Separator = new Separator()
            });
        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }
    }
}
