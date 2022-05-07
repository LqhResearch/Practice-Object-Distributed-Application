using System;

namespace WebForm.classes
{
    public partial class add : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (wcf.ThemLop(txtID.Text, txtName.Text))
                Response.Redirect("list.aspx");
            else
                lblMessage.Text = "<div class='alert alert-danger' role='alert'>Thêm thất bại. Vui lòng kiểm tra lại.</div>";
        }
    }
}