using System;
using System.Windows.Forms;

namespace WinForm
{
    public partial class De_3 : Form
    {
        Service.ServiceClient wcf = new Service.ServiceClient();

        public De_3()
        {
            InitializeComponent();
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            int[] arr =
            {
                Convert.ToInt32(txtNum1.Text),
                Convert.ToInt32(txtNum2.Text),
                Convert.ToInt32(txtNum3.Text),
                Convert.ToInt32(txtNum4.Text),
                Convert.ToInt32(txtNum5.Text),
                Convert.ToInt32(txtNum6.Text),
                Convert.ToInt32(txtNum7.Text),
            };
            rtxtAns.Text = wcf.Count_PrintOddNumber(arr);
            rtxtAns.Text += "\n" + wcf.Count_PrintEvenNumber(arr);
        }
    }
}
