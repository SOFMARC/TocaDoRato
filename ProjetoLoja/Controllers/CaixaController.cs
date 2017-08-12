using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjLoja.Infra.Data.Repositories;
using ProjLoja.Domain.Entities;
using ProjetoLoja.AutoMapper;
using ProjetoLoja.ViewModels;

namespace ProjetoLoja.Controllers
{    
    public class CaixaController : Controller
    {
        private readonly CaixaRepository _CaixaRepository = new CaixaRepository();
        // GET: Caixa
        public ActionResult Index()
        {
            return View();
        }

        // GET: Caixa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Caixa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Caixa/Create
        [HttpPost]
        public ActionResult Create(CaixaViewModel novoCaixa)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    var model = AutoMapperHelper.CreateMapper<CaixaViewModel, Caixa>(novoCaixa);
                    model.Ativo = true;
                    model.UsuarioId = 1;
                    _CaixaRepository.Add(model);

                    return RedirectToAction("Index", "Venda");
                }
                return View(novoCaixa);
            }
            catch (Exception)
            {
                return View(novoCaixa);
            }           
         
        }

        // GET: Caixa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Caixa/Edit/5
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

        // GET: Caixa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Caixa/Delete/5
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
