using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5.interfaces
{
    internal interface IRectangle:IShape

    {
        decimal Width { get; set; }
        decimal Height { get; set; }
    }
}
