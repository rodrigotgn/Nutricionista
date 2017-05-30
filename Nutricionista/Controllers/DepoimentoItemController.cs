using Nutricionista.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nutricionista.Controllers
{
    public class DepoimentoItemController : Controller
    {
        private MainContext db = new MainContext();

        // GET: DepoimentoItem
        public ActionResult Index()
        {
            var dados = db.DepoimentoItems.ToList();

            return View(dados);
        }

        // GET: DepoimentoItem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DepoimentoItem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepoimentoItem/Create
        [HttpPost]  
        public ActionResult Create(DepoimentoItem depoimento, HttpPostedFileBase file)
        {
            try
            {
                // TODO: Add insert logic here
                MemoryStream target = new MemoryStream();
                file.InputStream.CopyTo(target);
                byte[] data = target.ToArray();

                depoimento.DesImagem = data;


                db.DepoimentoItems.Add(depoimento);

                db.SaveChanges();

                return RedirectToAction("Index");
                //return View();

            }
            catch
            {
                return View();
            }
        }

        // GET: DepoimentoItem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DepoimentoItem/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DepoimentoItem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DepoimentoItem/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
