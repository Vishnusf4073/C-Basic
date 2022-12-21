using System;
public class Example
{  
    public static void Main()
        {
        int[] mark=new int [3];
         int sum=0;

            marks();

        void marks()
        {
            for(int i=0;i<3;i++)
            {
                Console.Write($"Enter the marks{i} - ");
                mark[i]=Convert.ToInt32(Console.ReadLine());
                sum+=mark[i];
            }
            for(int i=0;i<3;i++)
            {
                Console.Write($"Marks-{i+1} {mark[i]}\n");
            }
            Console.Write("\nPercentage: "+sum*100/300);
        }
        }
}      
