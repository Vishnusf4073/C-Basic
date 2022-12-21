using System;

class dttimeex51
{
    static void Main()
    {
  
	DateTime now = DateTime.Now;
	Console.WriteLine(" The date of Today : {0}",now.ToString("dd/MM/yyyy"));
	Console.WriteLine(" The 12 months are :");
	for (int i = 0; i < 12; i++)
	{
	    Console.WriteLine(" {0}",now.ToString("MMMM"));
	    now = now.AddMonths(1);
	}
	Console.WriteLine();
    }
}
