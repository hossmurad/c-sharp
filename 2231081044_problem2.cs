
using System;

namespace Hoss
{
public static class Program 
{         
    public static void Main()
    {
          //UU_2231081044, Md. Murad Hossain
	   //sum of the following  series sing for loop
	   // 5+10+15+...+500
	   //using loop
	   int sum =0;
	   for( int i =5;i<=500;i+=5)
	   {
	       sum = sum + i;
	   }
	    
	    Console.WriteLine("Summation of the Seris is : {0}", sum);
	
    }
 }
}
