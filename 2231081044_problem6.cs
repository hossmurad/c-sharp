
using System;

namespace Hoss
{
public static class Program 
{    
    
    static void AreaOFTriangle(double a,double b, double c)
    {
        double s = (a+b+c)/2;
        double area = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
        //output win rounded to four decimal places
        Console.WriteLine("Area of the triangle is : {0}",Math.Round(area,4));
    }
    
    
    
    public static void Main(string[] args)
    {
          //UU_2231081044, Md. Murad Hossain
	    //input a,b,c of the tringle
	    double a,b,c;
	    Console.Write("Enter the value of a : ");
	   a = Convert.ToDouble(Console.ReadLine());
	    Console.Write("Enter the value of b : ");
	   b = Convert.ToDouble(Console.ReadLine());
	    Console.Write("Enter the value of c : ");
	   c = Convert.ToDouble(Console.ReadLine());
	    //calling method
	    AreaOFTriangle(a,b,c);
    }
 }
}
