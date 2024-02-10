using System;

public class dental
{
    static void Main(string[] args)
    {
        //Declaration of variables

        int employee = 1;
        int user_employee;
        const int salary = 1000;
        int choose = 0;

        // Message will be displayed to exit the program or continue with the program

        Console.WriteLine($"Press 1 to exit the program or enter any other number to continue");
        choose = Convert.ToInt32(Console.ReadLine());

        while (choose != 1)
        {
            if (choose == 1)
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine($"Enter the number of employees");
                user_employee = Convert.ToInt32(Console.ReadLine());

                while (employee <= user_employee)
                {
                    Console.WriteLine($"The gross sales for employee {employee} for each month are:");

                    double totalGrossSales = 0;
                    double totalearnings = 0;
                     
                    int months = 1; // Reset months for each employee
                    while (months <= 12)
                    {
                        Console.WriteLine($"Enter the gross sales of employee {employee} for month {months}");
                        int gross_sales = Convert.ToInt32(Console.ReadLine());
                        totalGrossSales = salary + (0.1 * gross_sales);
                        totalearnings += totalGrossSales;
                        months++;
                    }

                    Console.WriteLine($"Total earnings of the year for employee {employee} is : ${totalGrossSales}");
                    Console.WriteLine(); 

                    employee++;
                }
            }
        }
    }
}
