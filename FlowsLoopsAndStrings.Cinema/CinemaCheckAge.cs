using FlowsLoopsAndStrings.Helpers;

namespace FlowsLoopsAndStrings.Cinema;

public class CinemaCheckAge
{
    private string ticketPriceInfo;
    private decimal ticketPrice;

    public decimal TicketPrice
    {
        get { return ticketPrice; }
        private set { ticketPrice = value; }
    }
    public string TicketPriceInfo
    {
        get { return ticketPriceInfo; }
        private set { ticketPriceInfo = value; }
    }

    public CinemaCheckAge()
    {
        TicketPrice = 0M;
        TicketPriceInfo = "";
    }
    /// <summary>
    /// Validate the visitors age.
    /// </summary>
    /// <param name="VisitorsAge">The age of the visitor to the cinema as a int.</param>
    public void ValidateYouthOrPensioner(int VisitorsAge)
    {

        //If you are a Youth your ticket will be a youth ticket
        if (VisitorsAge < (int)CinemaPriceCategoriesEnum.Youth)
        {

            if (Utilities.GetEnumDecryption(CinemaPriceCategoriesEnum.YouthTicketPrice, out ticketPriceInfo))
            {

                ticketPrice = (decimal)CinemaPriceCategoriesEnum.YouthTicketPrice;
            }
        }//If you are a Pensioner your ticket will be a pensioners ticket
        else if (VisitorsAge > (int)CinemaPriceCategoriesEnum.Pensioner)
        {

            if (Utilities.GetEnumDecryption(CinemaPriceCategoriesEnum.PensionerTicketPrice, out ticketPriceInfo))
            {

                ticketPrice = (decimal)CinemaPriceCategoriesEnum.PensionerTicketPrice;
            }
        }
        else//If you are neither Pensioner or Youth your ticket will be a standard ticket
        {
            if (Utilities.GetEnumDecryption(CinemaPriceCategoriesEnum.StandardTicketPrice, out ticketPriceInfo))
            {

                ticketPrice = (decimal)CinemaPriceCategoriesEnum.StandardTicketPrice;
            }
        }
    }

    /// <summary>
    /// Display the cinema ticket price.
    /// </summary>
    /// <param name="ticketPriceInfo">Information on what you ticket is as a string.</param>
    /// <param name="ticketPrice">Price of your ticket as int.</param>
    public void DisplayTicketPrice()
    {
        Console.WriteLine($"{TicketPriceInfo}: {string.Format("{0:c}", TicketPrice)}");
    }

    /// <summary>
    /// Get the visitors age from the user.
    /// </summary>
    /// <returns>The age of the cinema visitor as int.</returns>
    public int GetVisitorsAge()
    {
        int userAge = 0;
        do
        {

            userAge = Utilities.ReadUserChoice(LocalCinemaMenuChoicesEnum.EnterYourAgePrompt);
        } while (userAge <= (int)LocalCinemaMenuChoicesEnum.Exit);

        return userAge;
    }
}//end of class
