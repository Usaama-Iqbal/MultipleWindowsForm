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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(4);
            label2.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("successful");
            }
        }
    }
}
