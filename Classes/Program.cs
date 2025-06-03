// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is your favorite season?");
string? userInput = Console.ReadLine();

switch (userInput.ToLower())
{
    case "summer":
        Console.WriteLine("Wow! I love summer too!");
        break;
    case "spring":
        Console.WriteLine("Spring is also my favorite");
        break;
    case "winter":
        Console.WriteLine("Winter is my least favorite");
        break;
    case "fall":
        Console.WriteLine("The falling leaves are so pretty");
        break;
    default:
        Console.WriteLine("What was that season? I didn't catch it");
        break;
}