using System;
using static System.Net.WebRequestMethods;

class Car
{
    public Car() 
    {
        color = "Red";
       
    }
    public Car(int yearBuilt)
    {
        this.yearBuilt = yearBuilt;
    }
    public Car(string _color)
    {
        //yearBuilt = _yearBuilt;
        color = _color;
    }
    // declare the fields
    public string make;
    public string model;
    public string color;
    public int yearBuilt;
    // define the methods
    public void Start()
    {
        System.Console.WriteLine(model + " started");
    }
    public void Stop()
    {
        System.Console.WriteLine(model + " stopped");
    }
    public override string ToString()
    {
        string _result;
        _result = "myCar details:";
        _result += "\n myCar.make = " + this.make;
        _result += "\n myCar.model = " + this.model;
        _result += "\n myCar.color = " + this.color;
        _result += "\n myCar.yearBuilt = " + this.yearBuilt;
        return _result;
    }
}
class ClassDemo
{
    public static void Main()
    {
        // declare a Car object reference named myCar
        Car myCar;
        // create a Car object, and assign its address to myCar
        System.Console.WriteLine("Creating a Car object and assigning " +
        "its memory location to myCar");
        myCar = new Car();
        // assign values to the Car object's fields using myCar
        myCar.make = "Toyota";
        myCar.model = "MR2";
        myCar.color = "black";
        myCar.yearBuilt = 1995;
        // display the field values using myCar
        Print(myCar);
        // call the methods using myCar
        myCar.Start();
        myCar.Stop();
        // declare another Car object reference and
        // create another Car object
        System.Console.WriteLine("Creating another Car object and " +
        "assigning its memory location to redPorsche");
        Car redPorsche = new Car();
        redPorsche.make = "Porsche";
        redPorsche.model = "Boxster";
        redPorsche.color = "red";
        redPorsche.yearBuilt = 2000;
        System.Console.WriteLine("redPorsche is a " + redPorsche.model);
        // change the object referenced by the myCar object reference
        // to the object referenced by redPorshe
        System.Console.WriteLine("Assigning redPorsche to myCar");
        myCar = redPorsche;
        myCar = new Car();
        myCar = null;
        Print(myCar);
        // assign null to myCar (myCar will no longer reference an
        // object)
        myCar.Start();  
        Console.ReadLine();
    }

    private static void Print(Car myCar)
    {
        System.Console.WriteLine(myCar);
    }
}
