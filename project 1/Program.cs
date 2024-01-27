using System;

public class parking
{
    static void Main(string[] args)
    {
        //declaration of variables
        int choose = 0;
        int longparking = 1;
        int shortparking = 2;
        int Nofdays;
        int Nofhours;
        int charges = 40;
        int bcharges;
        int Tcharges;
        int exit;


        while (true)
        {
            if (choose == 3)
            {
                Console.WriteLine("Exiting");
                break;
            }



            Console.WriteLine($"Types of parking at airport: \n\n - Long Term parking : \n   charges = $40/day + $25 one-time fee \n - Short term parking \n   charges : $3/hr and can not park more than 13hr per day \n ");

            //Taking user input
            Console.Write($"Enter your choice \n -press 1 for long term parking \n -press 2 for short term parking: \n -press 3 to exit: \n");
            choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine("You choose long term parking");
                Console.Write("Enter the number of days you want to park for: ");
                Nofdays = Convert.ToInt32(Console.ReadLine());

                // calculating the total charges
                bcharges = charges * Nofdays;
                Tcharges = (bcharges) + 25; //$25 are the additional one time charge
                Console.WriteLine($"Your total charges are = ${bcharges} + additional one time fee of $25 \n\n so the sub-total is = ${Tcharges}");

            }
            else if (choose == 2)
            {
                Console.WriteLine("You choose short term parking");
                Console.WriteLine("Enter the number of hours you want to park for: \n ");

                Console.WriteLine("********************\n");
                Nofhours = Convert.ToInt32(Console.ReadLine());




                if (Nofhours > 13 && Nofhours <= 24)
                {
                    Console.WriteLine("**************\n\n");
                    Console.WriteLine("The total charges for the hourly parking will be: $40 \n");
                    Console.WriteLine("**************\n");
                }
                else if (Nofhours > 24)
                {
                    Console.WriteLine("**************\n\n");
                    Console.WriteLine(" Please choose long term parking \n");
                    Console.WriteLine("**************\n\n");
                }
                else
                {


                    //calculating the total charges for short term parking

                    Tcharges = ((Nofhours - 1) * 3) + 4;
                    Console.WriteLine($" The total charges for the hourly parking will be: {Tcharges}");
                }

            }
            else if (choose != 3)
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }
}



