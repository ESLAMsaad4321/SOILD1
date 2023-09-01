using SOLID.Models;

namespace SOILD1.Serivces
{
    public interface I2DShapeServices
    {
         decimal Area(_2DShapeModelView cal);
        
    }
    interface ISquare : I2DShapeServices
    {

    }
    class Square : ISquare
    {
        public decimal Base { get; set; }
        public decimal Height { get; set; }


        public decimal Area(_2DShapeModelView cal)
        {
            Base = cal.Value1;
            Height = cal.Value2;
            cal.Result = Base * Height;
            return cal.Result;
        }
    }
    interface IKite : I2DShapeServices
    {

    }
    class Kite : IKite
    {
        public decimal Length { get; set; }
        public decimal Height { get; set; }
        public  decimal Area(_2DShapeModelView cal)
        {
            Length = cal.Value1;
            Height = cal.Value2;
            cal.Result = (Length * Height) / 2;
            return cal.Result;
        }
    }
    interface IRectangle : I2DShapeServices
    {

    }
    class Rectangle : IRectangle
    {
        public decimal Base { get; set; }
        public decimal Height { get; set; }

        public  decimal Area(_2DShapeModelView cal)
        {
            Base = cal.Value1;
            Height = cal.Value2;
            cal.Result = Base * Height;
            return cal.Result;
        }
    }
    interface IRhombus : I2DShapeServices
    {

    }
    class Rhombus : IRhombus
    {
        public decimal Length { get; set; }
        public decimal Height { get; set; }
        public  decimal Area(_2DShapeModelView cal)
        {
            Length = cal.Value1;
            Height = cal.Value2;
            cal.Result = (Length * Height) / 2;
            return cal.Result;
        }
    }
    interface ITrapezium : I2DShapeServices
    {

    }
    class Trapezium : ITrapezium
    {
        public decimal a { get; set; }

        public decimal b { get; set; }
        public decimal Height { get; set; }


        public  decimal Area(_2DShapeModelView cal)
        {
            a = cal.Value1;
            b = cal.Value2;
            Height = cal.Value3;


            cal.Result = ((a + b) * Height) / 2;
            return cal.Result;
        }
    }
    interface ITriangle : I2DShapeServices
    {

    }
    class Triangle : ITriangle
    {
        public decimal Base { get; set; }
        public decimal PerpendicularHeight { get; set; }

        public decimal Area(_2DShapeModelView cal)
        {
            Base = cal.Value1;
            PerpendicularHeight = cal.Value2;
            cal.Result = (Base * PerpendicularHeight) / 2;
            return cal.Result;
        }
    }
}
