using System;

namespace WebForm.students
{
    public partial class add : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlClassID.DataSource = wcf.HienThiLop();
                ddlClassID.DataValueField = "MaLop";
                ddlClassID.DataTextField = "TenLop";
                ddlClassID.DataBind();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (wcf.ThemSinhVien(txtID.Text, txtName.Text, txtAddress.Text, Convert.ToInt32(txtBirth.Text), ddlGender.SelectedValue, ddlClassID.SelectedValue))
                Response.Redirect("list.aspx");
            else
                lblMessage.Text = "<div class='alert alert-danger' role='alert'>Thêm thất bại. Vui lòng kiểm tra lại.</div>";
        }
    }
}