using MVC.Models;
using MVC.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class SalaController : Controller
    {
        // GET: Sala
        ServiceReference.ServicoClient server = new ServiceReference.ServicoClient();
        public ActionResult Index()
        {
            List<SalaModel> lstSala = new List<SalaModel>();

            var lst = server.Listar();

            foreach (var item in lst)
            {
                
                SalaModel s = new SalaModel();
                s = Converte.ToSalaModel(item);
                lstSala.Add(s);
            }
            
            return View(lstSala);            
        }

        // GET: Sala/Details/5
        public ActionResult Details(int id)
        {
            SalaModel sm = new SalaModel();
            sm = Converte.ToSalaModel(server.getById(id));
            return View(sm);
        }

        // GET: Sala/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sala/Create
        [HttpPost]
        public ActionResult Create(SalaModel sl)
        {
            try
            {              
                    server.inserir(Converte.ToSala(sl));
                    // TODO: Add insert logic here
                    return RedirectToAction("Index");
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Sala/Edit/5
        public ActionResult Edit(int id)
        {
            SalaModel sm = new SalaModel();
            sm = Converte.ToSalaModel(server.getById(id));
            return View(sm);           
        }

        // POST: Sala/Edit/5
        [HttpPost]
        public ActionResult Edit(SalaModel sm)
        {
            try
            {
                server.editar(Converte.ToSala(sm));
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sala/Delete/5
        public ActionResult Delete(int id)
        {
            server.excluir(id);
            // TODO: Add delete logic here
            return RedirectToAction("Index");
        }

        // POST: Sala/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmarDelete(int id, FormCollection collection)
        {
            try
            {
                server.excluir(id);
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contatos.";

            return View();
        }
    }
}
