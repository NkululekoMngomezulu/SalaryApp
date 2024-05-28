using System;

namespace SalaryApp;

class SalaryApp
{
    public static void Main(string[] args)
    {
        int hours;
        double rate, salary;

        Console.WriteLine("enter hours");
        hours = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter Rate");
        rate = Convert.ToDouble(Console.ReadLine());

        salary = rate * hours;
        Console.WriteLine("your salary is:" + salary);
    }
}
