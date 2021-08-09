using System;
using System.Collections.Generic;
using System.Text;

namespace EXCEPTIONS
{
    class Car
    {
        
        public string Brand {get; set; }
        public bool TotalLost { get; set; }
        public bool needsrepair { get; set; }
        public Car(string brand , bool totallost, bool needrepair)
        {
            Brand = brand;
            TotalLost = totallost;
            needsrepair = needrepair;
        }
    }
}
