using System;
namespace DateTime1;
class Program
{
    public  static void Main(string[] args)
    {
       DateTime dob = new DateTime(2021,8,10,10,40,32);
       string  date=dob.ToString();
       string[] separater ={",","/",":"," "};
       string [] datestr=date.Split(separater,StringSplitOptions.None);
       int len=datestr.Length;
       for (int i =len-1;i>=0;i--)
       {
            Console.Write(datestr[i]+" ");
       }
       DateTime da;
       Console.WriteLine("\nEnter he date format yyyy/mm/dd hh:mm/ss: ");
       da= DateTime.Parse(Console.ReadLine());
       
       string date_time=da.ToString();
       string[] separaters ={",","/",":"," "};
       string [] datestrs=date_time.Split(separater,StringSplitOptions.None);
       int lens=date_time.Length;
        Console.Write("The date is: ");
        for (int i =len-4;i>=0;i--)
       {
            Console.Write(datestrs[i]+" ");
       }

    }
}