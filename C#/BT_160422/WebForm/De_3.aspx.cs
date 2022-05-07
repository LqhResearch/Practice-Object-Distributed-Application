﻿using System;

namespace WebForm
{
    public partial class De_3 : System.Web.UI.Page
    {
        Service.ServiceClient wcf = new Service.ServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int[] arr =
            {
                Convert.ToInt32(txtNum1.Text),
                Convert.ToInt32(txtNum2.Text),
                Convert.ToInt32(txtNum3.Text),
                Convert.ToInt32(txtNum4.Text),
                Convert.ToInt32(txtNum5.Text),
                Convert.ToInt32(txtNum6.Text),
                Convert.ToInt32(txtNum7.Text),
            };
            txtAns.Text = "Mảng: " + wcf.PrintArray(wcf.Sort_OddNumberDescending_EvenNumberAscending(arr));
            txtAns1.Text = "Tổng của mảng: " +wcf.SumArray(arr);
        }
    }
}