using System;

namespace EXCEPTIONS
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage gar = new Garage(new string[] { "toyota", "suzuki", "sunny", "going marry" },4);
            gar.Addcar(new Car("sunny",true,true));
        }
    }
}
