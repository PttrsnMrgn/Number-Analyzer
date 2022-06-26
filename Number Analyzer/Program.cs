Console.WriteLine("Hello! My name is Morgan. What is yours?");
string name = Console.ReadLine();

Console.WriteLine($"\nWelcome {name}! I would love share some facts" +
 $" with you about integers.");

string restart;

do 
{
    Console.WriteLine("\nPlease enter a number between 1 & 100:");

    int input = int.Parse(Console.ReadLine());
  
    Console.WriteLine($"\n{name}, you entered the number {input}.");

    if (input % 2 == 1 && input > 0 && input < 60)
    {
        Console.WriteLine($"{input} is an odd number less than 60.");
    }
    if (input % 2 == 0 && input > 0 && input < 25)
    {
        Console.WriteLine($"{input} is an even number less than 25.");
    }
    if (input % 2 == 0 && input > 0 && input >= 26 && input <= 60)
    {
        Console.WriteLine($"{input} is an even number and between 26 and 60 inclusive.");
    }
    if (input % 2 == 0 && input > 60 && input <=100)
    {
        Console.WriteLine($"{input} is an even number greater than 60.");
    }
    if (input % 2 == 1 && input > 0 && input > 60 && input <=100)
    {
        Console.WriteLine($"{input} is an odd number greater than 60.");
    }
    if (input < 1 || input > 100)
    {
        Console.WriteLine("Whoops! Numbers between 1 & 100 only please!");
    }
    Console.WriteLine("\nWould you like more integer facts? Enter YES/NO:");

    restart = Console.ReadLine().ToLower();
}
while (restart == "yes");

Console.WriteLine("\nSEE YA LATER!");

System.Threading.Thread.Sleep(5000);

Environment.Exit(0);








