
using System;

namespace Hoss
{
public static class Program 
{    
    
    static void AreaOFCircle(double radius)
    {
        //const value
        const double PI = 3.1416;
        double area =( PI* (radius* radius));
        Console.WriteLine("Area of the circle is : {0} meter",area);
    }
    
    
    
    public static void Main(string[] args)
    {
          //UU_2231081044, Md. Murad Hossain
	    //input radius of the circle
	    double radius;
	    Console.Write("Enter the Radius of the Circle (meter): ");
	    radius = Convert.ToDouble(Console.ReadLine());
	    //calling method
	    AreaOFCircle(radius);
    }
 }
}
