using System;  
namespace Array6;
public class Array6 
{  
    public static void Main() 
{
	int[] arr1 = new int[10];
    int n, i, j, tmp;

    Console.Write("Input the size of array : ");
    n = Convert.ToInt32(Console.ReadLine()); 

       Console.Write("Input {0} elements in the array :\n",n);
       for(i=0;i<n;i++)
            {
	      Console.Write("element at {0} : ",i);
		 arr1[i] = Convert.ToInt32(Console.ReadLine());  
	    }

    for(i=0; i<n; i++)
    {
        for(j=i+1; j<n; j++)
        {
            if(arr1[j] < arr1[i])
            {
                tmp = arr1[i];
                arr1[i] = arr1[j];
                arr1[j] = tmp;
            }
        }
    }
    Console.Write("\nElements of array in sorted ascending order:");
    for(i=0; i<n; i++)
    {
        Console.Write( arr1[i]+" ");
    }
		    
  }

}