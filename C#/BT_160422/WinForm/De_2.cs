using System;
using System.Windows.Forms;

namespace WinForm
{
    public partial class De_2 : Form
    {
        Service.ServiceClient wcf = new Service.ServiceClient();

        public De_2()
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
            rtxtAns.Text = "Sắp xếp tăng dần các số chẩn: " + wcf.PrintArray(wcf.SortEvenNumberAscending(arr));
            rtxtAns.Text += "\nTrung bình cộng của mảng: " + wcf.Average(arr);
        }
    }
}
