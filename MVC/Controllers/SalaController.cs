using MVC.Models;
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
                s.Id = item.Id;
                s.Nome = item.Nome;
                s.Projetor = item.Projetor;
                s.qtdAlunos = item.qtdAlunos;
                s.qtdComputadores = item.qtdComputadores;
                s.SistemaOperacional = item.SistemaOperacional;
                s.Software1 = item.Software1;
                s.Software2 = item.Software2;
                s.Software3 = item.Software3;

                lstSala.Add(s);
            }
            
            return View(lstSala);            
        }

        // GET: Sala/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
                //SalaModel s = new SalaModel();
                MVC.ServiceReference.Sala s = new MVC.ServiceReference.Sala();
                s.Nome = sl.Nome;
                s.Projetor = sl.Projetor;
                s.qtdAlunos = sl.qtdAlunos;
                s.qtdComputadores = sl.qtdComputadores;
                s.SistemaOperacional = sl.SistemaOperacional;
                s.Software1 = sl.Software1;
                s.Software2 = sl.Software2;
                s.Software3 = sl.Software3;
                server.inserir(s);
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
            return View();
        }

        // POST: Sala/Edit/5
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

        // GET: Sala/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sala/Delete/5
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
