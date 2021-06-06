using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
using Entities;
using BLL;

namespace PointOfSale
{
    public partial class Products : Form
    {
        int rows = 0;
        public int TableLimit = 0;
        public int TableOffset = 5;
        public int NextRows = 0;
        public int CurRows = 0;
        public int PrevRows = 0;
        public int AllRows = 0;

        public Products()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ProductAdd pass = new ProductAdd();
            pass.MdiParent = Main.ActiveForm;
            pass.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Dashboard pass = new Dashboard();
            pass.MdiParent = Main.ActiveForm;
            pass.Show();
            this.Close();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            Globals.productShowId = 0;

            productsDgv.RowTemplate.Height = 50;
            productsDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsDgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            productsDgv.Columns[4].Visible = false;


            showAllProducts();
        }

        private void showAllProducts()
        {
            nextBtn.Enabled = false;
            prevBtn.Enabled = false;

            // productsDgv.BackgroundColor = Color.FromArgb(170, 177, 191);

            rows = 0;
            productsDgv.Rows.Clear();

            foreach (ProductsData data in ProductsBLL.getProducts(TableLimit, TableOffset, Functions.SanitizeString(searchTxt.Text)))
            {
                try
                {
                    productsDgv.Rows.Add();
                    
                    productsDgv.Rows[rows].Cells[0].Value = data.ProductName;
                    productsDgv.Rows[rows].Cells[1].Value = data.ProductPrice;
                    productsDgv.Rows[rows].Cells[2].Value = data.ProductQuantity;
                    productsDgv.Rows[rows].Cells[4].Value = data.ProductId;
                    rows++;
                }
                catch
                {

                }
            }

            CurRows = productsDgv.Rows.Count;
            AllRows = ProductsBLL.getProductCount(Functions.SanitizeString(searchTxt.Text));


            if (TableLimit == 0)
            {
                if (AllRows > TableOffset)
                {
                    nextBtn.Enabled = true;
                    prevBtn.Enabled = false;
                }
                else
                {
                    nextBtn.Enabled = false;
                    prevBtn.Enabled = false;
                }
            }
            else
            {
                if (AllRows > TableLimit)
                {
                    if (AllRows == (TableLimit + productsDgv.Rows.Count))
                    {
                        nextBtn.Enabled = false;
                        prevBtn.Enabled = true;
                    }
                    else
                    {
                        nextBtn.Enabled = true;
                        prevBtn.Enabled = true;
                    }
                }
                else if (TableLimit < AllRows)
                {
                    nextBtn.Enabled = false;
                    prevBtn.Enabled = true;
                }
                else
                {
                    nextBtn.Enabled = false;
                    prevBtn.Enabled = false;
                }
            }

            total.Text = AllRows.ToString();
        }

        private void searchTxt_KeyUp(object sender, KeyEventArgs e)
        {
            showAllProducts();
        }

        private void productsDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                try
                {
                    Globals.productShowId = Convert.ToInt32(productsDgv.Rows[e.RowIndex].Cells[4].Value.ToString());
                    ProductAdd pass = new ProductAdd();
                    pass.MdiParent = Main.ActiveForm;
                    pass.Show();
                    this.Close();
                }
                catch
                {

                }
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            TableLimit -= TableOffset;
            showAllProducts();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            TableLimit += TableOffset;
            showAllProducts();
        }
    }
}
