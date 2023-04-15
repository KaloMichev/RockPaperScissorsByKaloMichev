Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
string input = Console.ReadLine();
string[] options = { "Rock", "Paper", "Scissors" };
Random rand = new Random();
int opponent = rand.Next(options.Length);

string win = "You win.";
string loss = "You lose.";
string draw = "This game was a draw.";

switch (input)
{
    case "r":
        Console.WriteLine($"The computer chose {options[opponent]}.");
        if(options[opponent] == "Scissors")
        {
            Console.WriteLine(win);
        }else if(options[opponent] == "Rock")
        {
            Console.WriteLine(draw);
        }
        else
        {
            Console.WriteLine(loss);
        }
        break;
    case "p":
        Console.WriteLine($"The computer chose {options[opponent]}.");
        if (options[opponent] == "Rock")
        {
            Console.WriteLine(win);
        }
        else if (options[opponent] == "Paper")
        {
            Console.WriteLine(draw);
        }
        else
        {
            Console.WriteLine(loss);
        }
        break;
    case "s":
        Console.WriteLine($"The computer chose {options[opponent]}.");
        if (options[opponent] == "Paper")
        {
            Console.WriteLine(win);
        }
        else if (options[opponent] == "Scissors")
        {
            Console.WriteLine(draw);
        }
        else
        {
            Console.WriteLine(loss);
        }
        break;
    
    default:
        Console.WriteLine("Invalid input. Try again...");
        break;
}
