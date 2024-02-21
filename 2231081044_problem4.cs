
using System;

namespace Hoss
{
public static class Program 
{         
    public static void Main(string[] args)
    {
          //UU_2231081044, Md. Murad Hossain
	   //fine average and minimum value of an array using foreach loop
	   int[] myArray = {45,89,80,15,23,24,66,49,38,77};
	   
	   int sum = 0;
	   int count = 0;
	   int mini = myArray[0];
	   foreach( int value in myArray)
	   {
	      sum +=value;
	       Console.Write("{0 } ",value); 
	       count++;
	       // fine minimum value 
	      if (value < mini)
	       {
	           mini= value;
	       }
	       
	   }
	   
	   double avg = (sum/count);

	   Console.WriteLine("\nAverage : {0}",avg);
	   Console.WriteLine("Minimum Number : {0}", mini);
	
    }
 }
}
