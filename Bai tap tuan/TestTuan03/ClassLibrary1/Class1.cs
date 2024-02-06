using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Engine
    {
        // declare the Engine fields
        public int cylinders;
        public int horsepower;
        // define the Engine method
        public void Start()
        {
            System.Console.WriteLine("Engine started");
        }
    }
     public class Car
    {
        // declare the Engine class

        // declare the Car fields
        public string make;
        public Engine engine; // Car has an Engine
                              // define the Car method
        public void Start()
        {
            engine.Start();
        }
    }
}
