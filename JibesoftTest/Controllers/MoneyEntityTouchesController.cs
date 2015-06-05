using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GetFromDb;

namespace JibesoftTest.Controllers
{
    [Authorize]
    public class MoneyEntityTouchesController : Controller
    {
        private JibesoftDbContext db = new JibesoftDbContext();

        // GET: MoneyEntityTouches
        public ActionResult Index()
        {
            var moneyEntityTouches = db.MoneyEntityTouches.Include(m => m.MoneyEntity);
            return View(moneyEntityTouches.ToList());
        }

        // GET: MoneyEntityTouches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MoneyEntityTouch moneyEntityTouch = db.MoneyEntityTouches.Find(id);
            if (moneyEntityTouch == null)
            {
                return HttpNotFound();
            }
            return View(moneyEntityTouch);
        }

        // GET: MoneyEntityTouches/Create
        public ActionResult Create()
        {
            ViewBag.MoneyEntityId = new SelectList(db.MoneyEntities, "Id", "Name");
            return View();
        }

        // POST: MoneyEntityTouches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AspNetUserId,Comment,DateCreated,MoneyEntityId,ScheduledDate,Status")] MoneyEntityTouch moneyEntityTouch)
        {
            if (ModelState.IsValid)
            {
                db.MoneyEntityTouches.Add(moneyEntityTouch);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MoneyEntityId = new SelectList(db.MoneyEntities, "Id", "Name", moneyEntityTouch.MoneyEntityId);
            return View(moneyEntityTouch);
        }

        // GET: MoneyEntityTouches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MoneyEntityTouch moneyEntityTouch = db.MoneyEntityTouches.Find(id);
            if (moneyEntityTouch == null)
            {
                return HttpNotFound();
            }
            ViewBag.MoneyEntityId = new SelectList(db.MoneyEntities, "Id", "AccountNumber", moneyEntityTouch.MoneyEntityId);
            return View(moneyEntityTouch);
        }

        // POST: MoneyEntityTouches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AspNetUserId,Comment,DateCreated,MoneyEntityId,ScheduledDate,Status")] MoneyEntityTouch moneyEntityTouch)
        {
            if (ModelState.IsValid)
            {
                db.Entry(moneyEntityTouch).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MoneyEntityId = new SelectList(db.MoneyEntities, "Id", "AccountNumber", moneyEntityTouch.MoneyEntityId);
            return View(moneyEntityTouch);
        }

        // GET: MoneyEntityTouches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MoneyEntityTouch moneyEntityTouch = db.MoneyEntityTouches.Find(id);
            if (moneyEntityTouch == null)
            {
                return HttpNotFound();
            }
            return View(moneyEntityTouch);
        }

        // POST: MoneyEntityTouches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MoneyEntityTouch moneyEntityTouch = db.MoneyEntityTouches.Find(id);
            db.MoneyEntityTouches.Remove(moneyEntityTouch);
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
