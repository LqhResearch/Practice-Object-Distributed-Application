using System;
using System.Collections.Generic;

namespace WebForm.classes
{
    public partial class list : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["del-class-id"] != null)
                {
                    string class_id = Request.QueryString["del-class-id"];
                    if (wcf.DeleteClass(class_id))
                        lblMessage.Text = "<div class='alert alert-success'><strong>Thành công</strong> Xoá thành công</div>";
                    else
                        lblMessage.Text = "<div class='alert alert-danger'><strong>Lỗi</strong> Xoá thất bại</div>";
                }

                rptClassesList.DataSource = wcf.GetClasses();
                rptClassesList.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            List<Service.Lop> list = new List<Service.Lop>(wcf.SearchKeywordClasses(txtSearch.Text));
            rptClassesList.DataSource = list;
            rptClassesList.DataBind();

            lblNoData.Text = (list.Count == 0) ? "<tr><td colspan='100%' class='text-center'>Không có dữ liệu</td></tr>" : "";
        }
    }
}