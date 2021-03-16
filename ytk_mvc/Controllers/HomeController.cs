using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ytk_mvc.DAL;
using ytk_mvc.Models;
using ytk_mvc.Entity;
using System.Data.Entity;

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
            var category = _context.Categories
                            .Where(i => i.IsVisible == true)
                            .Select(i => new CategoryModel()
                            {
                                Id = i.Id,
                                Name = i.Name,
                                Description = i.Description

                            }).ToList();
                            

            var projects = _context.Projects
                           .Include(p => p.Categories)
                           .Include(p => p.Clients)
                           .Include(p => p.ImageFolders)
                           .Where(i => i.IsVisible == true)
                           .Select(i => new ProjectModel()
                           {
                               Id = i.Id,
                               Name = i.Name,
                               Description = i.Description,
                               Date = i.Date,
                               Price = i.Price,
                               CategoryId = i.CategoryId,
                               Categories = i.Categories,
                               ClientId = i.ClientId,
                               Clients = i.Clients,
                               ImageFolderId = i.ImageFolderId,
                               ImageFolders = i.ImageFolders

                           }).ToList();

            ProjectPage projectPage = new ProjectPage { Category = category, Project = projects };





            return View(projectPage);
        }

        public ActionResult Details(int id)
        {
            var projects = _context.Projects
                .Include(p => p.Categories)
                .Include(p => p.Clients)
                .Include(p => p.ImageFolders)
                .Include(p => p.ImageFolders.Images)
                .Where(i => i.Id == id).FirstOrDefault();
            return View(projects);
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
        [HttpPost]
        public ActionResult Contact([Bind(Include = "Id,Name,Email,Subject,Message")] ContactMessage contactMessage)
        {
            if (ModelState.IsValid)
            {
                _context.ContactMessages.Add(contactMessage);
                _context.SaveChanges();
                //return RedirectToAction("~/Home/Contact");
            }
            return View(contactMessage);
        }
    }
}