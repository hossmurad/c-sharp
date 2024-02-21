
using System;

namespace Hoss
{
public static class Program 
{         
    public static void Main(string[] args)
    {
          //UU_2231081044, Md. Murad Hossain
	   //use for loop to print the following seris
	   //n n-1 n-2 n-3 n-4 . . . 0
	   int n;
	   Console.Write("Enter the value of n : ");
	   n = Convert.ToInt32(Console.ReadLine());
	   for (int i =n; i>=0; i--)
	   {
	       Console.Write("{0} ",i);
	   }
	
    }
 }
}
