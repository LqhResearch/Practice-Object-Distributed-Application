using System;

namespace WebForm.exams
{
    public partial class edit : System.Web.UI.Page
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

                if (Request.QueryString["student-id"] != null && Request.QueryString["subject-id"] != null && Request.QueryString["times"] != null)
                {
                    string student_id = Request.QueryString["student-id"];
                    string subject_id = Request.QueryString["subject-id"];
                    int times = Convert.ToInt32(Request.QueryString["times"]);
                    Service.KetQuaThi ex = wcf.SearchExamResult(student_id, subject_id, times);

                    ddlStudents.SelectedValue = ex.MaSV;
                    ddlSubjects.SelectedValue = ex.MaMH;
                    ddlTimes.SelectedValue = ex.LanThi.ToString();
                    txtPoint.Text = ex.DiemThi.ToString();
                }
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (wcf.EditExamResult(ddlStudents.SelectedValue, ddlSubjects.SelectedValue, Convert.ToInt32(ddlTimes.SelectedValue), Convert.ToDouble(txtPoint.Text)))
                Response.Redirect("/exams/list.aspx");
            else
                lblMessage.Text = "<div class='alert alert-danger'><strong>Lỗi</strong> Sửa thất bại</div>";
        }
    }
}