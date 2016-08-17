using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DCComics.Model;
using DCComics.Service;

namespace DCComics.Controllers
{
    public class PersonController : Controller
    {
        //private DCComicsContext db = new DCComicsContext();

        IPersonService _PersonService;
        
        public PersonController(IPersonService PersonService)
        {
            _PersonService = PersonService;
           
        }

        // GET: Person
        public ActionResult Index()
        {
            return View(_PersonService.GetAll());
        }

        [HttpPost]
        [ActionName("GetPeople")]
        public ActionResult GetPeople()
        {
            return Json(_PersonService.GetAll().ToList(), JsonRequestBehavior.AllowGet);            
        }
        // GET: Person/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = _PersonService.GetById(id.Value);
            if (person == null)
            {
                return HttpNotFound();
            }
            return PartialView(person);
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Person/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Address,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy")] Person person)
        {
            if (ModelState.IsValid)
            {
                _PersonService.Create(person);                
                return RedirectToAction("Index");
            }

            return View(person);
        }

        // GET: Person/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = _PersonService.GetById(id.Value);
            if (person == null)
            {
                return HttpNotFound();
            }
            return PartialView(person);
        }

        // POST: Person/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Address,CreatedDate,CreatedBy,UpdatedDate,UpdatedBy")] Person person)
        {
            if (ModelState.IsValid)
            {
                _PersonService.Update(person);
                return RedirectToAction("Index");
            }
            return View(person);
        }

        // GET: Person/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = _PersonService.GetById(id.Value);
            if (person == null)
            {
                return HttpNotFound();
            }
            return PartialView(person);
        }

        // POST: Person/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Person person = _PersonService.GetById(id);
            _PersonService.Delete(person);
            return RedirectToAction("Index");
        }
    }
}
