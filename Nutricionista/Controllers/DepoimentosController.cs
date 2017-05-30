using Nutricionista.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Nutricionista.Controllers
{
    public class DepoimentosController : Controller
    {
        private MainContext db = new MainContext();

        // GET: Depoimentoes
        public ActionResult Index()
        {
            var depoimentos = db.Depoimentos.AsEnumerable().LastOrDefault();

            if (depoimentos != null)
            {
                depoimentos.DepoimentoItems = db.DepoimentoItems.ToList();
            }
            
            return View(depoimentos);
        }

        // GET: Depoimentoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Depoimento depoimento = db.Depoimentos.Find(id);
            if (depoimento == null)
            {
                return HttpNotFound();
            }
            return View(depoimento);
        }

        // GET: Depoimentoes/Create
        public ActionResult Create()
        {
            var depoimentos = db.Depoimentos.AsEnumerable().LastOrDefault();

            if (depoimentos != null)
            {
                depoimentos.DepoimentoItems = db.DepoimentoItems.ToList();
            }

            return View(depoimentos);
        }

        // POST: Depoimentoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NumChave,DesTitulo,DesDescricao")] Depoimento depoimento)
        {
            if (ModelState.IsValid)
            {
                db.Depoimentos.Add(depoimento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(depoimento);
        }

        // GET: Depoimentoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Depoimento depoimento = db.Depoimentos.Find(id);
            if (depoimento == null)
            {
                return HttpNotFound();
            }
            return View(depoimento);
        }

        // POST: Depoimentoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NumChave,DesTitulo,DesDescricao")] Depoimento depoimento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(depoimento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(depoimento);
        }

        // GET: Depoimentoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Depoimento depoimento = db.Depoimentos.Find(id);
            if (depoimento == null)
            {
                return HttpNotFound();
            }
            return View(depoimento);
        }

        // POST: Depoimentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Depoimento depoimento = db.Depoimentos.Find(id);
            db.Depoimentos.Remove(depoimento);
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