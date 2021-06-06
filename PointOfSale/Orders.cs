using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entities;
using Utilities;

namespace PointOfSale
{
    public partial class Orders : Form
    {
        int rows = 0;
        public int TableLimit = 0;
        public int TableOffset = 999;

        public Orders()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            Globals.orderDetailList.Clear();

            productsDgv.RowTemplate.Height = 50;
            productsDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsDgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            productsDgv.Columns[3].Visible = false;

            ordersDgv.RowTemplate.Height = 50;
            ordersDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ordersDgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            ordersDgv.Columns[5].Visible = false;

            showAllProducts();
        }

        private void showAllProducts()
        {

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
                    productsDgv.Rows[rows].Cells[3].Value = data.ProductId;
                    rows++;
                }
                catch
                {

                }
            }
            
        }

        private void ordersDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        
        }

        private void ordersDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                productNameTxt.Text = productsDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                priceTxt.Text = productsDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                Globals.orderProductId = Convert.ToInt32(productsDgv.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            {

            }
        }

        private void clearFields()
        {
            productNameTxt.Text = "No Selected";
            priceTxt.Text = "No Selected";
            quantityTxt.Value = 1;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Control validateControl = new Control();

            validateControl = productNameTxt;
            if (Functions.SanitizeString(productNameTxt.Text) == "No Selected")
            {
                TooltipMessage.CustomTooltip.Show(tlpMessage, "No item selected.", validateControl, 8000, SystemIcons.Error, true);
                return;
            }

            decimal product_sum = Convert.ToDecimal(priceTxt.Text) * Convert.ToDecimal(quantityTxt.Value);
            decimal grand_total = product_sum + Convert.ToDecimal(grandTotalTxt.Text);
            
            int rows = ordersDgv.RowCount;

            ordersDgv.Rows.Add();
            ordersDgv.Rows[rows].Cells[0].Value = productNameTxt.Text;
            ordersDgv.Rows[rows].Cells[1].Value = priceTxt.Text;
            ordersDgv.Rows[rows].Cells[2].Value = quantityTxt.Value;
            ordersDgv.Rows[rows].Cells[3].Value = product_sum;
            ordersDgv.Rows[rows].Cells[4].Value = "Void";
            ordersDgv.Rows[rows].Cells[5].Value = Globals.orderProductId;

            OrderDetailData data = new OrderDetailData();
            data.ProductId = Globals.orderProductId;
            data.Quantity = Convert.ToInt32(quantityTxt.Value);
            data.Price = product_sum;
            data.CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            data.UpdatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            Globals.orderDetailList.Add(data);

            grandTotalTxt.Text = grand_total.ToString();

            Globals.orderProductId = 0;

            clearFields();
        }

        private void ordersDgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    ordersDgv.Rows.RemoveAt(e.RowIndex);

                    int rows_orders = ordersDgv.RowCount;
                    decimal grand_total = 0;

                    for (int i = 0; i < rows_orders; i++)
                    {
                        grand_total += Convert.ToInt32(ordersDgv.Rows[i].Cells[3].Value);
                    }
                    grandTotalTxt.Text = grand_total.ToString();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void searchTxt_KeyUp(object sender, KeyEventArgs e)
        {
            showAllProducts();
        }

        private void placeOrderBtn_Click(object sender, EventArgs e)
        {
            if (Globals.orderDetailList.Count == 0)
            {
                MessageBox.Show("No items were seleceted.", "Confirm", MessageBoxButtons.OK);
                return;
            }

            Control validateControl = new Control();

            validateControl = paymentTxt;
            if (Convert.ToDecimal(grandTotalTxt.Text) > Convert.ToDecimal(paymentTxt.Value))
            {
                TooltipMessage.CustomTooltip.Show(tlpMessage, "Not enough payment.", validateControl, 8000, SystemIcons.Error, true);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Confirm order?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            OrdersData data = new OrdersData();
            data.PaidAmount = Convert.ToDecimal(grandTotalTxt.Text);
            data.CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            data.UpdatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            decimal total_change = Convert.ToDecimal(paymentTxt.Value) - Convert.ToDecimal(grandTotalTxt.Text);

            if (OrderDetailBLL.saveOrders(data, Globals.orderDetailList))
            {
                MessageBox.Show("Order has been successfully placed! Total change: P" + total_change);
                Orders select = new Orders();
                select.MdiParent = Main.ActiveForm;
                select.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to Save.");
            }
        }

        private void tlpMessage_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
            e.Graphics.DrawIcon(TooltipMessage.CustomTooltip.tooltipIcon, 10, 2);
        }

        private void resetFieldsBtn_Click(object sender, EventArgs e)
        {
            clearFields();
            Globals.orderDetailList.Clear();
            ordersDgv.Rows.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Dashboard pass = new Dashboard();
            pass.MdiParent = Main.ActiveForm;
            pass.Show();
            this.Close();
        }
    }
}
