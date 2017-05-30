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
    public class ClinicaController : Controller
    {
        private MainContext db = new MainContext();
        //
        // GET: /Clinica/

        public ActionResult Index()
        {
            Clinica clinica;

            using (var context = new MainContext())
            {
                clinica = context.Clinicas.AsEnumerable().LastOrDefault();
            }

            return View(clinica);
        }

        //
        // GET: /Clinica/Details/5

        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clinica clinica = db.Clinicas.Find(id);
            if (clinica == null)
            {
                return HttpNotFound();
            }
            return View(clinica);
        }

        //
        // GET: /Clinica/Create

        public ActionResult Create()
        {
            return View();
        }

        // POST: Clinica/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NumChave,DesTitulo,DesDescricao")] Clinica clinica)
        {
            if (ModelState.IsValid)
            {
                db.Clinicas.Add(clinica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clinica);
        }

        //
        // GET: /Clinica/Edit/5

        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clinica clinica = db.Clinicas.Find(id);
            if (clinica == null)
            {
                return HttpNotFound();
            }
            return View(clinica);
        }

        //
        // POST: /Clinica/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NumChave,DesTitulo,DesDescricao")] Clinica clinica)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(clinica).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(clinica);
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Clinica/Delete/5

        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clinica clinica = db.Clinicas.Find(id);
            if (clinica == null)
            {
                return HttpNotFound();
            }
            return View(clinica);
        }

        //
        // POST: /Clinica/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Clinica clinica = db.Clinicas.Find(id);
            db.Clinicas.Remove(clinica);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
