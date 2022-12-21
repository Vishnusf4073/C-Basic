using System;

class dttimeex45
{
    static void Main()
    {

	Console.WriteLine(" Today is : {0}", DateTime.Today.ToString("dd/MM/yyyy"));
	DateTime dt = GetTomorrow();
	Console.WriteLine(" The Tomorrow will be : {0}", dt.ToString("dd/MM/yyyy"));
    DateTime da = GetYesterday();
	Console.WriteLine(" The Yesterday was  : {0} \n", dt.ToString("dd/MM/yyyy"));
    }
    static DateTime GetTomorrow()
    {
	return DateTime.Today.AddDays(1);
    }
    static DateTime GetYesterday()
    {
	return DateTime.Today.AddDays(-1);
    }
}

