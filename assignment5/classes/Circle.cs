using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment5.interfaces;

namespace assignment5.classes
{
    internal class Circle : ICircle
    {
        public decimal redius { get; }

        public Circle(decimal _redius )
        {
            redius = _redius;
        }
        public decimal Area => 3.14m * redius * redius;

        public void DisplayInfo()
        {
            Console.WriteLine($"circle  redius is {redius} , Area {Area}");
        }
    }
}
