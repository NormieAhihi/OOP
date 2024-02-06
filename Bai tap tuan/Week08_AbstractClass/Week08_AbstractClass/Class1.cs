using System;
using static System.Net.WebRequestMethods;

public interface ISeries
{
    int getNext(); // return next number in series
    void reset(); // restart
    void setStart(int x); // set starting value
}
public abstract class clsSeries
{
   public abstract int getNext(); // return next number in series
   public abstract void reset(); // restart
   public abstract void setStart(int x); // set starting value
}
// Implement ISeries.
class ByTwos : clsSeries
{
    int start;
    int val;
    public ByTwos()
    {
        start = 0;
        val = 0;
    }
    public override int getNext()
    {
        val += 2;
        return val;
    }
    public override void reset()
    {
        val = start;
    }
    public override void setStart(int x)
    {
        start = x;
        val = start;
    }
}
class ByThrees : ISeries
{
    int start;
    int val;
    public int getNext()
    {
        val += 3;
        return val;
    }
    public void reset()
    {
        val = start;
    }
    public void setStart(int x)
    {
        start = x;
        val = start;
    }
}
class InterfaceDemo3
{
    static void Main(string[] args)
    {
        ISeries ob = new ByThrees();
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Next value is " +
            ob.getNext());
        Console.WriteLine("\nResetting");
        ob.reset();
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Next value is " +
            ob.getNext());
        Console.WriteLine("\nStarting at 100");
        ob.setStart(100);
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Next value is " +
            ob.getNext());
        Console.ReadLine();
    }
}