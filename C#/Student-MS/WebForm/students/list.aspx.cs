using System;

namespace WebForm.students
{
    public partial class list : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["del-mssv"] != null)
                {
                    string mssv = Request.QueryString["del-mssv"];
                    if(!wcf.XoaSinhVien(mssv))
                        lblMessage.Text = "<div class='alert alert-danger' role='alert'>Xóa thất bại. Vui lòng kiểm tra lại.</div>";
                }

                rptStudentsList.DataSource = wcf.HienThiSinhVien();
                rptStudentsList.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            rptStudentsList.DataSource = wcf.TimKiemSinhVien(keyword);
            rptStudentsList.DataBind();
        }
    }
}