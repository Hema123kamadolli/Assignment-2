using System;
 

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee ID:");
            int id = int.Parse(Console.ReadLine());

             Console.WriteLine("Enter Employee Name:");
             string name = Console.ReadLine();

             Console.WriteLine("Enter Employee Gender (M/F):");
             char gender = char.Parse(Console.ReadLine());

              Console.WriteLine("Enter Employee Salary:");
              double salary = double.Parse(Console.ReadLine());

              Console.WriteLine("Enter Date of Joining (DD/MM/YYYY):");
              DateTime doj = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

              double taxRate = salary > 90000 ? 0.30 : 0.15;
              double taxAmount = salary * taxRate;

              Console.WriteLine("\nID\t  Employee Name  \tEmployee Gender            \tEmployee Salary        \tDOJ");
              Console.WriteLine("------------------------------------------------------------------------------------------------");
              Console.WriteLine($"{id}\t    {name}\t         \t{gender}\t                 \t{salary:C}\t    \t{doj:dd/MM/yyyy}\n");

              Console.WriteLine("You have to pay: " + taxAmount.ToString("C"));
              Console.ReadKey();
        }
    }

}