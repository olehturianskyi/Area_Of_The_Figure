using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Of_The_Figure
{
    internal class Program
    {

        //  переименовать названия методов, чтобы они содержали в себе глагол и отвечали на вопрос что метод делает
        //  изучить как работат методы с параметрами на примере методов для трапеции и считывания с консоли 
        
        // вынесли этот код в отдельный метод, чтобы он не дубрировался в каждом кейсе
        // Console.SetCursorPosition(5, 14);
        // Console.Write("The area of the figure is " + Convert.ToString(result) + " square units");  



        static void Main(string[] args)
        {
            Console.Title = "Calculating the area of a geometric figure";

            SetBackGround();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(7, 5);
            Console.WriteLine("Practical work # 1");
            Console.SetCursorPosition(7, 7);
            Console.WriteLine("Completed by a student: Oleg Turyansky");
            Console.SetCursorPosition(7, 9);
            Console.WriteLine("Project manager:        Andriy Olehovych Turyansky");
            PressAnyKey();

            SetBackGround();
            string choise = BuildMainMenu();
            SetBackGround();

            double result;
            switch (choise)
            {
                case "1":
                    result = Circle();
                    Console.SetCursorPosition(5, 14);
                    Console.Write("The area of the figure is " + Convert.ToString(result) + " square units");
                    break;
                case "2":
                    result = Rectangle();
                    Console.SetCursorPosition(5, 14);
                    Console.Write("The area of the figure is " + Convert.ToString(result) + " square units");
                    break;
                case "3":
                    result = Triangle();
                    Console.SetCursorPosition(5, 14);
                    Console.Write("The area of the figure is " + Convert.ToString(result) + " square units");
                    break;
                case "4":
                    result = Trapezoid();
                    Console.SetCursorPosition(5, 14);
                    Console.Write("The area of the figure is " + Convert.ToString(result) + " square units");
                    break;
                default:
                    //the code is executed if the expression does not have any of the above values
                    break;
            }
            PressAnyKey();



            //*********************************************************************************;
        }
        public static void SetBackGround()
        {
            Console.WindowWidth = 80;
            Console.WindowHeight = 30;
            int width = Console.WindowWidth, height = Console.WindowHeight, i, j;
            char s1 = '█';
            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (i = 3; i < width - 2; i++)
            {
                for (j = 3; j < height - 2; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.WriteLine(s1);
                }
            }
            Console.ResetColor();
            for (i = 2; i < width - 3; i++)
            {
                for (j = 2; j < height - 3; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.WriteLine(s1);
                }
            }
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(3, 3);
            Console.WriteLine('╔');
            Console.SetCursorPosition(3, height - 5);
            Console.WriteLine('╚');
            Console.SetCursorPosition(width - 5, 3);
            Console.WriteLine('╗');
            Console.SetCursorPosition(width - 5, height - 5);
            Console.WriteLine('╝');
            for (i = 0; i < width - 9; i++)
            {
                Console.SetCursorPosition(4 + i, height - 5);
                Console.WriteLine('═');
            }
            for (i = 0; i < width - 9; i++)
            {
                Console.SetCursorPosition(4 + i, 3);
                Console.WriteLine('═');
            }

            for (i = 0; i < height - 9; i++)
            {
                Console.SetCursorPosition(3, height - 6 - i);
                Console.WriteLine('║');
            }
            for (i = 0; i < height - 9; i++)
            {
                Console.SetCursorPosition(width - 5, height - 6 - i);
                Console.WriteLine('║');
            }
        }
        public static void PressAnyKey()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(34, 24);
            Console.Write("PRESS ANY KEY");
            Console.ReadKey();

        }
        public static string BuildMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(24, 10); Console.Write("Calculate the area of a figure:");
            Console.SetCursorPosition(25, 11); Console.Write("     (make a choice)");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(33, 15); Console.Write("1-circle");
            Console.SetCursorPosition(33, 16); Console.Write("2-rectangle");
            Console.SetCursorPosition(33, 17); Console.Write("3-triangle");
            Console.SetCursorPosition(33, 18); Console.Write("4-trapezoid");
            Console.SetCursorPosition(46, 11);
            string ch = Console.ReadLine();
            return ch;
        }
        public static double Circle()
        {
            Console.SetCursorPosition(5, 8);
            Console.Write(" Input RADIUS => ");
            double r = double.Parse(Console.ReadLine());
            double s = Math.PI * Math.Pow(r, 2);
            return s;
        }
        public static double Triangle()
        {
            Console.SetCursorPosition(5, 8);
            Console.Write(" Input a => ");
            double a = double.Parse(Console.ReadLine());
            Console.SetCursorPosition(5, 10);
            Console.Write(" Input h => ");
            double h = double.Parse(Console.ReadLine());
            double s = (a * h) / 2;
            return s;

        }
        public static double Rectangle()
        {
            Console.SetCursorPosition(5, 8);
            Console.Write(" Input a => ");
            double a = double.Parse(Console.ReadLine());
            Console.SetCursorPosition(5, 10);
            Console.Write(" Input b => ");
            double b = double.Parse(Console.ReadLine());
            double s = a * b;
            return s;
        }
        public static double Trapezoid()
        {
            double a = GetValueFromConsole(" Input a => ", 5, 8);
            double b = GetValueFromConsole(" Input b => ", 5, 10);
            double h = GetValueFromConsole(" Input h => ", 5, 12);

            return GetTrapezoidSquare(a, b, h);
        }

        public static double GetTrapezoidSquare(double a, double b, double h)
        {
            return ((a + b) / 2) * h;
        }

        public static double GetValueFromConsole(string writeText, int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(writeText);
            double value = double.Parse(Console.ReadLine());
            return value;
        }
    }
}
