using FlowsLoopsAndStrings.Helpers;

namespace FlowsLoopsAndStrings.Cinema;

public class LocalCinema
{
    public LocalCinema()
    {

    }
    public void Start()
    {
        bool done = false;
        int choice = 0;

        Utilities.CinemaClearScreen();
        Utilities.CinemaTextColour();

        do
        {

            DisplayMenu();
            choice = Utilities.ReadUserChoice(MainMenuEnum.Prompt);

        } while (!done);

        Utilities.ResetTextColour();
    }

    /// <summary>
    /// Display a formated local cinema menu.
    /// </summary>
    private void DisplayMenu()
    {

        Console.WriteLine("***********************************************");
        Console.WriteLine("***      Welcome to your local Cinema.      ***");
        Console.WriteLine("***********************************************");

        string exit = "";

        foreach (LocalCinemaMenuChoicesEnum menuChoice in
            Enum.GetValues(typeof(LocalCinemaMenuChoicesEnum)))
        {
            string choice = "";
            if (menuChoice == LocalCinemaMenuChoicesEnum.Exit)
            {
                Utilities.GetEnumDecryption(menuChoice, out exit);
                continue;

            }

            if (Utilities.GetEnumDecryption(menuChoice, out choice))
            {
                DisplayChoice((int)menuChoice, choice);
            }
        }

        if (!string.IsNullOrEmpty(exit))
        {
            DisplayChoice((int)LocalCinemaMenuChoicesEnum.Exit, exit);
        }

        Console.WriteLine("-----------------------------------------------");
    }

    private void DisplayChoice(int MenuNumber, string MenuDescription) =>
        Console.WriteLine($"{MenuNumber} {MenuDescription}");



}//end of class
