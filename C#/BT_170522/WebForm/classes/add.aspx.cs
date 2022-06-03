using System;

namespace WebForm.classes
{
    public partial class add : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCourses.DataSource = wcf.GetCourses();
                ddlCourses.DataValueField = "MaKH";
                ddlCourses.DataTextField = "TenKH";
                ddlCourses.DataBind();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (wcf.AddClass(txtID.Text, txtName.Text, ddlCourses.SelectedValue))
                Response.Redirect("/classes/list.aspx");
            else
                lblMessage.Text = "<div class='alert alert-danger'><strong>Lỗi</strong> Thêm thất bại</div>";
        }
    }
}