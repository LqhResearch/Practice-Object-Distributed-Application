using System;
using System.Collections.Generic;

namespace WebForm.exams
{
    public partial class list : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["del-student-id"] != null && Request.QueryString["del-subject-id"] != null && Request.QueryString["del-times"] != null)
                {
                    string student_id = Request.QueryString["del-student-id"];
                    string subject_id = Request.QueryString["del-subject-id"];
                    int times = Convert.ToInt32(Request.QueryString["del-times"]);
                    if (wcf.DeleteExamResult(student_id, subject_id, times))
                        lblMessage.Text = "<div class='alert alert-success'><strong>Thành công</strong> Xoá thành công</div>";
                    else
                        lblMessage.Text = "<div class='alert alert-danger'><strong>Lỗi</strong> Xoá thất bại</div>";
                }

                rptExamsList.DataSource = wcf.GetExamResults();
                rptExamsList.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            List<Service.KetQuaThi> list = new List<Service.KetQuaThi>(wcf.SearchKeywordExamResults(txtSearch.Text));
            rptExamsList.DataSource = list;
            rptExamsList.DataBind();

            lblNoData.Text = (list.Count == 0) ? "<tr><td colspan='100%' class='text-center'>Không có dữ liệu</td></tr>" : "";
        }
    }
}