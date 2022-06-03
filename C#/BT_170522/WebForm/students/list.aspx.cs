using System;
using System.Collections.Generic;

namespace WebForm.students
{
    public partial class list : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["del-student-id"] != null)
                {
                    string student_id = Request.QueryString["del-student-id"];
                    if (wcf.DeleteStudent(student_id))
                        lblMessage.Text = "<div class='alert alert-success'><strong>Thành công</strong> Xoá thành công</div>";
                    else
                        lblMessage.Text = "<div class='alert alert-danger'><strong>Lỗi</strong> Xoá thất bại</div>";
                }

                rptStudentsList.DataSource = wcf.GetStudents();
                rptStudentsList.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            List<Service.SinhVien> list = new List<Service.SinhVien>(wcf.SearchKeywordStudents(txtSearch.Text));
            rptStudentsList.DataSource = list;
            rptStudentsList.DataBind();

            lblNoData.Text = (list.Count == 0) ? "<tr><td colspan='100%' class='text-center'>Không có dữ liệu</td></tr>" : "";
        }
    }
}