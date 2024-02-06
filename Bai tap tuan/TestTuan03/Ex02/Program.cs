using System;
using ClassLibrary1;

    class ClassDemo2
    {
        public static void Main()
        {
            // declare a Car object reference named myCar
            System.Console.WriteLine("Creating a Car object");
            Car myCar = new Car();
            myCar.make = "Toyota";
            // Car objects have an Engine object
            System.Console.WriteLine("Creating an Engine object");
            myCar.engine = new Engine();
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
