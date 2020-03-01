using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Binarios.HLP;
using
 Binarios.Models;

namespace Binarios.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ResultadoBinario(NumerosModel model)
        {
            BinarioCov Cov = new BinarioCov();
            foreach (int n in model.Numeros)
            {
                model.Binarios.Add(Cov.NumeroBinario(n));
                
            }
            return View(model);
        }
    }
}