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
                ddlClassID.DataSource = wcf.HienThiLop();
                ddlClassID.DataValueField = "MaLop";
                ddlClassID.DataTextField = "TenLop";
                ddlClassID.DataBind();

                if (Request.QueryString["mssv"] != null)
                {
                    string mssv = Request.QueryString["mssv"];
                    Service.SinhVien sv = wcf.TimSinhVien(mssv);

                    txtID.Text = sv.MSSV;
                    txtName.Text = sv.HoTen;
                    txtAddress.Text = sv.QueQuan;
                    txtBirth.Text = sv.NamSinh.ToString();
                    ddlGender.SelectedValue = sv.GioiTinh;
                    ddlClassID.SelectedValue = sv.MaLop;
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (wcf.SuaSinhVien(txtID.Text, txtName.Text, txtAddress.Text, Convert.ToInt32(txtBirth.Text), ddlGender.SelectedValue, ddlClassID.SelectedValue))
                Response.Redirect("list.aspx");
            else
                lblMessage.Text = "<div class='alert alert-danger' role='alert'>Lưu thất bại. Vui lòng kiểm tra lại.</div>";
        }
    }
}