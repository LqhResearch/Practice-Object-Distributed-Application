using System;

namespace WebForm
{
    public partial class Update : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Initial();
                if (Request.QueryString["id"] != null)
                {
                    string id = Request.QueryString["id"];
                    Service.NHANVIEN nv = wcf.SearchEmployee(id);
                    txtMaNV.Text = nv.MANV;
                    txtHo.Text = nv.HONV;
                    txtTenLot.Text = nv.TENLOTNV;
                    txtTen.Text = nv.TENNV;
                    txtNgaySinh.Text = nv.NGAYSINH.Value.ToString("yyyy-MM-dd");
                    txtDiaChi.Text = nv.DIACHI;
                    ddlPhai.SelectedValue = nv.PHAI.ToString().Trim();
                    txtHSLuong.Text = nv.HSLUONG.ToString();
                    ddlMaNQL.SelectedValue = nv.MANQL.ToString();
                    ddlMaPhong.SelectedValue = nv.MAPHONG.ToString();
                }
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

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            wcf.UpdateEmployee(txtMaNV.Text, txtHo.Text, txtTenLot.Text, txtTen.Text, Convert.ToDateTime(txtNgaySinh.Text), ddlPhai.SelectedValue.ToString(), txtDiaChi.Text, Convert.ToDecimal(txtHSLuong.Text), ddlMaNQL.SelectedValue, Convert.ToInt32(ddlMaPhong.SelectedValue));
            Response.Redirect("/Default.aspx");
        }
    }
}