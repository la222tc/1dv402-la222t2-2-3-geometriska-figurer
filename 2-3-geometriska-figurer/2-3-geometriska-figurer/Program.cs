using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    enum Shapetype { Indefinite, Ellips, Rektangel }


    class Program
    {
        private static Shape CreateShape(Shapetype shapetype)
        {
            double length = ReadDoubleGreaterThanZero("Ange längden: ");
            double width = ReadDoubleGreaterThanZero("Ange bredden: ");

            switch (shapetype)
            {
                case Shapetype.Ellips:
                    return new Ellipse(length, width);

                case Shapetype.Rektangel:
                    return new Rectangle(length, width);
                default:
                    return null;
            }
        }
        static void Main(string[] args)
        {
            int menuChoice;

            do
            {
                ViewMenu();
                while (true)
                {
                    try
                    {
                        menuChoice = int.Parse(Console.ReadLine());
                        if (menuChoice < 0 || menuChoice > 2)
                        {
                            throw new ArgumentException();
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("FEL! Ange ett nummer mellan 0-2.");
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine("Tryck på valfri tagent för att fortsätta");
                        Console.ResetColor();
                        Console.ReadKey(true);
                        ViewMenu();
                    }

                }
                switch (menuChoice)
                {
                    case 0:
                        return;

                    case 1:
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine(" ╔═══════════════════════════════════╗ ");
                        Console.WriteLine(" ║              Ellipse              ║ ");
                        Console.WriteLine(" ╚═══════════════════════════════════╝ ");
                        Console.ResetColor();
                        Console.WriteLine();
                        ViewShapeDetail(CreateShape(Shapetype.Ellips));

                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine(" ╔═══════════════════════════════════╗ ");
                        Console.WriteLine(" ║             Rektangel             ║ ");
                        Console.WriteLine(" ╚═══════════════════════════════════╝ ");
                        Console.ResetColor();
                        Console.WriteLine();
                        ViewShapeDetail(CreateShape(Shapetype.Rektangel));
                        break;
                }


            } while (true);




        }
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            double number;

            while (true)
            {
                Console.Write(prompt);
                try
                {
                    number = double.Parse(Console.ReadLine());
                    if (number < 1)
                    {
                        throw new ArgumentException();
                    }
                    return number;
                }
                catch (Exception)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("Ange ett tal större än 0");
                    Console.WriteLine();
                    Console.ResetColor();
                }
            }
        }
        private static void ViewMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔═══════════════════════════════════╗ ");
            Console.WriteLine(" ║        Geometriska figurer        ║ ");
            Console.WriteLine(" ╚═══════════════════════════════════╝ ");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(" 0. Avsluta.");
            Console.WriteLine(" 1. Ellipse.");
            Console.WriteLine(" 2. Rektangel.");
            Console.WriteLine("\n ═══════════════════════════════════════════\n");
            Console.Write(" Ange menyval [0-2]: ");



        }
        static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine(" ╔═══════════════════════════════════╗ ");
            Console.WriteLine(" ║              Detaljer             ║ ");
            Console.WriteLine(" ╚═══════════════════════════════════╝ ");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(shape.ToString());
            Console.WriteLine("\n ═══════════════════════════════════════════\n");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Tryck på valfri tagent för att fortsätta");
            Console.ResetColor();
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}