using System;
using aspnetcore.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore.Controllers {
    public class EscuelaController : Controller {

        public IActionResult Index () {
            var escuela = new Escuela ();
            escuela.AnioFundacion = 2005;
            escuela.EscuelaId = Guid.NewGuid ().ToString ();
            escuela.Nombre = "Escuela de prueba";


ViewBag.CosaDinamica="bolsa dinamica";
            return View (escuela);
        }

    }
}