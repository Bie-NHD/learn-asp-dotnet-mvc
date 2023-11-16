using Lab2_WebApplication.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace Lab2_WebApplication.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult TestViewResult()
        {
            return View();
        }
        public PartialViewResult TestPartialViewResult()
        {
            return PartialView();
        }
        public EmptyResult TestEmptyResult()
        {
            return new EmptyResult();
        }
        public RedirectResult TestRedirectResult()
        {
            return Redirect("Index");
        }
        public JsonResult TestJsonResult()
        {
            List<Student> listStudent = new List<Student>();

            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Nguyễn Quang Huy",
                ClassName = "C1311L"
            });
            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Nguyễn Quang Huy",
                ClassName = "C1311J"
            });
            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Nguyễn Quang Hiển",
                ClassName = "C1311H"
            });
            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Nguyễn Duy Huân",
                ClassName = "C1311T"
            });
            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Vũ Quang Huy",
                ClassName = "C1311C"
            });
            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Trần Quang Huy",
                ClassName = "C1311L"
            });
            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Phạm Quang Huy",
                ClassName = "C1311L"
            });
            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Trịnh Quang Huy",
                ClassName = "C1311B"
            });
            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Vũ Quang Huy",
                ClassName = "C1311L"
            });
            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Vũ Minh Trịnh",
                ClassName = "C1311M"
            });

            return Json(listStudent);
        }
        //Action trả về một view là JavaScript
        //        public JavaScriptResult TestJavaScriptResult()
        //        {
        //            string js = "funtion checkEMail(){var btloc=/^([w-]+(?:.[w-]+)*)@((?:[w-]+.)*w[w-
        //]{ 0,66}).([a - z]{ 2,6} (?:.[a - z]{ 2})?)$/ i if (btloc.test(mail)) { kq = true; }
        //            else
        //            {
        //                alert(“Email
        //address invalid”); kq = false;
        //            }
        //            return kq;
        //        }";
        // return JavaScript(js);
    //Acion tra về một ContentResult dữ liệu là dạng văn bản
    public ContentResult TestContentResult()
    {
        XElement contentXML = new XElement("Students",
        new XElement("Student",
        new XElement("ID", "001"),
        new XElement("FullName", "Nguyễn Viết Nam"),
        new XElement("ClassName", "C1308H")),
        new XElement("Student", new XElement("ID", "002"),
         new XElement("FullName", "Nguyễn Hoàng Anh"),
         new XElement("ClassName", "C1411P")),
         new XElement("Student",
         new XElement("ID", "003"),
         new XElement("FullName", "Phạm Ngọc Anh"),
         new XElement("ClassName", "C1411L")),
         new XElement("Student",
         new XElement("ID", "004"),
         new XElement("FullName", "Trần Ngọc Linh"),
         new XElement("ClassName", "C1411H")),
         new XElement("Student",
         new XElement("ID", "005"),
         new XElement("FullName", "Nguyễn Hồng Anh"),
         new XElement("ClassName", "C1411L")));

        return (new ContentResult
        {
            ContentType = "text/xml",
            Content = contentXML.ToString(),
            StatusCode = 200
        });
    }
        // Cả ba kiểu FileContentResult,FileStreamResult,FilePathResult đều cho phép trình 
        // duyệt mở hộp thoại lưu file và tải file về
 // phương thức trả về có 3 tham số
 // tham số thứ nhất đối với kiểu FileContentResult là một mảng byte của file
 // tham số thứ nhất đối với kiểu FileStreamResult là một FileStream
 // tham sô thứ nhất đổi với kiểu PathFileResult là một đường dẫn file
 // tham số thứ hai chỉ ra loại định dạng của file
 // tham số thứ ba tên file mà trình duyệt sẽ tải về
 public FileContentResult TestFileContentResult()
        {
            //string _contentRootPath = AppDomain.CurrentDomain.GetData("ContentRootPath") as string;
            //byte[] fileBytes = System.IO.File.ReadAllBytes(Path.Combine(_contentRootPath, @"~/Content/demovideo.mp4"));
            byte[] fileBytes = System.IO.File.ReadAllBytes(@"~/Content/demovideo.mp4");
            string fileName = "demovideo.mp4";
            //return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
            return File(fileBytes, "video/mp4", fileName);
        }
        public FileStreamResult TestFileStreamResult()
        {
            //string _contentRootPath = AppDomain.CurrentDomain.GetData("ContentRootPath") as string;
            //string pathFile = Path.Combine(_contentRootPath, @"/Content/vonsong.docx"); //Server.MapPath("~/Content/vonsong.docx");
            string pathFile = @"~/Content/vonsong.docx"; //Server.MapPath("~/Content/vonsong.docx");
            string fileName = "vonsong.docx";
            return File(new FileStream(pathFile, FileMode.Open), "text/doc", fileName);
        }
        public FileResult TestFilePathResult()
        {
            //string _contentRootPath = AppDomain.CurrentDomain.GetData("ContentRootPath") as string;
            //string pathFile = Path.Combine(_contentRootPath,  @"/Contentvonsong.docx"); //Server.MapPath("~/Content/vonsong.docx");
            string pathFile = @"~/Content/vonsong.docx";
            string fileName = "vonsong.docx";
            return File(pathFile, "text/doc", fileName);
        }
    }
}
