using System;
using System.ComponentModel.Design;

namespace Calculator3000
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Write(Menu());
                choice = Convert.ToInt32(Console.ReadLine());
                string result = MenuChoice(choice);
                Console.WriteLine(result);
            } while (choice != 3);

            Console.ReadLine();

        }

        public static string Menu()
        {
            return " *****Menu***** \n"
                   + " 1 - Create Character \n"
                   + " 2 - Options \n"
                   + " 3 - Exit Game \n"
                   + " \n "
                   + " Choice ? \n ";
        }

        public static string MenuChoice(int choice)
        {
            string result = "";

            switch (choice)
            {
                case 1:
                    result += " Character Creation In Progress ! ";
                    break;
                case 2:
                    result += " Options In Progress !";
                    break;
                case 3:
                    result += " Bye Bye !";
                    break;
                default:
                    result += " Nice Try ! Try Again !";
                    break;
                
            }
            return result;
        }
    }
}