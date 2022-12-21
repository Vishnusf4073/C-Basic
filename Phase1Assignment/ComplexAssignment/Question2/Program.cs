using System;
namespace Question2;
class Program
{
    static void Main (string[] args)
    {
       
      double  val= 1+2+ pow(2)/ fact(2)+pow(3) / fact(3)+pow(4)/fact(4)+pow(5)/fact(5)+pow(6)/fact(6)+pow(7)/fact(7)+pow(8)/fact(8);

     
       Console.Write(Math.Round(val,4));

        int fact(int num)
        {
            int sum=1;
            for (int i=1; i<=num; i++)
            {
                sum*=i;
            }
            return sum;
        }      

        double pow(int num)
        {
            double p= Math.Pow(2,num);
            return p;
        } 
    }
}