﻿using System; 
namespace Array5;
{
    
} 
 class Array5
{  
    public static void Main() 
{
    int[] arr1= new int[100];
    int i, max, min, n;
	
	
       Console.Write("\n\nFind maximum and minimum element in an array :\n");
       Console.Write("--------------------------------------------------\n");	

       Console.Write("Input the number of elements to be stored in the array :");
	   n= Convert.ToInt32(Console.ReadLine());  
   
       Console.Write("Input {0} elements in the array :\n",n);
       for(i=0;i<n;i++)
            {
	      Console.Write("element - {0} : ",i);
		  arr1[i] = Convert.ToInt32(Console.ReadLine());  
	    }
    max = arr1[0];
    min = arr1[0];

    for(i=1; i<n; i++)
    {
        if(arr1[i]>max)
        {
            max = arr1[i];
        }


        if(arr1[i]<min)
        {
            min = arr1[i];
        }
    }
    Console.Write("Maximum element is : "+ max);
    Console.Write("\nMinimum element is : "+ min);
  }	
}