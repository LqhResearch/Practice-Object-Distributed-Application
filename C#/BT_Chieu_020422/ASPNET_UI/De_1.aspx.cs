using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET_UI
{
    public partial class De_1 : System.Web.UI.Page
    {
        Service.ServiceClient wcf = new Service.ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAns_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            txtMessage.Text = wcf.SingleEquation(a, b);
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Text = txtB.Text = txtMessage.Text = "";
        }

        protected void btnAns1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            txtMessage1.Text = wcf.IsPrime(n) ? n + " là số nguyên tố" : n + " không phải là số nguyên tố";
        }

        protected void btnReset1_Click(object sender, EventArgs e)
        {
            txtN.Text = txtMessage1.Text = "";
        }
    }
}