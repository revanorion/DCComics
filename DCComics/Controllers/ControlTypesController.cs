using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DCComics.Model;

namespace DCComics.Controllers
{
    public class ControlTypesController : Controller
    {
        private DCComicsContext db = new DCComicsContext();

        // GET: ControlTypes
        public ActionResult Index()
        {
            return View(db.ControlTypes.ToList());
        }

        [HttpPost]
        [ActionName("GetControlTypes")]
        public ActionResult GetControlTypes()
        {
            return Json(db.Persons.ToList(), JsonRequestBehavior.AllowGet);
        }


        // GET: ControlTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ControlType controlType = db.ControlTypes.Find(id);
            if (controlType == null)
            {
                return HttpNotFound();
            }
            return PartialView(controlType);
        }

        // GET: ControlTypes/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: ControlTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ControlTypeId,ControlTypeName,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,Id")] ControlType controlType)
        {
            if (ModelState.IsValid)
            {
                db.ControlTypes.Add(controlType);
                db.SaveChanges();
                return Redirect(Request.UrlReferrer.AbsolutePath.ToString() + "?redirectedLink=ControlTypes");
            }

            return View(controlType);
        }

        // GET: ControlTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ControlType controlType = db.ControlTypes.Find(id);
            if (controlType == null)
            {
                return HttpNotFound();
            }
            return PartialView(controlType);
        }

        // POST: ControlTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ControlTypeId,ControlTypeName,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,Id")] ControlType controlType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(controlType).State = EntityState.Modified;
                db.SaveChanges();
                return Redirect(Request.UrlReferrer.AbsolutePath.ToString() + "?redirectedLink=ControlTypes");
            }
            return View(controlType);
        }

        // GET: ControlTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ControlType controlType = db.ControlTypes.Find(id);
            if (controlType == null)
            {
                return HttpNotFound();
            }
            return PartialView(controlType);
        }

        // POST: ControlTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ControlType controlType = db.ControlTypes.Find(id);
            db.ControlTypes.Remove(controlType);
            db.SaveChanges();
            return Redirect(Request.UrlReferrer.AbsolutePath.ToString() + "?redirectedLink=ControlTypes");
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
