using System;

namespace CSharp.LabExercise1
{
    internal class Program
    {
        static void Number1()
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");
            Console.WriteLine("");
            while (true)
            {

                Console.Write("Enter length: ");
                decimal length = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter width: ");
                decimal width = Convert.ToDecimal(Console.ReadLine());

                decimal area = length * width;
                decimal perimeter = (2 * length) + (2 * width);

                Console.WriteLine("Area: {0}", area);
                Console.WriteLine("Perimeter: {0}", perimeter);
                Console.WriteLine("");
                Console.Write("Continue? (y/n): ");
                string choice = Console.ReadLine();
                Console.WriteLine("");

                if ((choice == "y") || (choice == "Y"))
                {
                    continue;
                }
                else if (choice == "n")
                {
                    break;
                }

            }


        }

        static void Number2()
        {
            Console.WriteLine("Welcome to the Letter Grade Calculator");
            Console.WriteLine("");
            while (true)
            {

                Console.Write("Enter numerical grade: ");
                int score = Convert.ToInt32(Console.ReadLine());

                if (score < 60)
                {
                    Console.WriteLine("Letter grade: F");
                }
                else if ((60 <= score) && (score < 67))
                {
                    Console.WriteLine("Letter grade: D");
                }
                else if ((67 <= score) && (score < 80))
                {
                    Console.WriteLine("Letter grade: C");
                }
                else if ((80 <= score) && (score < 88))
                {
                    Console.WriteLine("Letter grade: B");
                }
                else if ((88 <= score) && (score <= 100))
                {
                    Console.WriteLine("Letter grade: A");
                }

                Console.WriteLine("");
                Console.Write("Continue? (y/n): ");
                string choice = Console.ReadLine();
                Console.WriteLine("");

                if ((choice == "y") || (choice == "Y"))
                {
                    continue;
                }
                else if (choice == "n")
                {
                    break;
                }

            }
        }

        static void Number3()
        {
            Console.WriteLine("Welcome to the Download Time Estimator");
            Console.WriteLine("");
            Console.WriteLine("This program calculates how long it will take to download a file with a 56k analog modem.");
            Console.WriteLine("");
            while (true)
            {

                Console.Write("Enter a file size (MB): ");
                int fileSize = Convert.ToInt32(Console.ReadLine());

                decimal totalTime = Convert.ToDecimal(fileSize * 1024 / 5.2);
                int totalHour = (int)Math.Floor(totalTime / 3600);
                int totalMinutes = (Convert.ToInt32(totalTime) - (totalHour * 3600)) / 60;
                int totalSeconds = (Convert.ToInt32(totalTime) - (totalHour * 3600) - (totalMinutes * 60));
                Console.WriteLine(@"A ""56k"" modem will take {0} hours {1} minutes {2} seconds.", totalHour, totalMinutes, totalSeconds);
                Console.WriteLine("");
                Console.Write("Continue? (y/n): ");
                string choice = Console.ReadLine();
                Console.WriteLine("");

                if ((choice == "y") || (choice == "Y"))
                {
                    continue;
                }
                else if (choice == "n")
                {
                    break;
                }

            }
        }

        static void Number4()
        {
            Console.Write("Enter square size: ");
            int squareSize = Convert.ToInt32(Console.ReadLine());
            
           
            for (int row = 1; row <= squareSize; row++)
            {
                for (int col = 1; col <= squareSize; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }


        static void Main(string[] args)
        {
            //Number1();
            //Number2();
            //Number3();
            //Number4();
        }
    }
}
