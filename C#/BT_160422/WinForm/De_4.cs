using System;
using System.Windows.Forms;

namespace WinForm
{
    public partial class De_4 : Form
    {
        Service.ServiceClient wcf = new Service.ServiceClient();

        public De_4()
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
            rtxtAns.Text = "Mảng: " + wcf.PrintArray(wcf.Sort_EvenNumberAscending_OddNumberDescending(arr));
            rtxtAns.Text += "\nTổng của mảng: " + wcf.SumArray(arr);
        }
    }
}
