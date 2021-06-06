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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            Products pass = new Products();
            pass.MdiParent = Main.ActiveForm;
            pass.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            Login login = new Login();
            login.MdiParent = Main.ActiveForm;
            login.Show();
            this.Close();
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            Orders pass = new Orders();
            pass.MdiParent = Main.ActiveForm;
            pass.Show();
            this.Close();
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            Sales pass = new Sales();
            pass.MdiParent = Main.ActiveForm;
            pass.Show();
            this.Close();
        }
    }
}
