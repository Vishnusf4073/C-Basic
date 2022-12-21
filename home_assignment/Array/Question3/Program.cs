using System;  
public class Exercise3  
{  
    public static void Main() 
{
    Console.Write("Input the number of elements to be stored in the array :");
	int  n = Convert.ToInt32(Console.ReadLine()); 
    int[] a= new int[n];
    int i, sum=0;

       Console.Write("Input {0} elements in the array :\n",n);
       for(i=0;i<n;i++)
        {
	      Console.Write("element - {0} : ",i);
		  a[i] = Convert.ToInt32(Console.ReadLine()); 
	    }

    for(i=0; i<n; i++)
    {
        sum += a[i];
    }

    Console.Write("Sum of all elements stored in the array is : "+ sum);
  }
}
