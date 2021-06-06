using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PointOfSale
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\wallpapers\\BG.png");
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            Login pass = new Login();
            pass.MdiParent = this;
            pass.Show();
            this.Cursor = Cursors.Default;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Globals.isExit)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
