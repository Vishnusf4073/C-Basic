using System;

class dttimeex45
{
    static void Main()
    {
	Console.WriteLine(" Today is : {0}", DateTime.Today.ToString("dd/MM/yyyy"));
	DateTime dt = GetTomorrow();
	Console.WriteLine(" The Tomorrow will be : {0} \n", dt.ToString("dd/MM/yyyy"));
    
    DateTime GetTomorrow()
    {
	return DateTime.Today.AddDays(1);
    }
}
}
