using System;
using System.Threading;

namespace LoveCompatibilityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Love Compatibility Calculator 💕";

            // Header
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine("║              LOVE COMPATIBILITY CALCULATOR            ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();

            Random random = new Random();
            string again = "yes";

            while (again.ToLower() == "yes")
            {
                // Input section
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Enter the first name: ");
                Console.ResetColor();
                string name1 = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Enter the second name: ");
                Console.ResetColor();
                string name2 = Console.ReadLine();

                // Loading effect
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Calculating love compatibility between {name1} and {name2}");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(600);
                    Console.Write(".");
                }
                Console.WriteLine("\n");
                Console.ResetColor();
                Thread.Sleep(1000);

                // Generate compatibility
                int compatibility = random.Next(0, 101);

                // Divider
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("═════════════════════════════════════════════════════════");
                Console.ResetColor();

              
                if (compatibility == 100)
                    Console.ForegroundColor = ConsoleColor.Magenta;
                else if (compatibility >= 90)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else if (compatibility >= 75)
                    Console.ForegroundColor = ConsoleColor.Cyan;
                else if (compatibility >= 50)
                    Console.ForegroundColor = ConsoleColor.White;
                else
                    Console.ForegroundColor = ConsoleColor.Gray;

                // Result 
                Console.WriteLine("╔════════════════════════════════╗");
                Console.WriteLine($"║   Compatibility Score: {compatibility,3}%    ║"); 
                Console.WriteLine("╚════════════════════════════════╝");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.White;
                if (compatibility == 100)
                    Console.WriteLine("YIEEEEEEE NGUMITI SHAAAAA");
                else if (compatibility >= 90)
                    Console.WriteLine("ITO NABA ANG NANINIWALA NA AKO SA 4EVER MAGMULA NUNG NAKILALA KITA??!?!");
                else if (compatibility >= 75)
                    Console.WriteLine("KAPIT LANG HABANG MAY BUHAY MAY??? (PAGASA) HABANG BUHAY MAY??? (PAGASA) ---- pagsubok");
                else if (compatibility >= 50)
                    Console.WriteLine("MURA LANG GAYUMA SA RECTO");
                else
                    Console.WriteLine("HAHAHHAHAHAHHAHAHAHAHAHHAHAAH");
                Console.ResetColor();  

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("═════════════════════════════════════════════════════════");
                Console.ResetColor();

                Console.Write("\nWould you like to test another pair? (yes/no): ");
                again = Console.ReadLine();
                Console.WriteLine();
            }

            // Exit 
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine("║    Thank you for using the Love Compatibility App!    ║");
            Console.WriteLine("║    May love and positivity always follow your way!    ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

            Console.WriteLine("Hello po, try lang.");



        }
    }
}
