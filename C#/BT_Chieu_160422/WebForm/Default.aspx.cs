using System;

namespace WebForm
{
    public partial class Default : System.Web.UI.Page
    {
        Service.ServiceClient wcf = new Service.ServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit1_Click(object sender, EventArgs e)
        {
            txtOutput1.Text = wcf.DecToBin(Convert.ToInt32(txtInput1.Text));
        }

        protected void btnSubmit2_Click(object sender, EventArgs e)
        {
            txtOutput2.Text = "Kết quả: " + wcf.Sum1ToN(Convert.ToInt32(txtInput2.Text));
        }

        protected void btnSubmit3_Click(object sender, EventArgs e)
        {
            txtOutput3.Text = "Kết quả: " + wcf.Factorial(Convert.ToInt32(txtInput3.Text));
        }

        protected void btnSubmit4_Click(object sender, EventArgs e)
        {
            txtOutput4.Text = wcf.PrintPrimeAToB(Convert.ToInt32(txtInput4_1.Text), Convert.ToInt32(txtInput4_2.Text));
        }
    }
}