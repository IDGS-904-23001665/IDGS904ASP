using IDGS904ASP.Models;
using System.Web.Mvc;

namespace IDGS904ASP.Controllers
{
    public class CinepolisController : Controller
    {
        // GET: Cinepolis
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Cinepolis modelo)
        {
            double total = 0;
            double precioPorBoleto = 12;

            if (modelo.CantidadBoletos > (modelo.CantidadCompradores * 7))
            {
                ViewBag.Error = "SOLO 7 BOLETOS POR PERSONA";
                return View();
            }

            total = modelo.CantidadBoletos * precioPorBoleto;

            if (modelo.CantidadBoletos > 5)
            {
                total -= total * 0.15;
            }
            else if (modelo.CantidadBoletos >= 3)
            {
                total -= total * 0.10;
            }

            if (modelo.TarjetaCineco)
            {
                total -= total * 0.10;
            }

            ViewBag.Nombre = modelo.Nombre;
            ViewBag.Total = total;

            return View();
        }
    }
}