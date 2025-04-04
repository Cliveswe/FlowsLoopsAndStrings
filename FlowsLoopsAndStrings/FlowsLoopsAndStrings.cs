using FlowsLoopsAndStrings.Helpers;

namespace FlowsLoopsAndStrings;
public class FlowsLoopsAndStrings
{
    public FlowsLoopsAndStrings()
    {

    }

    public void Start()
    {
        int choice = 0;
        bool done = false;
        do
        {
            DisplayMenu();
            choice = ReadUserChoice(MainMenuEnum.Prompt);
            switch (choice)
            {
                case (int)MainMenuEnum.GoToTheCinema:
                Console.WriteLine("Going to the cinema!");
                LocalCinema().Start();
                break;
                case (int)MainMenuEnum.Exit:
                Console.WriteLine("Bye!");
                done = true;
                break;
                default:
                InputErrorDisplayMessage();
                break;
            }

        } while (!done);

    }//end of Start

    /// <summary>
    /// Get the user menu choice. If the user choice is number then return the choice 
    /// </summary>
    /// <param name="prompt">Select a message from a Enum.</param>
    /// <returns>The user choice as a number int otherwise -1 for an incorrect choice.</returns>
    private int ReadUserChoice(Enum prompt)
    {
        int userChoice = -1;
        string promptMessage = "";

        Utilities.GetEnumDecryption(prompt, out promptMessage);

        Console.Write($"{promptMessage}: ");

        if (!int.TryParse(Console.ReadLine(), out userChoice))
        {
            InputErrorDisplayMessage();
            userChoice = -1;
        }

        return userChoice;
    }

    /// <summary>
    /// Inform the user that they inputed an incorrect choice.
    /// </summary>
    private void InputErrorDisplayMessage()
    {
        string message = "";

        ErrorTextColour();
        Utilities.GetEnumDecryption(MainMenuEnum.WrongChoice, out message);
        Console.WriteLine($"{Environment.NewLine}{message}");
        ResetTextColour();
    }

    /// <summary>
    /// Display a formated main menu.
    /// </summary>
    private void DisplayMenu()
    {
        Console.WriteLine("***********************************");
        Console.WriteLine("* Choose an option from the menu. *");
        Console.WriteLine("***********************************");

        string exit = "";

        foreach (MainMenuEnum mainMenuEnum in Enum.GetValues(typeof(MainMenuEnum)))
        {
            string res;

            //exit to be added at the end of the displayed menu
            if (mainMenuEnum == MainMenuEnum.Exit)
            {

                Utilities.GetEnumDecryption(mainMenuEnum, out exit);
                continue;
            }

            //skip the wrong choice enum
            if ((mainMenuEnum == MainMenuEnum.WrongChoice) || (mainMenuEnum == MainMenuEnum.Prompt))
            {
                continue;
            }

            //Get the menu choice decryption
            if (Utilities.GetEnumDecryption(mainMenuEnum, out res))
            {

                DisplayChoice((int)mainMenuEnum, res);
            }
        }

        if (!string.IsNullOrEmpty(exit))
        {
            DisplayChoice((int)MainMenuEnum.Exit, exit);
        }

        Console.WriteLine("-----------------------------------");
    }//end of DisplayMenu

    /// <summary>
    /// Format and display a menu choice.
    /// </summary>
    /// <param name="MenuNumber">The key menu choice as an int.</param>
    /// <param name="MenuDescription">Text Description of the menu choice as String</param>
    private void DisplayChoice(int MenuNumber, string MenuDescription) => Console.WriteLine($"{MenuNumber} {MenuDescription}");

    private void ErrorTextColour() => Console.ForegroundColor = ConsoleColor.Cyan;
    private void ResetTextColour() => Console.ResetColor();
}//end of class

