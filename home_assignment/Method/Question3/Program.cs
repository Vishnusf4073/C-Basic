using System;
namespace Method;
    class Program
    {
        public static void Main (string[] args)
        {
                Console.Write("Enter the number1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the number2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                prints(num1,num2);
            void prints(int num1,int num2)
                {
                    int num3=num1;
                    num1=num2;
                    num2=num3;
                    Console.Write("Now the 1st number is : "+num1);
                    Console.Write("\nNow the 2nd number is : "+num2);
                }
           
            }     
        }
    