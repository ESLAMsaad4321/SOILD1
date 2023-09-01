using System.ComponentModel.DataAnnotations;

namespace SOILD1.Models
{
    public class FormViewModel
    {
        [Display (Name ="Shape")]
        public int ShapeId { get; set; }
        public IEnumerable<Shape>? Shapes { get; set; }
        [Display(Name = "Type")]

        public int TypeId { get; set; }
        public IEnumerable<Type>? Types { get; set; } = new List<Type>();
    }
}
