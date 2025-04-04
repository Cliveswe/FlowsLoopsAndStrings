
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

    public CinemaGroupPrice()
    {

    }
    public decimal TotalTicketPrice()
    {
        decimal totalTicketPrice = 0;
        CinemaCheckAge cinemaCheckAge = new CinemaCheckAge();

        for (int visitorNumber = 0; visitorNumber < numberOfVisitors; visitorNumber++)
        {


        }
        return totalTicketPrice;

    }
    internal void GetNumberOfVisitors()
    {

        do
        {

            numberOfVisitors = Utilities.ReadUserChoice(LocalCinemaMenuChoicesEnum.EnterTheNumberOfVisitorsPrompt);
        } while (numberOfVisitors <= (int)LocalCinemaMenuChoicesEnum.Exit);

    }

}//end of class
