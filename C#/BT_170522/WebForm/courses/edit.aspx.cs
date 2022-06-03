using System;

namespace WebForm.courses
{
    public partial class edit : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["course-id"] != null)
                {
                    string course_id = Request.QueryString["course-id"];
                    Service.KhoaHoc c = wcf.SearchCourse(course_id);

                    txtID.Text = c.MaKH;
                    txtName.Text = c.TenKH;
                    ddlEducation.SelectedValue = c.MaCTDT;
                }
                ddlEducation.DataSource = wcf.GetEducates();
                ddlEducation.DataValueField = "MaCTDT";
                ddlEducation.DataTextField = "TenCTDT";
                ddlEducation.DataBind();
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (wcf.EditCourse(txtID.Text, txtName.Text, ddlEducation.SelectedValue))
                Response.Redirect("/courses/list.aspx");
            else
                lblMessage.Text = "<div class='alert alert-danger'><strong>Lỗi</strong> Sửa thất bại</div>";
        }
    }
}