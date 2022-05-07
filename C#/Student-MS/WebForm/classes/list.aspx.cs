﻿using System;

namespace WebForm.classes
{
    public partial class list : System.Web.UI.Page
    {
        Service.Service1Client wcf = new Service.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["del-malop"] != null)
                {
                    string malop = Request.QueryString["del-malop"];
                    if (!wcf.XoaLop(malop))
                        lblMessage.Text = "<div class='alert alert-danger' role='alert'>Xóa thất bại. Vui lòng kiểm tra lại.</div>";
                }

                rptClassesList.DataSource = wcf.HienThiLop();
                rptClassesList.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            rptClassesList.DataSource = wcf.TimKiemLop(keyword);
            rptClassesList.DataBind();
        }
    }
}