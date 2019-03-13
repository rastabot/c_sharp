using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEvent
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtEventInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtEventInfo.Text = "";
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            txtEventInfo.Text = e.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            frmSecond secondForm = new frmSecond();
            secondForm.Show();
        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
            frmCarDetails frmCarObj = new frmCarDetails();
            DialogResult result = frmCarObj.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show(
                    string.Format("Car name:{0}", frmCarObj.txtCarName.Text));
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarDetails frmObj = new frmCarDetails();
            frmObj.Show();

        }
    }
}
