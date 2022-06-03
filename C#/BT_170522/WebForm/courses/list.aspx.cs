using System;
using System.Collections.Generic;

namespace WebForm.courses
{
    public partial class list : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["del-course-id"] != null)
                {
                    string course_id = Request.QueryString["del-course-id"];
                    if (wcf.DeleteCourse(course_id))
                        lblMessage.Text = "<div class='alert alert-success'><strong>Thành công</strong> Xoá thành công</div>";
                    else
                        lblMessage.Text = "<div class='alert alert-danger'><strong>Lỗi</strong> Xoá thất bại</div>";
                }

                rptCoursesList.DataSource = wcf.GetCourses();
                rptCoursesList.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            List<Service.KhoaHoc> list = new List<Service.KhoaHoc>(wcf.SearchKeywordCourses(txtSearch.Text));
            rptCoursesList.DataSource = list;
            rptCoursesList.DataBind();

            lblNoData.Text = (list.Count == 0) ? "<tr><td colspan='100%' class='text-center'>Không có dữ liệu</td></tr>" : "";
        }
    }
}