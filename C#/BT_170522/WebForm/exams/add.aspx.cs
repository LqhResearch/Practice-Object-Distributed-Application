using System;

namespace WebForm.exams
{
    public partial class add : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlStudents.DataSource = wcf.GetStudents();
                ddlStudents.DataValueField = "MaSV";
                ddlStudents.DataTextField = "HoTen";
                ddlStudents.DataBind();

                ddlSubjects.DataSource = wcf.GetSubjects();
                ddlSubjects.DataValueField = "MaMH";
                ddlSubjects.DataTextField = "TenMH";
                ddlSubjects.DataBind();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (wcf.AddExamResult(ddlStudents.SelectedValue, ddlSubjects.SelectedValue, Convert.ToInt32(ddlTimes.SelectedValue), Convert.ToDouble(txtPoint.Text)))
                Response.Redirect("/exams/list.aspx");
            else
                lblMessage.Text = "<div class='alert alert-danger'><strong>Lỗi</strong> Thêm thất bại</div>";
        }
    }
}