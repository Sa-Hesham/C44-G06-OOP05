using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment5.interfaces;

namespace assignment5.classes
{
    internal class Rectangle : IRectangle
    {

        public Rectangle(decimal _width , decimal _height)
        {
           Width = _width;
           Height = _height;
        }
        public decimal Width {  get; set; }

        public decimal Height {  get; set; }

        public decimal Area  => Width * Height;

        public void DisplayInfo()
        {
            Console.WriteLine($"Rectangle: Width ={Width} , height={Height}  Area = {Area} ");
        }
    }
}
