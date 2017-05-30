using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nutricionista.Controllers
{
    public class PaginaConstrucaoController : Controller
    {
        //
        // GET: /PaginaConstrucao/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /PaginaConstrucao/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /PaginaConstrucao/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PaginaConstrucao/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /PaginaConstrucao/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /PaginaConstrucao/Edit/5

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

        //
        // GET: /PaginaConstrucao/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /PaginaConstrucao/Delete/5

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
