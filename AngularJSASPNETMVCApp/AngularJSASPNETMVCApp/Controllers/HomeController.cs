using AngularJSASPNETMVCApp.DAL;
using AngularJSASPNETMVCApp.POCO;
using AngularJSASPNETMVCApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJSASPNETMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IndexViewModel indexViewModel = new IndexViewModel();
            return View(indexViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult GetBooks()
        {
            BookDAO bookDAO = new BookDAO();
            return Json(bookDAO.getBooks(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult AddBook(Book aNewBook)
        {
            BookDAO bookDAO = new BookDAO();
            bookDAO.AddBook(aNewBook);
            return null;
        }


    }
}