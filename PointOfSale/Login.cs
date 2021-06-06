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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void usernameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                loginBtn.PerformClick();
            }
        }

        bool Validation()
        {
            Control validateControl = new Control();

            validateControl = usernameTxt;
            if (validateControl.Text == "")
            {
                TooltipMessage.CustomTooltip.Show(tlpMessage, "Please enter your username", validateControl, 8000, SystemIcons.Error, true);
                return false;
            }

            validateControl = passwordTxt;
            if (validateControl.Text == "")
            {
                TooltipMessage.CustomTooltip.Show(tlpMessage, "Please enter your password", validateControl, 8000, SystemIcons.Error, true);
                return false;
            }

            return true;
        }

        private void tlpMessage_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
            e.Graphics.DrawIcon(TooltipMessage.CustomTooltip.tooltipIcon, 10, 2);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (!Validation())
            {
                return;
            }

            tlpMessage.Hide(this);

            if (UsersBLL.Login(Functions.SanitizeString(usernameTxt.Text.ToLower()), Functions.SanitizeString(passwordTxt.Text)))
            {

                Dashboard dashboard = new Dashboard();
                dashboard.MdiParent = Main.ActiveForm;
                dashboard.WindowState = FormWindowState.Minimized;
                dashboard.Show();
                dashboard.WindowState = FormWindowState.Normal;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Confirm", MessageBoxButtons.YesNo);
            Globals.isExit = true;
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            Orders pass = new Orders();
            pass.MdiParent = Main.ActiveForm;
            pass.Show();
            this.Close();
        }
    }
}
