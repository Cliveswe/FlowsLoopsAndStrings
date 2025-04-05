
using FlowsLoopsAndStrings.Cinema;
using FlowsLoopsAndStrings.Helpers;
using FlowsLoopsAndStrings.Repeat10Times;

namespace FlowsLoopsAndStrings;
public class FlowsLoopsAndStrings
{
    public FlowsLoopsAndStrings()
    {

    }

    public static void Start()
    {
        int choice;
        bool done = false;

        do
        {

            DisplayMenu();
            choice = ReadUserChoice(MainMenuEnum.Prompt);
            switch (choice)
            {
                case (int)MainMenuEnum.GoToTheCinema:

                LocalCinema? localCinema = new();
                localCinema.GroupTicketPurchase();
                break;
                case (int)MainMenuEnum.Repeat10Times:

                RepeatInput? repeat10Times = new();
                repeat10Times.RepeatInputedText();
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
    private static int ReadUserChoice(Enum prompt)
    {

        Utilities.GetEnumDecryption(prompt, out string promptMessage);

        Console.Write($"{promptMessage}: ");

        if (!int.TryParse(Console.ReadLine(), out int userChoice))
        {
            InputErrorDisplayMessage();
            userChoice = -1;
        }

        return userChoice;
    }

    /// <summary>
    /// Inform the user that they inputed an incorrect choice.
    /// </summary>
    private static void InputErrorDisplayMessage()
    {

        Utilities.ErrorTextColour();
        Utilities.GetEnumDecryption(MainMenuEnum.WrongChoice, out string message);
        Console.WriteLine($"{Environment.NewLine}{message}");
        Utilities.ResetTextColour();
    }

    /// <summary>
    /// Display a formated main menu.
    /// </summary>
    private static void DisplayMenu()
    {

        Console.WriteLine("***********************************");
        Console.WriteLine("* Choose an option from the menu. *");
        Console.WriteLine("***********************************");

        string exit = "";

        foreach (MainMenuEnum mainMenuEnum in Enum.GetValues(typeof(MainMenuEnum)))
        {

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
            if (Utilities.GetEnumDecryption(mainMenuEnum, out string res))
            {

                Utilities.DisplayChoice((int)mainMenuEnum, res);
            }
        }

        if (!string.IsNullOrEmpty(exit))
        {
            Utilities.DisplayChoice((int)MainMenuEnum.Exit, exit);
        }

        Console.WriteLine("-----------------------------------");
    }//end of DisplayMenu



}//end of class

