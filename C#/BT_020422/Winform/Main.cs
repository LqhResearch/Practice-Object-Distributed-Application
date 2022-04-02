using System;
using System.Windows.Forms;

namespace Winform
{
    public partial class Main : Form
    {
        Service.ServiceClient wcf = new Service.ServiceClient();
        public Main()
        {
            InitializeComponent();
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            txtAns.Text = wcf.Calculate(int.Parse(txtNum1.Text), cboOpeator.Text[0], int.Parse(txtNum2.Text)).ToString();
        }
    }
}
