using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai9
{
    public partial class Xuly2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "text/xml";
            var ten = "<ten>" + Request.QueryString["txtTen"] + "</ten>";
            var hang = "<hang>" + Request.QueryString["txtHang"] + "</hang>";
            var ngay = "<ngaysx>" + Request.QueryString["dNgaySX"] + "</ngaysx>";
            var gia = "<gia>" + Request.QueryString["fGia"] + "</gia>";
            Response.Write("<?xml version='1.0' encoding='utf-8'?>");
            Response.Write("<body>" + ten + hang + ngay + gia + "</body>");
        }
    }
}