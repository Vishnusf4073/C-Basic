using System;
namespace Dates;
class Program
{
    public static void Main(string[] args)
    {
       DateTime da;
       Console.WriteLine("\nEnter he date format yyyy/mm/dd hh:mm/ss: ");
       da= DateTime.Parse(Console.ReadLine());
       Console.WriteLine("day:"+da.Day);
        Console.WriteLine("month:"+da.Month);
         Console.WriteLine("Year:"+da.Year);
      Console.WriteLine("Hour:"+da.Hour);
       Console.WriteLine("Minute:"+da.Minute);
        Console.WriteLine("second:"+da.Second);
        
    }
}