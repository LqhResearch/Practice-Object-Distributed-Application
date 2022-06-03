using System;
using System.Collections.Generic;

namespace WebForm.subjects
{
    public partial class list : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["del-subject-id"] != null)
                {
                    string subject_id = Request.QueryString["del-subject-id"];
                    if (wcf.DeleteSubject(subject_id))
                        lblMessage.Text = "<div class='alert alert-success'><strong>Thành công</strong> Xoá thành công</div>";
                    else
                        lblMessage.Text = "<div class='alert alert-danger'><strong>Lỗi</strong> Xoá thất bại</div>";
                }

                rptSubjectsList.DataSource = wcf.GetSubjects();
                rptSubjectsList.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            List<Service.MonHoc> list = new List<Service.MonHoc>(wcf.SearchKeywordSubjects(txtSearch.Text));
            rptSubjectsList.DataSource = list;
            rptSubjectsList.DataBind();

            lblNoData.Text = (list.Count == 0) ? "<tr><td colspan='100%' class='text-center'>Không có dữ liệu</td></tr>" : "";
        }
    }
}