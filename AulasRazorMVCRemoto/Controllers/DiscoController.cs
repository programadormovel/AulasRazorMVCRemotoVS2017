using AulasRazorMVCRemoto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AulasRazorMVCRemoto.Controllers
{
    public class DiscoController : Controller
    {
        // Objeto de persistência de dados
        private static DiscoDados discoDados = new DiscoDados();

        // GET: Disco
        public ActionResult Index()
        {
            ViewBag.Mensagem = "Semana de Prova N1";

            return View(discoDados.listaDisco);
        }

        public ActionResult AdicionaDisco()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdicionaDisco(Disco discos)
        {
            discoDados.CriaDiscos(discos);
            return RedirectToAction("Index", "Disco", discoDados);
        }

        public ActionResult ApagaDisco(string id)
        {
            try
            {
                if(discoDados.ApagaDisco(id))
                {
                    ViewBag.AlertMsg = "Disco não encontrado!";
                }
                return RedirectToAction("Index", "Disco", discoDados);
            }catch
            {
                return View();
            }
        }

        public ActionResult AtualizaDisco(string id)
        {
            return View(discoDados.listaDisco.Find(discoDados => discoDados.disco == id));
        }

        [HttpPost]
        public ActionResult AtualizaDisco(Disco discos)
        {
            discoDados.AtualizaDisco(discos);
            return RedirectToAction("Index", "Disco", discoDados);
        }

    }
}