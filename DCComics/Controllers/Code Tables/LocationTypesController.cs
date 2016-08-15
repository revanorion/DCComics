using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DCComics.Model;
using DCComics.Model.Code_Tables;

namespace DCComics.Controllers.Code_Tables
{
    public class LocationTypesController : Controller
    {
        private DCComicsContext db = new DCComicsContext();

        // GET: LocationTypes
        public ActionResult Index()
        {
            return View(db.LocationTypes.ToList());
        }

        [HttpPost]
        [ActionName("GetLocationTypes")]
        public ActionResult GetLocationTypes()
        {
            return Json(db.LocationTypes.ToList(), JsonRequestBehavior.AllowGet);
        }


        // GET: LocationTypes/Details/5
        public ActionResult Details(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocationType locationType = db.LocationTypes.Find(id);
            if (locationType == null)
            {
                return HttpNotFound();
            }
            return PartialView(locationType);
        }

        // GET: LocationTypes/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: LocationTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LocationTypeId,LocationTypeCode,LocationTypeDesc,StartDate,EndDate,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,Id")] LocationType locationType)
        {
            if (ModelState.IsValid)
            {
                db.LocationTypes.Add(locationType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(locationType);
        }

        // GET: LocationTypes/Edit/5
        public ActionResult Edit(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocationType locationType = db.LocationTypes.Find(id);
            if (locationType == null)
            {
                return HttpNotFound();
            }
            return PartialView(locationType);
        }

        // POST: LocationTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LocationTypeId,LocationTypeCode,LocationTypeDesc,StartDate,EndDate,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy,Id")] LocationType locationType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(locationType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(locationType);
        }

        // GET: LocationTypes/Delete/5
        public ActionResult Delete(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocationType locationType = db.LocationTypes.Find(id);
            if (locationType == null)
            {
                return HttpNotFound();
            }
            return PartialView(locationType);
        }

        // POST: LocationTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(byte id)
        {
            LocationType locationType = db.LocationTypes.Find(id);
            db.LocationTypes.Remove(locationType);
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
