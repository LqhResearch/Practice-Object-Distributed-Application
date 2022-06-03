using System;

namespace WebForm.subjects
{
    public partial class edit : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["subject-id"] != null)
                {
                    string subject_id = Request.QueryString["subject-id"];
                    Service.MonHoc s = wcf.SearchSubject(subject_id);

                    txtID.Text = s.MaMH;
                    txtName.Text = s.TenMH;
                }
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (wcf.EditSubject(txtID.Text, txtName.Text))
                Response.Redirect("/subjects/list.aspx");
            else
                lblMessage.Text = "<div class='alert alert-danger'><strong>Lỗi</strong> Sửa thất bại</div>";
        }
    }
}