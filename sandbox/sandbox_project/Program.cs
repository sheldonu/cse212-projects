using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        // Console.WriteLine("Hello Sandbox World!");

        // Console.Write("What is your first name? ");
        // string firstName = Console.ReadLine();

        // Console.Write("What is your last name? ");
        // string lastName = Console.ReadLine();

        // Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

        // Console.Write("Enter a number: ");
        // string number = Console.ReadLine();

        // double x = double.Parse(number);
        // double y = 3.3;

        // if (x > y)
        // {
        //     Console.WriteLine("Greater");
        // }
        // else if (x < y)
        // {
        //     Console.WriteLine("Lesser");
        // }
        // else
        // {
        //     Console.WriteLine("Equal");
        // }

        
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResults(userName, squaredNumber);

    }
        static void DisplayWelcome() 
        {
            Console.WriteLine("Welcome to the program");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        static void DisplayResults(string name, int squared)
        {
            Console.WriteLine($"{name}, the square of your number is {squared}");
        }

}