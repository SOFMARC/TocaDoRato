﻿using ProLoja.Infra.Data.Repositories;
using System.Web.Mvc;

namespace ProjetoLoja.Controllers
{
    [Authorize]
    public class VendaController : Controller
    {
        private readonly VendaRepository _VendaRepository = new VendaRepository();
        // GET: Venda
        public ActionResult Index()
        {   
            return View();
        }

        // GET: Venda/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Venda/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Venda/Create
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

        // GET: Venda/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Venda/Edit/5
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

        // GET: Venda/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Venda/Delete/5
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
