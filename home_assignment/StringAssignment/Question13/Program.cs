
using System;
namespace String13;
class Program{
	
public static void Main()
{
	string str;
	Console.Write("Enter a string ");
	str = Console.ReadLine();
	int count, sum = 0;
	int n = str.Length;
	
	for(count = 0; count < n; count++)
	{
	
		if ((str[count] >= '0') && (str[count] <= '9'))
		{
			sum += (str[count] - '0');
		}
	}
	Console.WriteLine("Sum = " + sum);
}
}
