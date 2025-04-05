
using FlowsLoopsAndStrings.Cinema;
using FlowsLoopsAndStrings.Helpers;
using FlowsLoopsAndStrings.Repeat10Times;

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

                LocalCinema? localCinema = new LocalCinema();
                localCinema.GroupTicketPurchase();
                localCinema = null;
                break;
                case (int)MainMenuEnum.Repeat10Times:

                RepeatInput? repeat10Times = new RepeatInput();
                repeat10Times.RepeatInputedText();
                repeat10Times = null;
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
    /// Display a menu option as text.
    /// </summary>
    /// <param name="menuOption">Enum class containing options and text explaining each option.</param>
    private void DisplayMenuOption(Enum menuOption)
    {
        string prompt = string.Empty;

        Utilities.GetEnumDecryption(menuOption, out prompt);
        Console.WriteLine($"{prompt}");
    }


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

        Utilities.ErrorTextColour();
        Utilities.GetEnumDecryption(MainMenuEnum.WrongChoice, out message);
        Console.WriteLine($"{Environment.NewLine}{message}");
        Utilities.ResetTextColour();
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

