using System;
namespace question1
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Enter Your name: ");
            string name = Console.ReadLine();
          
            Console.WriteLine("Enter Your age: ");
            string age = Console.ReadLine();
          
            Console.WriteLine("Enter mark of subject1: ");
            int sub1 = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("Enter Your of subject2: ");
            int sub2 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter Your of subject3: ");
            int sub3 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter Grade: ");
            string grade = (Console.ReadLine());
           
            Console.WriteLine("Enter Your mobile number: ");
            string mob = Console.ReadLine();
           
            Console.WriteLine("Enter Your Gmail id: ");
            string mail_id = Console.ReadLine();
           
            float sum=sub1+sub2+sub3;
           
            Console.WriteLine($"Name : {name} ");
            Console.WriteLine($"Age : {age} ");
            Console.WriteLine($"mobile number : {mob} ");
            Console.WriteLine($"Marks1 : {sub1} ");
            Console.WriteLine($"Marks2 : {sub2} ");
            Console.WriteLine($"Marks3 : {sub3} ");
            Console.WriteLine("Total : "+sum);
            Console.WriteLine("Average : "+ Math.Round((sum/3),1));
            Console.WriteLine($"grade : {grade} ");
            Console.WriteLine($"Mail id : {mail_id} ");
            
        }
    }
}