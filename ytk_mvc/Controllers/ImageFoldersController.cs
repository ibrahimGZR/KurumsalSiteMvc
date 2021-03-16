using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ytk_mvc.DAL;
using ytk_mvc.Entity;

namespace ytk_mvc.Controllers
{
    public class ImageFoldersController : Controller
    {
        private DataContext db = new DataContext();

        // GET: ImageFolders
        public ActionResult Index()
        {
            return View(db.ImageFolders.ToList());
        }

        // GET: ImageFolders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ImageFolder imageFolder = db.ImageFolders.Find(id);
            if (imageFolder == null)
            {
                return HttpNotFound();
            }
            return View(imageFolder);
        }

        // GET: ImageFolders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ImageFolders/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] ImageFolder imageFolder)
        {
            if (ModelState.IsValid)
            {
                db.ImageFolders.Add(imageFolder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(imageFolder);
        }

        // GET: ImageFolders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ImageFolder imageFolder = db.ImageFolders.Find(id);
            if (imageFolder == null)
            {
                return HttpNotFound();
            }
            return View(imageFolder);
        }

        // POST: ImageFolders/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] ImageFolder imageFolder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(imageFolder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(imageFolder);
        }

        // GET: ImageFolders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ImageFolder imageFolder = db.ImageFolders.Find(id);
            if (imageFolder == null)
            {
                return HttpNotFound();
            }
            return View(imageFolder);
        }

        // POST: ImageFolders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ImageFolder imageFolder = db.ImageFolders.Find(id);
            db.ImageFolders.Remove(imageFolder);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
