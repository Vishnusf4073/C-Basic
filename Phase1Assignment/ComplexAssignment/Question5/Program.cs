using System;
namespace Question5;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the the dob: ");
        DateTime dob = DateTime.Parse(Console.ReadLine());
        TimeSpan da = DateTime.Now - dob;
        int y=da.Days;
        y=y/365;
        Console.Write("Your age is: "+y+" \nDay you were born was: "+dob.DayOfWeek);
        Console.Write("\nDays: "+da.Days+"\nhours: "+da.Hours+"\nMinutes: "+da.Minutes+"\nseconds: "+da.Seconds+"\nMilliseconds: "+da.Milliseconds);

    }
     
}