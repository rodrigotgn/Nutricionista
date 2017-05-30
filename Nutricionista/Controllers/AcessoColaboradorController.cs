using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nutricionista.Controllers
{
    public class AcessoColaboradorController : Controller
    {
        //
        // GET: /AcessoColaborador/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /AcessoColaborador/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /AcessoColaborador/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /AcessoColaborador/Create

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
        // GET: /AcessoColaborador/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /AcessoColaborador/Edit/5

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
        // GET: /AcessoColaborador/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /AcessoColaborador/Delete/5

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
