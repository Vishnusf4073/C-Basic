 using System;
 namespace DateTime2;
class Example8
{
   public static void Main()
   {
      DateTime da;
       Console.WriteLine("\nEnter he date format yyyy/mm/dd hh:mm/ss: ");
       da= DateTime.Parse(Console.ReadLine());

      
      Console.WriteLine("General format " +da.ToString());
      Console.WriteLine("Display the date in a variety of formats: ");
       Console.WriteLine(da.ToString("dd/MM/yyyy HH:mm:ss"));
      Console.WriteLine("Complete: "+da.ToLongDateString()); 
      Console.WriteLine("Short date: "+da.ToShortDateString());
      Console.WriteLine(da.ToString("dd/MM/yyyy hh:mm:ss tt"));
      Console.WriteLine("Short date: "+da.ToString("D"));
      
   }
}
