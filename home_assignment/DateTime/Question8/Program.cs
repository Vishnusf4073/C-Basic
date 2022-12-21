using System;

public class Program
{
   public static void Main()
   {
      DateTime thisDate = DateTime.Today;


      DateTime thisDateNextYear, thisDateLastYear;


      thisDateNextYear = thisDate.AddYears(1);
      thisDateLastYear = thisDate.AddYears(-1);   

      
      Console.WriteLine($" {thisDate.ToShortDateString()} is later than {thisDateLastYear.ToShortDateString()} ");
      Console.WriteLine($" {thisDate.ToShortDateString()} is earlier than {thisDateNextYear.ToShortDateString()} ");
                        

      
   }
}
