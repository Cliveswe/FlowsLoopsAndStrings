
using FlowsLoopsAndStrings.Helpers;

namespace FlowsLoopsAndStrings.Cinema;

public class CinemaGroupPrice
{
    public CinemaGroupPrice()
    {

    }
    public decimal TotalTicketPrice(decimal ticketPrice)
    {
        decimal totalTicketPrice = 0;

        return totalTicketPrice;

    }
    internal int GetNumberOfVisitors()
    {

        int numberOfVisitors = 0;
        do
        {

            numberOfVisitors = Utilities.ReadUserChoice(LocalCinemaMenuChoicesEnum.EnterTheNumberOfVisitorsPrompt);
        } while (numberOfVisitors <= (int)LocalCinemaMenuChoicesEnum.Exit);

        return numberOfVisitors;

    }

}//end of class
