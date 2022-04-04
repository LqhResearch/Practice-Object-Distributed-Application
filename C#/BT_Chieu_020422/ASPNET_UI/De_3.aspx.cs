using System;

namespace ASPNET_UI
{
    public partial class Default : System.Web.UI.Page
    {
        Service.ServiceClient wcf = new Service.ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAns_Click(object sender, EventArgs e)
        {
            double a = int.Parse(txtA.Text);
            double b = int.Parse(txtB.Text);
            double c = int.Parse(txtC.Text);

            if (wcf.IsTriangle(a, b, c))
            {
                txtMessage.Text = "Ba cạnh này lập thành " + wcf.TriangleName(a, b, c);
                txtMessage.Text += "\nTrung bình cộng của các cạnh là " + wcf.AverageTriangle(a, b, c);
            }
            else txtMessage.Text = "Ba cạnh này không lập thành tam giác";
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Text = txtB.Text = txtC.Text = txtMessage.Text = "";
        }
    }
}