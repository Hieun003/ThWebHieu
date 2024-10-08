using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai9
{
    public partial class Xuly : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string ten = Request.Form["txtTen"];
                string hang = Request.Form["txtHang"] ;
                string ngay = Request.Form["dNgaySX"];
                string gia = Request.Form["fGia"];
                Response.Write("Ten: "+ ten + "<br>Hang: " + hang + "<br>Ngay: " + ngay + "<br>Gia: " + gia );

            }
            /*Response.ContentType = "text/xml";
            string ten = "<ten>" + Request.Form["txtTen"] + "</ten>";
            string hang = "<hang>" + Request.Form["txtHang"] + "</hang>";
            string ngay = "<ngaysx>" + Request.Form["dNgaySX"] + "</ngaysx>";
            string gia = "<gia>" + Request.Form["fGia"] + "</gia>";
            Response.Write("<body>" + ten + hang + ngay + gia + "</body>");*/
        }
    }
}