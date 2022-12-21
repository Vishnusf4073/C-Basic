using System;
namespace switch_assignment;
    class Program
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Enter the first Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second  Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1)addtion :+ \n 2)subtration :-\n 3)Multiplication:*\n 4)Division:/ \n 5)modulo:%");
            
            Console.WriteLine("Enter your Choice: ");
            
            int temp = Convert.ToInt32(Console.ReadLine());

            switch(temp)
            {
                case 1:
                {
                    Console.WriteLine("the sum : "+(num1+num2));
                    break;
                }
                case 2 :
                {
                    Console.WriteLine("the sub : "+(num1-num2));
                    break;
                }
                case 3 :
                {
                    Console.WriteLine("the Mul : "+(num1*num2));
                    break;
                }
                case 4 :
                {
                    Console.WriteLine("the Div : "+(num1/num2));
                    break;
                }
                case 5:
                {
                    Console.WriteLine("the mod : "+(num1%num2));
                    break;
                }
                default:
                {
                    Console.WriteLine("Invaild input");
                    break;
                }

            }
     
        }
    }