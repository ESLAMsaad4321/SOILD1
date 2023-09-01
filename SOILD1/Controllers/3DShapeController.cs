using Microsoft.AspNetCore.Mvc;
using SOILD1.Serivces;
using SOLID.Models;
using SOLID.Services._3DShape;

namespace SOLID.Controllers
{
    public class _3DShapeController : Controller
    {
 
        [HttpGet]
        public ActionResult Cube()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cube(_3DShapeModelView cal)
        {
            Cube res = new Cube();

            var result = res.Volume(cal);
            ViewData["Result"] = result;
            return View();
        }
       
        [HttpGet]
        public ActionResult RectangularPrism()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RectangularPrism(_3DShapeModelView cal)
        {
            RectangularPrism res = new RectangularPrism();
            var result = res.Volume(cal);
            ViewData["Result"] = result;
            return View();
        }

        [HttpGet]
        public ActionResult RightCircularCone()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RightCircularCone(_3DShapeModelView cal)
        {
            RightCircularCone res = new RightCircularCone();

            var result = res.Volume(cal);
            ViewData["Result"] = result;
            return View();
        } 
        [HttpGet]
        public ActionResult RightCircularCylinder()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RightCircularCylinder(_3DShapeModelView cal)
        {
            RightCircularCylinder res = new RightCircularCylinder();

            var result = res.Volume(cal);
            ViewData["Result"] = result;
            return View();
        }
        [HttpGet]
        public ActionResult RightSquarePyramid()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RightSquarePyramid(_3DShapeModelView cal)
        {
            RightSquarePyramid res = new RightSquarePyramid();

            var result = res.Volume(cal);
            ViewData["Result"] = result;
            return View();
        }
        [HttpGet]
        public ActionResult Sphere()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Sphere(_3DShapeModelView cal)
        {
            Sphere res = new Sphere();

            var result = res.Volume(cal);
            ViewData["Result"] = result;
            return View();
        }
    }
}
