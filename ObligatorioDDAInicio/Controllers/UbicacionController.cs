using BussinesLogic.Ubicacion;
using CommonSolution.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ObligatorioDDAInicio.Controllers
{
    public class UbicacionController : Controller
    {
        public ActionResult NumeroTracking()
        {
            return View();
        }
        public JsonResult GetUbicacion(Tracking tracking)
        {
            LUbicacionController ubicacionController = new LUbicacionController();
            
            string respuestaBase = ubicacionController.ExisteTracking(long.Parse(tracking.NumeroTracking));

            if(respuestaBase != "")
                return Json(respuestaBase, JsonRequestBehavior.AllowGet);

            tracking = LocationEnKenia(tracking);
            return Json(tracking, JsonRequestBehavior.AllowGet);
        }
        public Tracking LocationEnKenia(Tracking tracking)
        {
            int random = new Random().Next(10);

            switch (random)
            {
                case 1:
                    tracking.Latitud = "-0.926";
                    tracking.Longitud = "37.615";
                    break;
                case 2:
                    tracking.Latitud = "3.136";
                    tracking.Longitud = "40.581";
                    break;
                case 3:
                    tracking.Latitud = "3.728";
                    tracking.Longitud = "35.440";
                    break; 
                case 4:
                    tracking.Latitud = "2.587";
                    tracking.Longitud = "35.637";
                    break;
                case 5:
                    tracking.Latitud = "-0.157";
                    tracking.Longitud = "35.308";
                    break;
                case 6:
                    tracking.Latitud = "-0.663";
                    tracking.Longitud = "37.219";
                    break;
                case 7:
                    tracking.Latitud = "-2.486";
                    tracking.Longitud = "37.703";
                    break;
                case 8:
                    tracking.Latitud = "-3.692";
                    tracking.Longitud = "39.307";
                    break;
                case 9:
                    tracking.Latitud = "-2.332";
                    tracking.Longitud = "40.603";
                    break;
                case 10:
                    tracking.Latitud = "-0.619";
                    tracking.Longitud = "38.120";
                    break;
                default:
                    break;
            }

            return tracking;
        }
    }
}
