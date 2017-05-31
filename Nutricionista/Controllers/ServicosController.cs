using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nutricionista.Models;

namespace Nutricionista.Controllers
{
    public class ServicosController : Controller
    {
        private MainContext db = new MainContext();

        // GET: Servicos
        public ActionResult Index()
        {
            Servicos servicos;

            using (var context = new MainContext())
            {
                servicos = context.Servicos.AsEnumerable().LastOrDefault();
            }

            return View(servicos);
        }

        // GET: Servicos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Servicos servicos = db.Servicos.Find(id);
            if (servicos == null)
            {
                return HttpNotFound();
            }
            return View(servicos);
        }

        // GET: Servicos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Servicos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NumChave,DesTitulo,DesDescricao,DesImagem")] Servicos servicos)
        {
            if (ModelState.IsValid)
            {
                db.Servicos.Add(servicos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(servicos);
        }

        // GET: Servicos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Servicos servicos = db.Servicos.Find(id);
            if (servicos == null)
            {
                return HttpNotFound();
            }
            return View(servicos);
        }

        // POST: Servicos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NumChave,DesTitulo,DesDescricao,DesImagem")] Servicos servicos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(servicos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(servicos);
        }

        // GET: Servicos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Servicos servicos = db.Servicos.Find(id);
            if (servicos == null)
            {
                return HttpNotFound();
            }
            return View(servicos);
        }

        // POST: Servicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Servicos servicos = db.Servicos.Find(id);
            db.Servicos.Remove(servicos);
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
