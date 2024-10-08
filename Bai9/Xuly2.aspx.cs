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
            if (!IsPostBack)
            {
                string ten = Request.QueryString["txtTen"];
                string hang = Request.QueryString["txtHang"];
                string ngay = Request.QueryString["dNgaySX"];
                string gia = Request.QueryString["fGia"];
                Response.Write("Ten: " + ten + "<br>Hang: " + hang + "<br>Ngay: " + ngay + "<br>Gia: " + gia);

            }
        }
    }
}