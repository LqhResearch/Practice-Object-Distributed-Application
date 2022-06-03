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
                if (Request.QueryString["class-id"] != null)
                {
                    string class_id = Request.QueryString["class-id"];
                    Service.Lop c = wcf.SearchClass(class_id);

                    txtID.Text = c.MaLop;
                    txtName.Text = c.TenLop;
                    ddlCourses.SelectedValue = c.MaKH;
                }
                ddlCourses.DataSource = wcf.GetCourses();
                ddlCourses.DataValueField = "MaKH";
                ddlCourses.DataTextField = "TenKH";
                ddlCourses.DataBind();
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (wcf.EditClass(txtID.Text, txtName.Text, ddlCourses.SelectedValue))
                Response.Redirect("/classes/list.aspx");
            else
                lblMessage.Text = "<div class='alert alert-danger'><strong>Lỗi</strong> Sửa thất bại</div>";
        }
    }
}