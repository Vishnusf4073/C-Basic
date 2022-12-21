using System;  
namespace Question7;
class Program
{  
    public static void Main() 
{
        int i,j;
    	int[,] arr1 = new int[50,50];
		int[,] brr1 = new int[50,50];
		int[,] crr1 = new int[50,50];
   
   
       Console.Write("Input elements in the first matrix :\n");
       for(i=0;i<3;i++)
        {
            for(j=0;j<3;j++)
            {
	           Console.Write($"element at [{i},{j}]: ");
			   arr1[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }   
  
       Console.Write("Input elements in the second matrix :\n");
       for(i=0;i<3;i++)
        {
            for(j=0;j<3;j++)
            {
	           Console.Write($"element at [{0},{1}] : ");
		       brr1[i,j] = Convert.ToInt32(Console.ReadLine());			   
            }
        }    
   Console.Write("\nThe First matrix is :\n");
  for(i=0;i<3;i++)
    {
      Console.Write("\n");
      for(j=0;j<3;j++)
           Console.Write(arr1[i,j]+" ");
    }
  
  Console.Write("\nThe Second matrix is :");
  for(i=0;i<3;i++)
    {
      Console.Write("\n");
      for(j=0;j<3;j++)
      Console.Write(brr1[i,j]+" ");
    }  
   for(i=0;i<3;i++)
       for(j=0;j<3;j++)
            crr1[i,j]=arr1[i,j]+brr1[i,j];
   Console.Write("\nThe Addition of two matrix is :");
   for(i=0;i<3;i++){
       Console.Write("\n");
       for(j=0;j<3;j++)
            Console.Write(crr1[i,j]+" ");
   }
   Console.Write("\n\n");
  }
}
