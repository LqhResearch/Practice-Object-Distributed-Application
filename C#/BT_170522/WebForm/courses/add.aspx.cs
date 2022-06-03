using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm.courses
{
    public partial class add : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlEducation.DataSource = wcf.GetEducates();
                ddlEducation.DataValueField = "MaCTDT";
                ddlEducation.DataTextField = "TenCTDT";
                ddlEducation.DataBind();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (wcf.AddCourse(txtID.Text, txtName.Text, ddlEducation.SelectedValue))
                Response.Redirect("/courses/list.aspx");
            else
                lblMessage.Text = "<div class='alert alert-danger'><strong>Lỗi</strong> Thêm thất bại</div>";
        }
    }
}