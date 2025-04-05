
using FlowsLoopsAndStrings.Helpers;

namespace FlowsLoopsAndStrings.Cinema;

public class CinemaGroupPrice
{
    private int numberOfVisitors;

    public int NumberOfVisitors
    {
        get { return numberOfVisitors; }
        private set { numberOfVisitors = value; }
    }

    private decimal totalPrice;

    public decimal TotalPrice
    {
        get { return totalPrice; }
        private set { totalPrice += value; }
    }

    public CinemaGroupPrice()
    {
        NumberOfVisitors = 0;
        TotalPrice = 0;
    }

    public void Run()
    {
        GetNumberOfVisitors();
        TotalTicketPrice();
        DisplayTicketPriceTotal();
    }

    private void DisplayTicketPriceTotal()
    {
        Console.WriteLine("Total price for all tickets.");
        Console.WriteLine($"{NumberOfVisitors} tickets costs {string.Format("{0:c}", TotalPrice)}");
        Utilities.NewLine();
    }

    private void TotalTicketPrice()
    {
        CinemaCheckAge cinemaCheckAge = new CinemaCheckAge();

        for (int visitorNumber = 0; visitorNumber < NumberOfVisitors; visitorNumber++)
        {
            cinemaCheckAge.VisitorsTicketPrice();
            TotalPrice = cinemaCheckAge.TicketPrice;

        }
    }

    private void GetNumberOfVisitors()
    {
        bool validatNumberOfVisitors = false;

        do
        {

            numberOfVisitors = Utilities.ReadUserChoice(LocalCinemaMenuChoicesEnum.EnterTheNumberOfVisitorsPrompt);
            if (numberOfVisitors > (int)LocalCinemaMenuChoicesEnum.Exit)
            {
                validatNumberOfVisitors = true;
            }
            else
            {
                Utilities.ErrorTextColour();
                Console.WriteLine("There must be at least 1 visitor.");
                Utilities.CinemaTextColour();
                Utilities.NewLine();
            }
        } while (!validatNumberOfVisitors);

    }

}//end of class
