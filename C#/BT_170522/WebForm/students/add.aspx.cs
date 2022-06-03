using System;

namespace WebForm.students
{
    public partial class add : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlClasses.DataSource = wcf.GetClasses();
                ddlClasses.DataValueField = "MaLop";
                ddlClasses.DataTextField = "TenLop";
                ddlClasses.DataBind();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (wcf.AddStudent(txtID.Text, txtName.Text, ddlGender.SelectedValue, Convert.ToDateTime(txtBirth.Text), txtPlace.Text, ddlClasses.SelectedValue))
                Response.Redirect("/students/list.aspx");
            else
                lblMessage.Text = "<div class='alert alert-danger'><strong>Lỗi</strong> Thêm thất bại</div>";
        }
    }
}