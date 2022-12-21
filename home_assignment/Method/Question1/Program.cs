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

                Console.Write("1)addtion :");
                        Console.Write(Addtion(num1,num2)+"\n");
                        Console.Write("1)Subtraction :");
                        Console.Write(Subtration(num1,num2)+"\n");
                        Console.Write("1)Multiplication :");
                        Console.Write(Multiplication(num1,num2)+"\n");
                        Console.Write("1)Division :");
                        Console.Write(Division(num1,num2)+"\n");
                        
            int Addtion(int val1,int val2)
                {
                    return(val1+val2);
                }
            int Subtration(int num1,int num2)
                {
                    return(num1-num2);
                }
            int Multiplication(int num1,int num2)
                {
                    return(num1*num2);
                }
            int Division(int num1,int num2)
                {
                    return(num1/num2);
                }
            }     
        }
    