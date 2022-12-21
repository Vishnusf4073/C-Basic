using System;
namespace Strimg9;
public class Program
{
	public static void Main()
	{
  string str1,str2;
  bool m;
	
       
        Console.Write("Input the string : ");
               str1 = Console.ReadLine();	

	    Console.Write("Input the substring to  search : ");
               str2 = Console.ReadLine();
               m=str1.Contains(str2); 
    if (m)
		Console.Write("The substring exists in the string.\n\n");
	else
		Console.Write("The substring is not exists in the string. \n\n");
	}
}
