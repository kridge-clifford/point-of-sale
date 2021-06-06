using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BLL;

namespace PointOfSale
{
    public partial class Sales : Form
    {
        int rows = 0;
        public int TableLimit = 0;
        public int TableOffset = 999;
        public int NextRows = 0;
        public int CurRows = 0;
        public int PrevRows = 0;
        public int AllRows = 0;

        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            toDate.CustomFormat = "MMM d, yyyy";
            fromDate.CustomFormat = "MMM d, yyyy";
            fromDate.MaxDate = DateTime.Now;
            toDate.MaxDate = fromDate.Value;

            productsDgv.RowTemplate.Height = 50;
            productsDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsDgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            showSales();
        }

        private void showSales()
        {

            // productsDgv.BackgroundColor = Color.FromArgb(170, 177, 191);

            rows = 0;
            productsDgv.Rows.Clear();

            foreach (SalesData data in OrderDetailBLL.getSalesProductByDate(TableLimit, TableOffset, fromDate.Value.ToString("yyyy-MM-dd"), toDate.Value.ToString("yyyy-MM-dd")))
            {
                try
                {
                    productsDgv.Rows.Add();

                    productsDgv.Rows[rows].Cells[0].Value = data.ProductName;
                    productsDgv.Rows[rows].Cells[1].Value = "x" + data.TotalQuantity;
                    productsDgv.Rows[rows].Cells[2].Value = data.TotalPrice + "PHP";
                    rows++;
                }
                catch
                {

                }
            }
            
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            TableLimit += TableOffset;
            showSales();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            TableLimit -= TableOffset;
            showSales();
        }

        private void toDate_ValueChanged(object sender, EventArgs e)
        {
            fromDate.MaxDate = toDate.Value;
            showSales();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.MdiParent = Main.ActiveForm;
            dashboard.WindowState = FormWindowState.Minimized;
            dashboard.Show();
            dashboard.WindowState = FormWindowState.Normal;
            this.Close();
        }
    }
}
