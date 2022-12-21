using System;
namespace switch_assignment;
    class Program
    {
        public static void Main (string[] args)
        {
            string ch;
          do{
            
                Console.WriteLine("Enter the first Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Second  Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("1)addtion : \n2)subtration :\n3)Multiplication:\n4)Division:\n");
                Console.WriteLine("Enter your Choice: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
               {
                    case 1:
                    {
                        Console.WriteLine(Addtion(num1,num2));
                        break;
                    }
                    case 2 :
                    {
                        Console.WriteLine(Subtration(num1,num2));
                        break;
                    }
                    case 3 :
                    {
                        Console.WriteLine(Multiplication(num1,num2));
                        break;
                    }
                    case 4 :
                    {
                        Console.WriteLine(Division(num1,num2));
                        break;
                    }
            
                }
           
                Console.WriteLine("Do you Want to repeat again");
                ch=Console.ReadLine();
           
            }while(ch=="yes");

            //methods
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
    