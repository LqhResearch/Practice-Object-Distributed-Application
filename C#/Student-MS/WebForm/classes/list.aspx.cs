using System;

namespace WebForm.classes
{
    public partial class list : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["del-malop"] != null)
                {
                    string malop = Request.QueryString["del-malop"];
                    wcf.XoaLop(malop);
                }

                rptClassesList.DataSource = wcf.HienThiLop();
                rptClassesList.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            rptClassesList.DataSource = wcf.TimKiemLop(keyword);
            rptClassesList.DataBind();
        }
    }
}