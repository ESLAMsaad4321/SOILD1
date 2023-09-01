using Microsoft.AspNetCore.Mvc;
using SOILD1.Serivces;
using SOLID.Models;

namespace SOLID.Services._3DShape
{
    public interface I3DShapeServices
    {
        decimal Volume(_3DShapeModelView cal);

    }
    interface ICube : I3DShapeServices
    {

    }
    class Cube : ICube
    {
        public decimal S { get; set; }
        public  decimal Volume(_3DShapeModelView cal)
        {
            S = cal.Value1;

            cal.Result = S * S * S;
            return cal.Result ;
        }

    }
    interface IRectangularPrism : I3DShapeServices
    {

    }
    class RectangularPrism : IRectangularPrism
    {
        public decimal L { get; set; }
        public decimal W { get; set; }
        public decimal H { get; set; }
        public decimal Volume(_3DShapeModelView cal)
        {
            L = cal.Value1;
            W = cal.Value2;
            H = cal.Value3;
            cal.Result = L * W * H;
            return cal.Result;
        }
    }
    interface IRightCircularCone : I3DShapeServices
    {

    }
    class RightCircularCone : IRightCircularCone
    {
        public decimal R { get; set; }
        public decimal H { get; set; }
        public decimal Volume(_3DShapeModelView cal)
        {
            R = cal.Value1;
            H = cal.Value2;
            cal.Result = (1 / 3) * (22 / 7) * R * R * H;
            return cal.Result;
        }
    }
    interface IRightCircularCylinder : I3DShapeServices
    {

    }
    class RightCircularCylinder : IRightCircularCylinder
    {
        public decimal H { get; set; }
        public decimal Volume(_3DShapeModelView cal)
        {
            H = cal.Value1;

            cal.Result = (22 / 7) * (22 / 7) * H;
            return cal.Result;
        }
    }
    interface IRightSquarePyramid : I3DShapeServices
    {

    }
    class RightSquarePyramid : IRightSquarePyramid
    {
        public decimal S { get; set; }
        public decimal H { get; set; }
        public decimal Volume(_3DShapeModelView cal)
        {
            S = cal.Value1;
            H = cal.Value2;

            cal.Result = (1 / 3) * S * S * H;
            return cal.Result;
        }
    }
    interface ISphere : I3DShapeServices
    {

    }
    class Sphere : ISphere
    {
        public decimal R { get; set; }
        public decimal Volume(_3DShapeModelView cal)
        {
            R = cal.Value1;

            cal.Result = (4 / 3) * (22 / 7) * (R * R * R);
            return cal.Result;
        }
    }

}
