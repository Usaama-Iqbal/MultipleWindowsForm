using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginIn
{
    public partial class frmlogin : Form
    {
        string userName = "usamaiqbal@gmail.com";
        string pass = "123456789";
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (userName == txtLogin.Text && pass == txtPass.Text)
            {
                
                frmHome frm = new frmHome();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username OR Password");
            }
        }

       
    }
}
