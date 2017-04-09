using ConnectorDesigner.App.Dbcontext;
using ConnectorDesigner.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json.Linq;
using iTextSharp.text.html.simpleparser;

namespace ConnectorDesigner.App.Controllers
{
    public class ConnectorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        //
        // GET: /Connector/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Configure()
        {            
            GroupViewModel data = new GroupViewModel();
            data.LeftEnds = db.LeftEnds.ToList();
            data.RightEnds = db.RightEnds.ToList();
            data.Cables = db.Cables.ToList();
            data.LeftTypes = db.LeftConnectorTypes.ToList();
            data.RightTypes = db.RightConnectorTypes.ToList();
            return View(data);
        }

        public ActionResult Export()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Export(MailSender model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>{1}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress(model.RecipentEmail));  // replace with valid value 
                message.From = new MailAddress("rostermanagementapp@gmail.com");  // replace with valid value
                message.Subject = "configuration data sheet of designed cable";
                message.Body = string.Format(body, model.RecipentEmail,  model.Message);
                message.Attachments.Add(new Attachment(HttpContext.Server.MapPath("~/content/configuration.pdf")));
                message.IsBodyHtml = true;
                try
                {
                    var smtp = new SmtpClient();
                    var credential = new NetworkCredential
                    {
                        UserName = "rostermanagementapp@gmail.com",  // replace with valid value
                        Password = "Brainstation23"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.Send(message);
                    return RedirectToAction("Configure");
                    
                }catch(Exception ex){

                    string path = Server.MapPath("~/content/errorLog.txt");
                    // This text is added only once to the file.
                    if (!System.IO.File.Exists(path))
                    {
                        // Create a file to write to.
                        using (StreamWriter sw = System.IO.File.CreateText(path))
                        {
                            sw.WriteLine("Exception Message: " + ex.Message);
                            sw.WriteLine("Inner Exception: " + ex.InnerException);                           
                        }
                    }

                    // This text is always added, making the file longer over time
                    // if it is not deleted.
                    using (StreamWriter sw = System.IO.File.AppendText(path))
                    {
                        sw.WriteLine("Exception Message: " + ex.Message);
                        sw.WriteLine("Inner Exception: " + ex.InnerException);
                    }
                    return View(model);
                }                               
               
            }
            return View(model);
        }

        [HttpPost]
        public JsonResult GetLeftImages(int id)
        {
            var images = db.LeftEnds.Where(x => x.Id == id).Select(x=> x.Images).ToList();
            return Json(images);
        }

        [HttpPost]
        public JsonResult GetRightImages(int id)
        {
            var images = db.RightEnds.Where(x => x.Id == id).Select(x => x.Images).ToList();
            return Json(images);
        }

        [HttpPost]
        public JsonResult GetCableById( int id)
        {
            var cable = db.Cables.Include("Images").Where(x => x.Id == id).SingleOrDefault();
            return Json(cable);
        }

        [HttpPost]
        public JsonResult GetLeftConnectorType(int id)
        {
            var connectorType = db.LeftConnectorTypes.Include("Image").Where(x => x.Id == id).Select(x=> new
            {
                x.Id,
                x.Type,
                x.Image
            }).SingleOrDefault();

            return Json(connectorType);
        }

        [HttpPost]
        public JsonResult GetRightConnectorType(int id)
        {
            var connectorType = db.RightConnectorTypes.Include("Image").Where(x => x.Id == id).Select(x => new
            {
                x.Id,
                x.Type,
                x.Image
            }).SingleOrDefault();

            return Json(connectorType);
        }

        [HttpPost]
        public JsonResult UploadLeftEndConnector(int id)
        {
            if (id == 0)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json("no left end connector selected");
            }
            ConnectorDesigner.App.Models.File dbfile = new ConnectorDesigner.App.Models.File();
            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFileBase file = Request.Files[i]; //Uploaded file
                //Use the following properties to get file's name, size and MIMEType
                int fileSize = file.ContentLength;
                string fileName = file.FileName;
                string mimeType = file.ContentType;
                System.IO.Stream fileContent = file.InputStream;
                //To save file, use SaveAs method              
                string fullpath = Server.MapPath("~/content/connector/") + fileName;
                file.SaveAs(fullpath); //File will be saved in application root

                dbfile.Name = fileName;
                dbfile.RelativePath = "/content/connector/" + fileName;
                dbfile.MimeType = mimeType;
                dbfile.Size = fileSize;

                var leftend = db.LeftEnds.Include("Images").Where(x => x.Id == id).SingleOrDefault();
                leftend.Images.Add(dbfile);               
                db.Entry(leftend).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();               
            }           
            
            return Json("Image " + Request.Files.Count + " uploaded successfully;");
        }

        public JsonResult UploadRightEndConnector(int id)
        {
            if (id == 0)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json("no right end connector selected");
            }
            ConnectorDesigner.App.Models.File dbfile = new ConnectorDesigner.App.Models.File();
            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFileBase file = Request.Files[i]; //Uploaded file
                //Use the following properties to get file's name, size and MIMEType
                int fileSize = file.ContentLength;
                string fileName = file.FileName;
                string mimeType = file.ContentType;
                System.IO.Stream fileContent = file.InputStream;
                //To save file, use SaveAs method              
                string fullpath = Server.MapPath("~/content/connector/") + fileName;
                file.SaveAs(fullpath); //File will be saved in application root

                dbfile.Name = fileName;
                dbfile.RelativePath = "/content/connector/" + fileName;
                dbfile.MimeType = mimeType;
                dbfile.Size = fileSize;

                var rightend = db.RightEnds.Include("Images").Where(x => x.Id == id).SingleOrDefault();
                rightend.Images.Add(dbfile);
                db.Entry(rightend).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            return Json("Image " + Request.Files.Count + " uploaded successfully;");
        }

        [HttpPost]
        public JsonResult SaveDesign()
        {
            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFileBase file = Request.Files[i]; //Uploaded file
                //Use the following properties to get file's name, size and MIMEType
                int fileSize = file.ContentLength;
                string fileName = "configuration";
                string mimeType = file.ContentType;
                System.IO.Stream fileContent = file.InputStream;
                //To save file, use SaveAs method              
                string fullpath = Server.MapPath("~/content/") + fileName+".pdf";
                file.SaveAs(fullpath); //File will be saved in application root

            }    

            return Json("success");
        }

        public ActionResult GetConfigurationPDF()
        {
            //string filename = "configuration.pdf";
            string filePath = Server.MapPath("~/content/configuration.pdf");
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            return File(fs, "application/pdf");
        }

        public ActionResult GetConnectedRightEndList(int id)
        {
            var nameList = db.ConnectedRightEnds.Where(x => x.LeftEnd.Id == id).ToList();
            var query = from a in nameList
                        join b in db.RightEnds on a.Name equals b.Name
                        select new
                        {
                            b.Id,
                            b.Name
                        };
            return Json(query);
        }

        public ActionResult GetConnectedLeftEndList(int id)
        {
            var nameList = db.ConnectedLeftEnds.Where(x => x.RightEnd.Id == id).ToList();
            var query = from a in nameList
                        join b in db.LeftEnds on a.Name equals b.Name
                        select new
                        {
                            b.Id,
                            b.Name
                        };
            return Json(query);
        }

        public void GeneratePDF( string model)
        {
            string json = model.Replace(System.Environment.NewLine, "");
            PdfInformation result = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<PdfInformation>(json);
            //JObject o = JObject.Parse(json);

            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFileBase file = Request.Files[i]; 
                int fileSize = file.ContentLength;                
                string mimeType = file.ContentType;
                Stream fileContent = file.InputStream;                            
                string fullpath = Server.MapPath("~/content/Image.png");
                file.SaveAs(fullpath); 
            }

            FileStream fs = new FileStream(Server.MapPath("~/content/configuration.pdf"), FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);

            doc.Open();            

            BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
            Paragraph p1 = new Paragraph("Tactron assembly data sheet", new Font(bfTimes, 18, Font.ITALIC, new Color(165, 42, 42)));
            p1.Alignment = 1;                   
            doc.Add(p1);
          
            Paragraph p2 = new Paragraph("Flexible RF Cables", new Font(bfTimes, 16, Font.ITALIC, new Color(165, 42, 42)));
            p2.Alignment = 1;     
            doc.Add(p2);

            var logo = Image.GetInstance(Server.MapPath("~/content/image/tactron-logo-claim.png"));
            logo.ScaleToFit(140f, 60f);           
            logo.SetAbsolutePosition(50, doc.PageSize.Height-80);
            doc.Add(logo);

            doc.Add(Chunk.NEWLINE);           
            string message = "Configuration : " + result.ConfigName + "   " + DateTime.Now.ToShortDateString();
            Paragraph p3 = new Paragraph(message, new Font(bfTimes, 16, Font.ITALIC, Color.BLUE ));
            p3.Alignment = 1;           
            doc.Add(p3);

            var connector = Image.GetInstance(Server.MapPath("~/content/Image.png"));
            connector.ScaleToFit(400f, 200f);
            connector.Border = Rectangle.BOX;
            connector.BorderColor = new Color(173, 216, 230);
            connector.BorderWidth = (float)0.5;
            connector.Alignment = 1;           
            doc.Add(connector);

            AddPartsListTable(doc, result);
            AddSpecificationTable(doc, result);

            doc.Close();
        }

        private void AddPartsListTable(Document doc, PdfInformation result)
        {
            doc.Add(Chunk.NEWLINE);
            PdfPTable table = new PdfPTable(5);
            PdfPCell header = new PdfPCell(new Phrase("Parts List "));
            header.Colspan = 5;
            header.HorizontalAlignment = 0;
            header.BackgroundColor = new Color(173, 216, 230);
            table.AddCell(header);

            float[] widths = new float[] { 50f, 130f, 70f, 180f, 150f };
            table.SetWidths(widths);

            PdfPCell h1 = new PdfPCell(new Phrase("Item "));
            h1.BackgroundColor = new Color(225, 240, 245);

            PdfPCell h2 = new PdfPCell(new Phrase("Product "));
            h2.BackgroundColor = new Color(225, 240, 245);

            PdfPCell h3 = new PdfPCell(new Phrase("Quantity "));
            h3.BackgroundColor = new Color(225, 240, 245);

            PdfPCell h4 = new PdfPCell(new Phrase("Description "));
            h4.BackgroundColor = new Color(225, 240, 245);

            PdfPCell h5 = new PdfPCell(new Phrase("Huber + Suhner Type "));
            h5.BackgroundColor = new Color(225, 240, 245);

            Cable cable = db.Cables.Where(x => x.Id == result.CableId).SingleOrDefault();
            LeftConnectorType lct = db.LeftConnectorTypes.Where(x => x.Id == result.LeftConnectorTypeId).SingleOrDefault();
            RightConnectorType rct = db.RightConnectorTypes.Where(x => x.Id == result.RightConnectorTypeId).SingleOrDefault();

            table.AddCell(h1);
            table.AddCell(h2);
            table.AddCell(h3);
            table.AddCell(h4);
            table.AddCell(h5);

            table.AddCell("1");
            table.AddCell("Cable");
            table.AddCell(result.Length + " " + result.Unit);
            table.AddCell(cable.Description);
            table.AddCell(cable.Type);

            table.AddCell("2");
            table.AddCell("Connector Type Left");
            table.AddCell(" 1 Pce ");
            table.AddCell("Straight Plug");
            table.AddCell(lct.Type);


            table.AddCell("3");
            table.AddCell("Connector Type Right");
            table.AddCell(" 1 Pce ");
            table.AddCell("Straight Plug");
            table.AddCell(rct.Type);

            doc.Add(table);
        }

        private void AddSpecificationTable(Document doc, PdfInformation result)
        {
            doc.Add(Chunk.NEWLINE);
            PdfPTable table = new PdfPTable(5);
            PdfPCell header = new PdfPCell(new Phrase("Specification List "));
            header.Colspan = 5;
            header.HorizontalAlignment = 0;
            header.BackgroundColor = new Color(173, 216, 230);
            table.AddCell(header);

            float[] widths = new float[] { 50f, 150f, 90f, 90f, 200f };
            table.SetWidths(widths);

            PdfPCell h1 = new PdfPCell(new Phrase("Item "));
            h1.BackgroundColor = new Color(225, 240, 245);

            PdfPCell h2 = new PdfPCell(new Phrase("Product "));
            h2.BackgroundColor = new Color(225, 240, 245);

            PdfPCell h3 = new PdfPCell(new Phrase("Frequency "));
            h3.BackgroundColor = new Color(225, 240, 245);

            PdfPCell h4 = new PdfPCell(new Phrase("Impedence "));
            h4.BackgroundColor = new Color(225, 240, 245);

            PdfPCell h5 = new PdfPCell(new Phrase("Product details "));
            h5.BackgroundColor = new Color(225, 240, 245);

            Cable cable = db.Cables.Where(x => x.Id == result.CableId).SingleOrDefault();
            LeftConnectorType lct = db.LeftConnectorTypes.Where(x => x.Id == result.LeftConnectorTypeId).SingleOrDefault();
            RightConnectorType rct = db.RightConnectorTypes.Where(x => x.Id == result.RightConnectorTypeId).SingleOrDefault();

            table.AddCell(h1);
            table.AddCell(h2);
            table.AddCell(h3);
            table.AddCell(h4);
            table.AddCell(h5);

            table.AddCell("1");
            table.AddCell("Cable");
            table.AddCell(cable.OperationFreq);
            table.AddCell(cable.Impediments);
            table.AddCell(cable.ProductDetails);

            table.AddCell("2");
            table.AddCell("Connector Type Left");
            table.AddCell(lct.InterfaceFreq);
            table.AddCell(lct.Impediment);
            table.AddCell(lct.ProductDetails);


            table.AddCell("3");
            table.AddCell("Connector Type Right");
            table.AddCell(rct.InterfaceFreq);
            table.AddCell(rct.Impediment);
            table.AddCell(rct.ProductDetails);

            doc.Add(table);
        }

       

    }
}