using Nutricionista.Models;
using Nutricionista.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nutricionista.Controllers
{
    public class LoginController : Controller
    {
        private MainContext db = new MainContext();
        //
        // GET: /Login/

        public ActionResult Index()
        {
            if (UsuarioLogado.IsLogado)
            {
                //Usuário logado
                return RedirectToAction("Index", "AcessoColaborador");
            }
            else
            {
                return View();
            }
        }

        //
        // GET: /Login/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Login/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Login/Create

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
        // GET: /Login/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Login/Edit/5

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
        // GET: /Login/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Login/Delete/5

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

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Validar([Bind(Include = "NumChave,DesNome,DesEmail,DesSenha,TipPerfil,DatCadastro,FlgExcluido,FlgBloqueado")] Usuario usuario)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Usuarios.Add(usuario);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(usuario);
        //}

        [HttpPost]
        public ActionResult Validar(FormCollection collection)
        {
            try
            {
                string email = collection["DesEmail"];
                string senha = collection["DesSenha"];

                var usuario = db.Usuarios.Where(p => p.DesEmail == email && p.DesSenha == senha).FirstOrDefault();
                if (usuario != null)
                {
                    UsuarioLogado.Usuario = usuario;

                    //Usuário logado
                    return RedirectToAction("Index", "AcessoColaborador");
                }
                else
                {
                    //Usuario inválido
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
