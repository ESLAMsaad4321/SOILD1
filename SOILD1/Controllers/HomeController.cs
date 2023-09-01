using Microsoft.AspNetCore.Mvc;
using SOILD1.Models;
using System.Diagnostics;
using Type = SOILD1.Models.Type;

namespace SOILD1.Controllers
{
    public class HomeController : Controller
    {
        private List <Shape> _shapes;
        private List<Type> _Types;
        public HomeController()
        {
            _shapes = new List<Shape>()
            {
                new Shape() {Id=1,Name= "2d shape"},
                new Shape() {Id=2,Name= "3d shape"}
            };
            _Types = new List<Type>()
            {
                new Type() {Id=1,Name= "Square",ShapeId=1},
                new Type() {Id=2,Name= "Kite",ShapeId=1},
                new Type() {Id=3,Name= "Rectangle",ShapeId=1},
                new Type() {Id=4,Name= "Rhombus",ShapeId=1},
                new Type() {Id=5,Name= "Trapezium",ShapeId=1},
                new Type() {Id=6,Name= "Triangle",ShapeId=1},
                new Type() {Id=7,Name= "Cube",ShapeId=2},
                new Type() {Id=8,Name= "Rectangular Prism",ShapeId=2},
                new Type() {Id=9,Name= "Right Circular Cone",ShapeId=2},
                new Type() {Id=10,Name= "Right Circular Cylinder",ShapeId=2},
                new Type() {Id=11,Name= "Right Square Pyramid",ShapeId=2},
                new Type() {Id=12,Name= "Sphere",ShapeId=2},
            };
        }
        public IActionResult Index()
        {
            var viewmodel = new FormViewModel()
            {
                Shapes=_shapes.ToList(),
            };
            return View(viewmodel);
        }
        public IActionResult GetType(int ShapeId)
        {
            var type = _Types.Where(a =>a.ShapeId == ShapeId).ToList();
            return Ok(type);
        }
     /*  public IActionResult ToShape(Type type)
        {

        }
     */
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}