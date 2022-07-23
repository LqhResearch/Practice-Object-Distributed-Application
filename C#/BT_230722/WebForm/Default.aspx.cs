using System;

namespace WebForm
{
    public partial class Default : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rptList.DataSource = wcf.GetEmployee();
                rptList.DataBind();
            }
        }
    }
}