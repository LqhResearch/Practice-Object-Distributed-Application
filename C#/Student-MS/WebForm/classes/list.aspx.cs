using System;

namespace WebForm.classes
{
    public partial class list : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                rptClassesList.DataSource = wcf.HienThiLop();
                rptClassesList.DataBind();
            }
        }
    }
}