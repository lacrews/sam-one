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
    public class MoneyEntitiesController : Controller
    {
        private JibesoftDbContext db = new JibesoftDbContext();

        // GET: MoneyEntities
        public ActionResult Index()
        {
            var moneyEntities = db.MoneyEntities.Include(m => m.LeadSource).Include(m => m.Term);
            return View(moneyEntities.ToList());
        }

        // GET: MoneyEntities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MoneyEntity moneyEntity = db.MoneyEntities.Find(id);
            if (moneyEntity == null)
            {
                return HttpNotFound();
            }
            return View(moneyEntity);
        }

        // GET: MoneyEntities/Create
        public ActionResult Create()
        {
            ViewBag.LeadSourceId = new SelectList(db.LeadSources, "Id", "Name");
            ViewBag.TermId = new SelectList(db.Terms, "Id", "Terms");
            return View();
        }

        // POST: MoneyEntities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AccountNumber,Altphone,BillAddr1,BillAddr2,BillAddr3,BillCity,BillPostalCode,BillState,CreatedDate,Email,Fax,FirstName,IsActive,LastName,LeadSourceId,MiddleName,MoneyEntityType,Name,Phone,ResaleNumber,Salutation,Suffix,TermId")] MoneyEntity moneyEntity)
        {
            if (ModelState.IsValid)
            {
                db.MoneyEntities.Add(moneyEntity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LeadSourceId = new SelectList(db.LeadSources, "Id", "Name", moneyEntity.LeadSourceId);
            ViewBag.TermId = new SelectList(db.Terms, "Id", "Terms", moneyEntity.TermId);
            return View(moneyEntity);
        }

        // GET: MoneyEntities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MoneyEntity moneyEntity = db.MoneyEntities.Find(id);
            if (moneyEntity == null)
            {
                return HttpNotFound();
            }
            ViewBag.LeadSourceId = new SelectList(db.LeadSources, "Id", "Name", moneyEntity.LeadSourceId);
            ViewBag.TermId = new SelectList(db.Terms, "Id", "Terms", moneyEntity.TermId);
            return View(moneyEntity);
        }

        // POST: MoneyEntities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AccountNumber,Altphone,BillAddr1,BillAddr2,BillAddr3,BillCity,BillPostalCode,BillState,CreatedDate,Email,Fax,FirstName,IsActive,LastName,LeadSourceId,MiddleName,MoneyEntityType,Name,Phone,ResaleNumber,Salutation,Suffix,TermId")] MoneyEntity moneyEntity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(moneyEntity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LeadSourceId = new SelectList(db.LeadSources, "Id", "Name", moneyEntity.LeadSourceId);
            ViewBag.TermId = new SelectList(db.Terms, "Id", "Terms", moneyEntity.TermId);
            return View(moneyEntity);
        }

        // GET: MoneyEntities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MoneyEntity moneyEntity = db.MoneyEntities.Find(id);
            if (moneyEntity == null)
            {
                return HttpNotFound();
            }
            return View(moneyEntity);
        }

        // POST: MoneyEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MoneyEntity moneyEntity = db.MoneyEntities.Find(id);
            db.MoneyEntities.Remove(moneyEntity);
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
