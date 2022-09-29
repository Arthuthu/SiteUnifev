using ProvaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteUnifev.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            var lista = new BotoesDAO().Listar();

            ViewBag.Botoes = lista;

            return View();
        }
    }
}