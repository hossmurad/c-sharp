
using System;

namespace Hoss
{
public static class Program 
{         
    public static void Main()
    {
          //UU_2231081044, Md. Murad Hossain
	    //input
		int a,b;
		Console.WriteLine("Enter two number : ");
		a = Convert.ToInt32(Console.ReadLine());
		b = Convert.ToInt32(Console.ReadLine());
		//output
		Console.WriteLine("{0}+{1}={2}",a,b,a+b);
		Console.WriteLine("{0}-{1}={2}",a,b,a-b);
		Console.WriteLine("{0}*{1}={2}",a,b,a*b);
		Console.WriteLine("{0}/{1}={2}",a,b,a/b);
    }
 }
}
