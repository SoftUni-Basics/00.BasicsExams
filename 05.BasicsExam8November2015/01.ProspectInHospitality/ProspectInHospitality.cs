using System;

class ProspectInHospitality
{
    static void Main()
    {
        decimal builders = uint.Parse(Console.ReadLine()) * 1500.04m;
        decimal receptionists = uint.Parse(Console.ReadLine()) * 2102.10m;
        decimal chambermaids = uint.Parse(Console.ReadLine()) * 1465.46m;
        decimal technicians = uint.Parse(Console.ReadLine()) * 2053.33m;
        decimal others = uint.Parse(Console.ReadLine()) * 3010.98m;

        decimal nikiSalary = decimal.Parse(Console.ReadLine()) * decimal.Parse(Console.ReadLine());     // Niki salary * USD rate
        decimal yourSalary = decimal.Parse(Console.ReadLine());

        decimal budget = decimal.Parse(Console.ReadLine());

        decimal result = builders + receptionists + chambermaids + technicians + others + nikiSalary + yourSalary;

        if (result <= budget)
        {
            Console.WriteLine("The amount is: {0:F} lv.", result);
            Console.WriteLine(@"YES \ Left: {0:F} lv.", budget - result);
        }
        else
        {
            Console.WriteLine("The amount is: {0:F} lv.", result);
            Console.WriteLine(@"NO \ Need more: {0:F} lv.", result - budget);
        }
    }
}
