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
using Utilities;

namespace PointOfSale
{
    public partial class ProductAdd : Form
    {
        public ProductAdd()
        {
            InitializeComponent();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            if (Globals.productShowId > 0)
            {
                showProduct();
            }
        }

        private void showProduct()
        {

            ProductsData data = ProductsBLL.getProductById(Globals.productShowId);

            productNameTxt.Text = data.ProductName;
            priceTxt.Text = data.ProductPrice.ToString();
            quanityTxt.Text = data.ProductQuantity.ToString();


            label1.Text = "Edit Product";
            addBtn.Text = "Update";
        }

        private void priceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
             && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Products pass = new Products();
            pass.MdiParent = Main.ActiveForm;
            pass.Show();
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!Validation())
            {
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure all information are correct?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }


            if (Globals.productShowId > 0)
            {
                updateProduct();
            }
            else
            {
                addProduct();
            }
        }

        private void addProduct()
        {
            ProductsData data = new ProductsData();
            data.ProductName = Functions.SanitizeString(productNameTxt.Text);
            data.ProductPrice = Convert.ToDecimal(priceTxt.Text);
            data.ProductQuantity = Convert.ToInt32(quanityTxt.Text);
            data.ProductStatus = "active";
            data.CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            data.UpdatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            if (ProductsBLL.SaveProduct(data))
            {
                MessageBox.Show("Product Saved!");
                Products select = new Products();
                select.MdiParent = Main.ActiveForm;
                select.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to Save.");
            }
        }

        private void updateProduct()
        {
            ProductsData data = new ProductsData();
            data.ProductId = Globals.productShowId;
            data.ProductName = Functions.SanitizeString(productNameTxt.Text);
            data.ProductPrice = Convert.ToDecimal(priceTxt.Text);
            data.ProductQuantity = Convert.ToInt32(quanityTxt.Text);
            data.UpdatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            if (ProductsBLL.updateProduct(data))
            {
                MessageBox.Show("Product Updated!");
                Products select = new Products();
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

        bool Validation()
        {
            Control validateControl = new Control();

            validateControl = productNameTxt;
            if (Functions.SanitizeString(validateControl.Text) == "")
            {
                TooltipMessage.CustomTooltip.Show(tlpMessage, "Please enter product name", validateControl, 8000, SystemIcons.Error, true);
                return false;
            }

            validateControl = quanityTxt;
            if (Functions.SanitizeString(validateControl.Text) == "")
            {
                TooltipMessage.CustomTooltip.Show(tlpMessage, "Please enter quantity", validateControl, 8000, SystemIcons.Error, true);
                return false;
            }

            validateControl = priceTxt;
            if (validateControl.Visible && Functions.SanitizeString(validateControl.Text) == "")
            {
                TooltipMessage.CustomTooltip.Show(tlpMessage, "Please enter price", validateControl, 8000, SystemIcons.Error, true);
                return false;
            }
            
            return true;
        }

        private void quanityTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                addBtn.PerformClick();
            }
        }
    }
}
