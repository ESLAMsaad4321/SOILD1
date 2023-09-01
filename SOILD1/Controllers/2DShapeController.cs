using Microsoft.AspNetCore.Mvc;
using SOILD1.Serivces;
using SOLID.Models;

namespace SOLID.Controllers
{
    public class _2DShapeController : Controller
    {
 
        [HttpGet]
        public ActionResult Square()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Square(_2DShapeModelView cal)
        {
            Square res = new Square();

            var result = res.Area(cal);
            ViewData["Result"] = result;
            return View();
        }
       
        [HttpGet]
        public ActionResult Kite()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kite(_2DShapeModelView cal)
        {
            Kite res = new Kite();

            var result = res.Area(cal);
            ViewData["Result"] = result;
            return View();
        }

        [HttpGet]
        public ActionResult Rectangle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Rectangle(_2DShapeModelView cal)
        {
            Rectangle res = new Rectangle();

            var result = res.Area(cal);
            ViewData["Result"] = result;
            return View();
        } 
        [HttpGet]
        public ActionResult Rhombus()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Rhombus(_2DShapeModelView cal)
        {
            Rhombus res = new Rhombus();

            var result = res.Area(cal);
            ViewData["Result"] = result;
            return View();
        }
        [HttpGet]
        public ActionResult Trapezium()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Trapezium(_2DShapeModelView cal)
        {
            Trapezium res = new Trapezium();

            var result = res.Area(cal);
            ViewData["Result"] = result;
            return View();
        }
        [HttpGet]
        public ActionResult Triangle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Triangle(_2DShapeModelView cal)
        {
            Triangle res = new Triangle();

            var result = res.Area(cal);
            ViewData["Result"] = result;
            return View();
        }
    }
}
