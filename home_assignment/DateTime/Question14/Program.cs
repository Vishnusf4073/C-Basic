using System; 

public class GFG{ 
      
    static public void Main () 
    {  
        Console.Write("Enter the month: ");
        int month = Convert.ToInt32(Console.ReadLine()); 
        Console.Write("Enter the year: ");
        int year = Convert.ToInt32(Console.ReadLine()); 
        Console.Write("Enter the no of Leaves: ");
        int leave = Convert.ToInt32(Console.ReadLine()); 
          
        int days = DateTime.DaysInMonth(year, month);
        days=days-leave;
        Console.Write(days*500);
    }  
}