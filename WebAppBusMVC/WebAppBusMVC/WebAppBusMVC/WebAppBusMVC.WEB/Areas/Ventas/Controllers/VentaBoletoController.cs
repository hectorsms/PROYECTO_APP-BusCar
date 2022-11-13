using Microsoft.AspNetCore.Mvc;
using WebAppBusMVC.WEB.Services;

namespace WebAppBusMVC.WEB.Areas.Ventas.Controllers
{
    [Area("Ventas")]
    public class VentaBoletoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult VentaBoleto()
        //{

        //    return View();
        //}

        public async Task<IActionResult> VentaBoleto()
        {
            var destinos = await VentaBoletoService.GetDestinos();
            var origenes = await VentaBoletoService.GetOrigenes();
            ViewBag.ListaDestinos = destinos;
            ViewBag.ListaOrigenes = origenes;
            return View();

        }

        public IActionResult VentaBoletoProgramacion()
        {
            return View();
        }

        public IActionResult VentaBoletoProgramacionList()
        {
            return PartialView();
        }

        public IActionResult VentaBoletoAsiento()
        {
            return View();
        }

        public IActionResult VentaBoletoAsientoList()
        {
            return PartialView();
        }
        public IActionResult VentaBoletoDatosPersonales()
        {
                return View();
        }

        public IActionResult VentaBoletoPago()
        {
            return View();
        }


    }
    }
