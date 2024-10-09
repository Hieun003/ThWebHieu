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
        public static void writeXML(string path, string tenvxl, string hang, string date, string price)
        {
            if (!File.Exists(path))
            {
                XmlDocument doc = new XmlDocument();
                XmlElement root = doc.CreateElement("Chips");
                XmlElement Chip = doc.CreateElement("Chip");
                XmlElement tenVXL = doc.CreateElement("TenVXL");
                tenVXL.InnerText = tenvxl;
                Chip.AppendChild(tenVXL);
                XmlElement Hang = doc.CreateElement("Hang");
                Hang.InnerText = hang;
                Chip.AppendChild(Hang);
                XmlElement Date = doc.CreateElement("Date");
                Date.InnerText = date;
                Chip.AppendChild(Date);
                XmlElement Price = doc.CreateElement("Price");
                Price.InnerText = price;
                Chip.AppendChild(Price);
                root.AppendChild(Chip);
                doc.AppendChild(root);
                doc.Save(path);
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlElement Chip = doc.CreateElement("Chip");
                XmlElement tenVXL = doc.CreateElement("TenVXL");
                tenVXL.InnerText = tenvxl;
                Chip.AppendChild(tenVXL);
                XmlElement Hang = doc.CreateElement("Hang");
                Hang.InnerText = hang;
                Chip.AppendChild(Hang);
                XmlElement Date = doc.CreateElement("Date");
                Date.InnerText = date;
                Chip.AppendChild(Date);
                XmlElement Price = doc.CreateElement("Price");
                Price.InnerText = price;
                Chip.AppendChild(Price);
                doc.DocumentElement.AppendChild(Chip);
                doc.Save(path);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = "D://hieu.xml";
            string ten = Request.Form["txtTen"];
            string hang = Request.Form["txtHang"];
            string ngay =  Request.Form["dNgaySX"];
            string gia =  Request.Form["fGia"];

            writeXML(path, ten, hang, ngay, gia);

            //string path = "D://hieu.xml";

            //var ten = "<ten>" + Request.Form["txtTen"] + "</ten>";
            //var hang = "<hang>" + Request.Form["txtHang"] + "</hang>";
            //var ngay = "<ngaysx>" + Request.Form["dNgaySX"] + "</ngaysx>";
            //var gia = "<gia>" + Request.Form["fGia"] + "</gia>";
            ////Response.Write("<?xml version='1.0' encoding='utf-8'?>");
            ////Response.Write("<body>" + ten + hang + ngay + gia + "</body>");

        }
        
    }
}