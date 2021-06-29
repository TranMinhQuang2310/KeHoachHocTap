using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo_Login2.Areas.AdminPage.Data;

namespace Demo_Login2.Areas.AdminPage.Controllers
{
    public class TaiKhoanController : Controller
    {
        // GET: AdminPage/TaiKhoan
        public ActionResult Index()
        {
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //ViewData.Model = cars.AsEnumerable();
            IList<Student> studentList = new List<Student>();
            studentList.Add(new Student() { StudentName = "Bill", StudentClass = "2B" });
            studentList.Add(new Student() { StudentName = "Steve", StudentClass = "9S" });
            return View(studentList);
        }
    }
}