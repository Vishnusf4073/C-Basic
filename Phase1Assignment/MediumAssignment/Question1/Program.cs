using System;
namespace Question1;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the salary: ");
        double basic_sal= Convert.ToDouble(Console.ReadLine());
        double total_sal=0;
        if (basic_sal<=10000)
        {
            double da = basic_sal*(20/100);
            double hra = basic_sal*(80/100);

            double annual_income= 12*(basic_sal+da+hra);
            double tax = annual_income*(6/100);
            double insu=annual_income*(1/100);

             total_sal=annual_income-tax-insu;
        }
        else if (basic_sal<=20000)
        {
            double da = basic_sal*(25/100);
            double hra = basic_sal*(90/100);

            double annual_income= 12*(basic_sal+da+hra);
            double tax = annual_income*(6/100);
            double insu=annual_income*(1/100);

            total_sal=annual_income-tax-insu;
        }
        else if (basic_sal>20000)
        {
            double da = basic_sal*(30/100);
            double hra = basic_sal*(95/100);

            double annual_income= 12*(basic_sal+da+hra);
            double tax = annual_income*(6/100);
            double insu=annual_income*(1/100);

             total_sal=annual_income-tax-insu;
        }
        Console.WriteLine($"the total annual salary is : {total_sal}\n");
    }
}