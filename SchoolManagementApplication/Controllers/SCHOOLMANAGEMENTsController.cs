using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SchoolManagementApplication.Models;

namespace SchoolManagementApplication.Controllers
{
    public class SCHOOLMANAGEMENTsController : Controller
    {
        private SCHOOLEntities db = new SCHOOLEntities();

        // GET: SCHOOLMANAGEMENTs
        public ActionResult Index()
        {
            return View(db.SCHOOLMANAGEMENTs.ToList());
        }

        // GET: SCHOOLMANAGEMENTs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SCHOOLMANAGEMENT sCHOOLMANAGEMENT = db.SCHOOLMANAGEMENTs.Find(id);
            if (sCHOOLMANAGEMENT == null)
            {
                return HttpNotFound();
            }
            return View(sCHOOLMANAGEMENT);
        }

        // GET: SCHOOLMANAGEMENTs/Create
        public ActionResult Create()
        {
            return View(new SCHOOLMANAGEMENT());
        }

        // POST: SCHOOLMANAGEMENTs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "STUD_ID,STUD_NAME,CLASS,SUBJECT")] SCHOOLMANAGEMENT sCHOOLMANAGEMENT)
        {
            if (ModelState.IsValid)
            {
                db.SCHOOLMANAGEMENTs.Add(sCHOOLMANAGEMENT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sCHOOLMANAGEMENT);
        }

        // GET: SCHOOLMANAGEMENTs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SCHOOLMANAGEMENT sCHOOLMANAGEMENT = db.SCHOOLMANAGEMENTs.Find(id);
            if (sCHOOLMANAGEMENT == null)
            {
                return HttpNotFound();
            }
            return View(sCHOOLMANAGEMENT);
        }

        // POST: SCHOOLMANAGEMENTs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "STUD_ID,STUD_NAME,CLASS,SUBJECT")] SCHOOLMANAGEMENT sCHOOLMANAGEMENT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sCHOOLMANAGEMENT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sCHOOLMANAGEMENT);
        }

        // GET: SCHOOLMANAGEMENTs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SCHOOLMANAGEMENT sCHOOLMANAGEMENT = db.SCHOOLMANAGEMENTs.Find(id);
            if (sCHOOLMANAGEMENT == null)
            {
                return HttpNotFound();
            }
            return View(sCHOOLMANAGEMENT);
        }

        // POST: SCHOOLMANAGEMENTs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SCHOOLMANAGEMENT sCHOOLMANAGEMENT = db.SCHOOLMANAGEMENTs.Find(id);
            db.SCHOOLMANAGEMENTs.Remove(sCHOOLMANAGEMENT);
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
