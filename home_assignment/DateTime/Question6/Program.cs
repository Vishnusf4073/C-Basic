using System;
class Program 
{
   public static void Main()
   {
      
   
    	DateTime today = DateTime.Now;
		DateTime res = today.AddDays(40);
        Console.WriteLine("Today:"+today);
        Console.WriteLine("40 days from today:"+res);
   }
}
