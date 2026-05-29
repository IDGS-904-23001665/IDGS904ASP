using IDGS904ASP.Models;
using System;
using System.Web.Mvc;

namespace IDGS904ASP.Controllers
{
    public class ResistenciasController : Controller
    {
        // GET: Resistencias
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Resistencia modelo)
        {
            int v1 = ObtenerValorColor(modelo.Color1);
            int v2 = ObtenerValorColor(modelo.Color2);
            int v3 = ObtenerValorColor(modelo.Color3);

            double toleranciaPorcentaje = modelo.Tolerancia == "Oro" ? 0.05 : 0.10;

            modelo.Valor = ((v1 * 10) + v2) * Math.Pow(10, v3);

            modelo.ValorMaximo = modelo.Valor + (modelo.Valor * toleranciaPorcentaje);
            modelo.ValorMinimo = modelo.Valor - (modelo.Valor * toleranciaPorcentaje);

            ViewBag.Calculado = true; // Avisamos que ya hay resultados
            return View(modelo);
        }

        private int ObtenerValorColor(string color)
        {
            switch (color)
            {
                case "Negro": return 0;
                case "Café": return 1;
                case "Rojo": return 2;
                case "Naranja": return 3;
                case "Amarillo": return 4;
                case "Verde": return 5;
                case "Azul": return 6;
                case "Violeta": return 7;
                case "Gris": return 8;
                case "Blanco": return 9;
                default: return 0;
            }
        }
    }
}