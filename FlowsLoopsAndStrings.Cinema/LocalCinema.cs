﻿using FlowsLoopsAndStrings.Helpers;

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

        Utilities.ClearScreen();


        do
        {
            Utilities.CinemaTextColour();
            DisplayMenu();
            choice = Utilities.ReadUserChoice(MainMenuEnum.Prompt);
            switch (choice)
            {

                case (int)LocalCinemaMenuChoicesEnum.YouthPensionerCheck:

                CinemaCheckAge cinemaCheckAge = new CinemaCheckAge();
                cinemaCheckAge.ValidatYouthOrPensioner(cinemaCheckAge.GetVisitorsAge());
                Utilities.NewLine();
                break;
                case (int)LocalCinemaMenuChoicesEnum.GroupTicketPurchase:

                break;
                case (int)LocalCinemaMenuChoicesEnum.Exit:
                Utilities.ClearScreen();
                Utilities.ResetTextColour();
                done = true;
                break;
                default:
                Utilities.InputErrorDisplayMessage();
                break;
            }

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

                //dont display the prompts
                if ((int)menuChoice < (int)LocalCinemaMenuChoicesEnum.Exit)
                {

                    continue;
                }

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
