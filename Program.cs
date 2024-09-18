// See https://aka.ms/new-console-template for more information
//Ariel Cann T00422471
using PresidentChecker;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Program
{
    private static string repeat_until_answer()
    {
        string answer = "";
        while (answer != "y" && answer != "n")
        {
            Console.WriteLine("Please enter y or n");
            answer = Console.ReadLine();
        }
        return answer;
    }
    public static void Main()
    {
        Console.WriteLine("Are you a natural born citizen of the United States? Answer y for yes or n for no");
        string answer = Console.ReadLine();
        bool natural;
        if (answer != "y" && answer != "n")
        {
            answer = repeat_until_answer();
        }
        if (answer == "n")
        {
            natural = false;
        }
        else
        {
            natural = true;
        }
        Console.WriteLine("On what date were you born? Please enter in YYYY-MM-DD.");
        answer = Console.ReadLine();
        DateTime birthday;
        while (!DateTime.TryParse(answer,out birthday)){
            Console.WriteLine("Please enter in YYYY-MM-DD.");
        }
         int years = DateTime.Today.Year - birthday.Year;
        Console.WriteLine("How many years have you been legally residing in the United States for?");
        answer = Console.ReadLine();
        int residency;
        while (!Int32.TryParse(answer, out residency) || residency < 0) {
            Console.WriteLine("Please enter a positive number.");    
        }
        Console.WriteLine("How many terms have you served as President for already? ");
        answer = Console.ReadLine();
        int served;
        while (!Int32.TryParse(answer, out served) || served < 0)
        {
            Console.WriteLine("Please enter a positive number.");
        }
        Console.WriteLine("Have you rebelled against the United States? Answer y for yes or n for no");
        answer = Console.ReadLine();
        bool rebel;
        if (answer != "y" && answer != "n")
        {
            answer = repeat_until_answer();
        }
        if (answer == "n")
        {
            rebel = false;
        }
        else
        {
            rebel = true;
        }
        if (Checker.check(years, residency, served, rebel, natural))
        {
            Console.WriteLine("You are eligible to be President.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you aren't eligible to be President.");
        }
    }
}
