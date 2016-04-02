using System.Web.Mvc;

namespace ExemploController.Controllers
{
    public class CalculadorController : Controller
    {
        public ActionResult Somar()
        {
            return Content("Ação de Somar");
        }

        public ActionResult Subtrair()
        {
            return Content("Ação de Subtrair");
        }

        public ActionResult Multiplicar()
        {
            return Content("Ação de Multiplicar");
        }

        public ActionResult Dividir()
        {
            return Content("Ação de Dividir");
        }
    }
}