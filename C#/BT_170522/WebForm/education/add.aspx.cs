using System;

namespace WebForm.education
{
    public partial class add : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (wcf.AddEducate(txtID.Text, txtName.Text))
                Response.Redirect("/education/list.aspx");
            else
                lblMessage.Text = "<div class='alert alert-danger'><strong>Lỗi</strong> Thêm thất bại</div>";
        }
    }
}