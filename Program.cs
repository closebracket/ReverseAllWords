using ReverseAllWords.Helpers;

// Variables
string greeting = "Welcome to StringRever$e, Type something and it will be reversed!\n";
string userinput = "\n" + "Enter word to be reversed:";
string inputToReverse;
bool runProgram;
// Console Info
Console.Title = "StringRever$e";
ConsoleKeyInfo keyStroke;

// Prompt the user
Prompts.Prompt(greeting);
runProgram = true;
try
{
    while (runProgram == true)
    {
        Prompts.Prompt(userinput);
        keyStroke = Console.ReadKey(true);
        if (keyStroke.Key == ConsoleKey.Escape) { break; }
        // Accept input from the user
        inputToReverse = Console.ReadLine();
        Reverse.SingleTextMethod(inputToReverse);
        Prompts.Prompt(Globals.outputReversed);

    }

    Console.CancelKeyPress += new ConsoleCancelEventHandler(TerminalControls.terminalEventHandler);
}
catch
{
    Prompts.Prompt("There was an error accepting input");
}

