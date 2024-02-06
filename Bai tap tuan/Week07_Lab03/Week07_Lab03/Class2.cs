using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week07_Lab03;

namespace Week07_Lab03
{
    public class Light
    {
        public int LightPower;
        public Light() { }
        public void TurnOn()
        {
            System.Console.WriteLine("Light turned on");
        }
    }
    class Car
    {
        // declare the Engine class
        
        // declare the Car fields
        public string make;

        public Light light = new Light();
        public Engine engine = new Engine(); // Car has an Engine
                              // define the Car method
        public void Start()
        {
            engine.Start();
            light.TurnOn();
        }
    }
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
    class ClassDemo3
    {
        public static void Main()
        {
            // declare a Car object reference named myCar
            System.Console.WriteLine("Creating a Car object");
            Car myCar = new Car();
            myCar.make = "Toyota";
            // Car objects have an Engine object
            System.Console.WriteLine("Creating an Engine object");
            
            myCar.engine.cylinders = 4;
            myCar.engine.horsepower = 180;
        
            // display the values for the Car and Engine object fields
            System.Console.WriteLine("myCar.make = " + myCar.make);
            System.Console.WriteLine("myCar.engine.cylinders = " +
            myCar.engine.cylinders);
            System.Console.WriteLine("myCar.engine.horsepower = " +
            myCar.engine.horsepower);
            // call the Car object's Start() method
            myCar.Start();
            Console.ReadLine();
        }
    }
}
