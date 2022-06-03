using System;
using System.Collections.Generic;

namespace WebForm.education
{
    public partial class list : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["del-educate-id"] != null)
                {
                    string educate_id = Request.QueryString["del-educate-id"];
                    if (wcf.DeleteEducate(educate_id))
                        lblMessage.Text = "<div class='alert alert-success'><strong>Thành công</strong> Xoá thành công</div>";
                    else
                        lblMessage.Text = "<div class='alert alert-danger'><strong>Lỗi</strong> Xoá thất bại</div>";
                }

                rptEducationList.DataSource = wcf.GetEducates();
                rptEducationList.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            List<Service.CT_DaoTao> list = new List<Service.CT_DaoTao>(wcf.SearchKeywordEducates(txtSearch.Text));
            rptEducationList.DataSource = list;
            rptEducationList.DataBind();

            lblNoData.Text = (list.Count == 0) ? "<tr><td colspan='100%' class='text-center'>Không có dữ liệu</td></tr>" : "";
        }
    }
}