using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoLoja.Infra.Data.Repositories;
using ProjLoja.Domain.Entities;
using ProjetoLoja.AutoMapper;
using ProjetoLoja.ViewModels;

namespace ProjetoLoja.Controllers
{
    public class HomeController : Controller
    {
        private readonly UsuarioRepository _usuarioRepository = new UsuarioRepository();

        public ActionResult Index()
        {
            if (Session["usuarioLogadoID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UsuarioViewModel u)
        {
            // esta action trata o post (login)
            if (ModelState.IsValid) //verifica se é válido
            {
                var v = _usuarioRepository.GetAll().Where(a => a.Login.Equals(u.Login) && a.Senha.Equals(u.Senha)).FirstOrDefault();
                if (v != null)
                {
                    Session["UsuarioId"] = v.UsuarioId.ToString();
                    Session["UsuarioNome"] = v.Nome.ToString();
                    return RedirectToAction("Index");
                }
            }
            return View(u);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Macoratti .net";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "http://www.macoratti.net";

            return View();
        }
    }
}