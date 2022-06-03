using System;

namespace WebForm.students
{
    public partial class edit : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlClasses.DataSource = wcf.GetClasses();
                ddlClasses.DataValueField = "MaLop";
                ddlClasses.DataTextField = "TenLop";
                ddlClasses.DataBind();

                if (Request.QueryString["student-id"] != null)
                {
                    string student_id = Request.QueryString["student-id"];
                    Service.SinhVien s = wcf.SearchStudent(student_id);

                    txtID.Text = s.MaSV;
                    txtName.Text = s.HoTen;
                    ddlGender.SelectedValue = s.GioiTinh;
                    txtBirth.Text = Convert.ToDateTime(s.NgaySinh).ToString("yyyy-MM-dd");
                    txtPlace.Text = s.NoiSinh;
                    ddlClasses.SelectedValue = s.MaLop;
                }
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (wcf.EditStudent(txtID.Text, txtName.Text, ddlGender.SelectedValue, Convert.ToDateTime(txtBirth.Text), txtPlace.Text, ddlClasses.SelectedValue))
                Response.Redirect("/students/list.aspx");
            else
                lblMessage.Text = "<div class='alert alert-danger'><strong>Lỗi</strong> Sửa thất bại</div>";
        }
    }
}