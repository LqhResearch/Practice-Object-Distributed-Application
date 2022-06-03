using System;

namespace WebForm.education
{
    public partial class edit : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["educate-id"] != null)
                {
                    string educate_id = Request.QueryString["educate-id"];
                    Service.CT_DaoTao ed = wcf.SearchEducate(educate_id);

                    txtID.Text = ed.MaCTDT;
                    txtName.Text = ed.TenCTDT;
                }
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (wcf.EditEducate(txtID.Text, txtName.Text))
                Response.Redirect("/education/list.aspx");
            else
                lblMessage.Text = "<div class='alert alert-danger'><strong>Lỗi</strong> Sửa thất bại</div>";
        }
    }
}