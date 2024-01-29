using System;

public class Assignment2
{
    static void Main(string[] args)
    {
        //Declaration of variables
         const float salary = 1000;
        float t_salary;
        bool exitRequested = false;
        int totalEarnings = 0;
        float gross_tax = 0.1F;

        //Message will be displayed to exit the program or continue with the program
        while (!exitRequested)
        {
            Console.WriteLine("Enter 1 to exit, or any other number to continue:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1)
            {
                Console.WriteLine("Goodbye! Exiting the program.");
                exitRequested = true;
            }
            else
            {
                Console.Write("Enter the number of employees: \n");
                int emp = Convert.ToInt32(Console.ReadLine());
                //int[] employees = new int[emp];

                //for loop to print the number of employees again and again
                for (int i = 1; i <= emp; ++i)
                {
                    Console.Write($"Gross sales of employee {i} for the 12 months are:\n \n");


                    Console.WriteLine("****************************\n\n");

                    int totalGrossSales = 0;

                    //for loop to print the gross_sales of employees again and again for 12 months
                    for (int j = 1; j <= 12; ++j)
                    {
                        Console.WriteLine($"Enter the gross sales for employee {i} of month {j}: \n");
                        int gross_sales = Convert.ToInt32(Console.ReadLine());

                        totalGrossSales += gross_sales;

                    }
                    float Per_month_earnings = salary + (gross_tax * totalGrossSales);

                    totalEarnings += totalGrossSales;
                    Console.WriteLine($"The Earnings per month for employee {i} are: {Per_month_earnings}\n");
                }

                Console.WriteLine($"Total Earnings for all employees: {totalEarnings}\n");
            }
        }
    }
}