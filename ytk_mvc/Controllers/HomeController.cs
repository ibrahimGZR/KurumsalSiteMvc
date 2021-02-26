using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ytk_mvc.DAL;
using ytk_mvc.Models;

namespace ytk_mvc.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Products()
        {
            ViewBag.Message = "Your product page.";

            return View();
        }
        public ActionResult Projects()
        {
            var projects = _context.Projects
                            .Where(i => i.IsVisible == true)
                            .Select(i => new ProjectModel()
                            {   
                                Id=i.Id,
                                Name=i.Name,
                                Description=i.Description,
                                Date=i.Date,
                                Price=i.Price,
                                CategoryId=i.CategoryId,
                                ClientId=i.ClientId,
                                ImageFolderId=i.ImageFolderId
                            }).ToList();

            return View(projects);
        }

        public ActionResult Details()
        {
            ViewBag.Message = "Your details page.";

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your description page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}