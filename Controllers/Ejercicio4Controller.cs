using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicios_4___6___MVC.Controllers
{
    public class Ejercicio4Controller : Controller
    {
        // GET: Ejercicio4
        public ActionResult Ejercicio4()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Ejercicio4(Models.Notas obCalculoP)
        {
            double promedio;
            promedio = (obCalculoP.n1 + obCalculoP.n2 + obCalculoP.n3) / 3;

            if (promedio >= 4)
            {
                ViewBag.codigo = obCalculoP.cod;
                ViewBag.nombre = obCalculoP.nombre;
                ViewBag.materia = obCalculoP.materia;
                ViewBag.resultado = "Promedio: " + Math.Round(promedio, 2) + " - Aprobado";
            }
            else if (promedio > 0 && promedio <4)
            {
                ViewBag.codigo = obCalculoP.cod;
                ViewBag.nombre = obCalculoP.nombre;
                ViewBag.materia = obCalculoP.materia;
                ViewBag.resultado1 = "Promedio: "+Math.Round(promedio, 2) + " - Reprobado";
            }
            return View(obCalculoP);
        }

    }
}