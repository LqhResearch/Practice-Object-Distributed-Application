using System;

namespace WebForm
{
    public partial class Add : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Initial();
            }
        }

        public void Initial()
        {
            ddlMaNQL.DataSource = wcf.GetEmployee();
            ddlMaNQL.DataTextField = "MANV";
            ddlMaNQL.DataValueField = "MANV";
            ddlMaNQL.DataBind();
            ddlMaPhong.DataSource = wcf.GetRoom();
            ddlMaPhong.DataTextField = "MAPHONG";
            ddlMaPhong.DataValueField = "MAPHONG";
            ddlMaPhong.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            wcf.AddEmployee(txtMaNV.Text, txtHo.Text, txtTenLot.Text, txtTen.Text, Convert.ToDateTime(txtNgaySinh.Text), ddlPhai.SelectedValue.ToString(), txtDiaChi.Text, Convert.ToDecimal(txtHSLuong.Text), ddlMaNQL.SelectedValue, Convert.ToInt32(ddlMaPhong.SelectedValue));
            Response.Redirect("/Default.aspx");
        }
    }
}