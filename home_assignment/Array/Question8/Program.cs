using System;  
public class Exercise19  
{  
    public static void Main() 
{
        int i,j,n;
    	int[,] arr1 = new int[50,50];
		int[,] brr1 = new int[50,50];
		int[,] crr1 = new int[50,50];
   
        Console.Write("Input the size of the square matrix (less than 5): ");
	   n = Convert.ToInt32(Console.ReadLine());	   
  

       Console.Write("Input elements in the first matrix :\n");
       for(i=0;i<n;i++)
        {
            for(j=0;j<n;j++)
            {
	           Console.Write($"element at [{i},{j}]: ");
			   arr1[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }   
  
       Console.Write("Input elements in the second matrix :\n");
       for(i=0;i<n;i++)
        {
            for(j=0;j<n;j++)
            {
	           Console.Write($"element at [{0},{1}] : ");
		       brr1[i,j] = Convert.ToInt32(Console.ReadLine());			   
            }
        }    
   Console.Write("\nThe First matrix is :\n");
  for(i=0;i<n;i++)
    {
      Console.Write("\n");
      for(j=0;j<n;j++)
           Console.Write(arr1[i,j]+" ");
    }
  
  Console.Write("\nThe Second matrix is :");
  for(i=0;i<n;i++)
    {
      Console.Write("\n");
      for(j=0;j<n;j++)
      Console.Write(brr1[i,j]+" ");
    }  
   for(i=0;i<n;i++)
       for(j=0;j<n;j++)
            crr1[i,j]=arr1[i,j]+brr1[i,j];
   Console.Write("\nThe Addition of two matrix is :");
   for(i=0;i<n;i++){
       Console.Write("\n");
       for(j=0;j<n;j++)
            Console.Write(crr1[i,j]+" ");
   }
   Console.Write("\n\n");
  }
}
