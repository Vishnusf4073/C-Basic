using System;
namespace Question5;
class Program
{
    static void Main(string[] args)
    {
        double basic_sal=10000;
        double da = basic_sal*(10/100);
        double hra = basic_sal*(10/100);

        double annual_income= 12*(basic_sal+da+hra);
        double tax = annual_income*(5/100);

        double total_sal=annual_income-tax;
        Console.Write($"the total annual salary is : {total_sal}");
    }
}