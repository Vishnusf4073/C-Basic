using System;

public class Example16
{
   public static void Main()
   {
      DateTime date1 = new DateTime(2016, 8, 1, 0, 0, 0);
      DateTime date2 = new DateTime(2016, 8, 1, 12, 0, 0);
      int result = DateTime.Compare(date1, date2);
      string res;

      if (result < 0)
         res = "  is earlier than  ";
      else if (result == 0)
         res = "  is the same time as ";         
      else
         res = "  is later than ";

      Console.WriteLine( date1+ res+ date2);
   }
}
