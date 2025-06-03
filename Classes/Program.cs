// See https://aka.ms/new-console-template for more information

Console.WriteLine("What is your favorite season?");
string? userInput = Console.ReadLine();

switch (userInput)
{
    case "Summer":
        Console.WriteLine("Wow! I love summer too!");
        break;
    case "Spring":
        Console.WriteLine("Spring is also my favorite");
        break;
    case "Winter":
        Console.WriteLine("Winter is my least favorite :(");
        break;
    case "Fall":
        Console.WriteLine("Fall is okay in my opinion");
        break;
    default:
        Console.WriteLine("Oh, nice conversation I guess");
        break;
}

