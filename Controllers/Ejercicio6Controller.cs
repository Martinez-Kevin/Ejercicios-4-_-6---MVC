using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicios_4___6___MVC.Controllers
{
    public class Ejercicio6Controller : Controller
    {
        // GET: Ejercicio6
        public ActionResult Ejercicio6()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ejercicio6(Models.Compra objTotal)
        {
            double monto_total, tot;

            monto_total = (objTotal.cant_art * objTotal.precio_unit);

            if (monto_total > 100000)
            {
                objTotal.descuento = monto_total * 0.20;
                tot = monto_total - objTotal.descuento;
                ViewBag.resultado = "El monto de la compra sin descuento es: $" + Math.Round(monto_total,2);
                ViewBag.resultadoD = "El descuento es de: $" + Math.Round(objTotal.descuento,2);
                ViewBag.resultadoM = "El monto total de la compra es $" + Math.Round(tot,2);

            }
            else
            {
                ViewBag.resultado = "El monto de la compra  es: $" + Math.Round(monto_total,2);
            }

            return View(objTotal);
        }

    }
}