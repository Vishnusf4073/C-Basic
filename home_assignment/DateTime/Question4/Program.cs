using System;
namespace DateTimeex;
class Program
{
   public static void Main()
   {
     Console.WriteLine( "Enter the date:");
         DateTime da=DateTime.Parse(Console.ReadLine());
         Console.WriteLine("the day of the week is:" +da.DayOfWeek);
         
         
      }                 
               
      
   }

