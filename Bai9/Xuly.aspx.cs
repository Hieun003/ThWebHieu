using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Bai9
{
    public partial class Xuly : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            /*string ten = Request.Form["txtTen"];
            string hang = Request.Form["txtHang"];
            string ngay =  Request.Form["dNgaySX"];
            string gia =  Request.Form["fGia"];
            writeXML()*/
            /*string path = @"D://hihi.xml";*/



            Response.ContentType = "text/xml";
            var ten = "<ten>" + Request.Form["txtTen"] + "</ten>";
            var hang = "<hang>" + Request.Form["txtHang"] + "</hang>";
            var ngay = "<ngaysx>" + Request.Form["dNgaySX"] + "</ngaysx>";
            var gia = "<gia>" + Request.Form["fGia"] + "</gia>";
            Response.Write("<?xml version='1.0' encoding='utf-8'?>");
            Response.Write("<body>" + ten + hang + ngay + gia + "</body>");

        }
        
    }
}