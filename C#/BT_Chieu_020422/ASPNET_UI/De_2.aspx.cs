using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET_UI
{
    public partial class De_2 : System.Web.UI.Page
    {
        Service.ServiceClient wcf = new Service.ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAns_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int c = int.Parse(txtC.Text);
            txtMessage.Text = wcf.QuadraticEquation(a, b, c);
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Text = txtB.Text = txtC.Text = txtMessage.Text = "";
        }

        protected void btnAns1_Click(object sender, EventArgs e)
        {
            int f = int.Parse(txtFacto.Text);
            txtMessage1.Text = f + "! = " + wcf.Factorial(f).ToString();
        }

        protected void btnReset1_Click(object sender, EventArgs e)
        {
            txtFacto.Text = txtMessage1.Text = "";
        }

        protected void btnAns2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtOddEven.Text);
            txtMessage2.Text = wcf.CheckOddEvenNumber(n);
        }

        protected void btnReset2_Click(object sender, EventArgs e)
        {
            txtOddEven.Text = txtMessage2.Text = "";
        }
    }
}