using System;

namespace WebForm.classes
{
    public partial class edit : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["malop"] != null)
                {
                    string malop = Request.QueryString["malop"];
                    Service.Lop lop = wcf.TimLop(malop);

                    txtID.Text = lop.MaLop;
                    txtName.Text = lop.TenLop;
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (wcf.SuaLop(txtID.Text, txtName.Text))
                Response.Redirect("list.aspx");
            else
                lblMessage.Text = "<div class='alert alert-danger' role='alert'>Lưu thất bại. Vui lòng kiểm tra lại.</div>";
        }
    }
}