using FlowsLoopsAndStrings.Helpers;

namespace FlowsLoopsAndStrings.Cinema;

public class CinemaCheckAge
{
    private string ticketPriceInfo;
    private decimal ticketPrice;
    private int visitorsAge;

    /// <summary>
    /// Price of a ticket.
    /// </summary>
    public decimal TicketPrice
    {
        get { return ticketPrice; }
        private set { ticketPrice = value; }
    }

    /// <summary>
    /// The person the ticket is valid for.
    /// </summary>
    public string TicketPriceInfo
    {
        get { return ticketPriceInfo; }
        private set { ticketPriceInfo = value; }
    }

    /// <summary>
    /// Visitors age.
    /// </summary>
    public int VisitorsAge
    {
        get { return visitorsAge; }
        private set { visitorsAge = value; }
    }

    public CinemaCheckAge()
    {
        TicketPrice = 0M;
        TicketPriceInfo = "No data available.";
    }

    /// <summary>
    /// Method that runs that check the age of the visitor.
    /// </summary>
    public void VisitorsTicketPrice()
    {
        GetVisitorsAge();
        ValidateYouthOrPensioner();
        DisplayTicketPrice();
    }

    /// <summary>
    /// Validate the visitors age.
    /// </summary>
    private void ValidateYouthOrPensioner()
    {
        if ((VisitorsAge < (int)CinemaPriceCategoriesEnum.Child) ||
            (VisitorsAge > (int)CinemaPriceCategoriesEnum.Centennial))
        {

            if (Utilities.GetEnumDecryption(CinemaPriceCategoriesEnum.Free, out ticketPriceInfo))
            {

                TicketPrice = (decimal)CinemaPriceCategoriesEnum.Free;
            }
        }//If you are a Youth your ticket will be a youth ticket
        else if (VisitorsAge < (int)CinemaPriceCategoriesEnum.Youth)
        {

            if (Utilities.GetEnumDecryption(CinemaPriceCategoriesEnum.YouthTicketPrice, out ticketPriceInfo))
            {

                TicketPrice = (decimal)CinemaPriceCategoriesEnum.YouthTicketPrice;
            }
        }//If you are a Pensioner your ticket will be a pensioners ticket
        else if (VisitorsAge > (int)CinemaPriceCategoriesEnum.Pensioner)
        {

            if (Utilities.GetEnumDecryption(CinemaPriceCategoriesEnum.PensionerTicketPrice, out ticketPriceInfo))
            {

                TicketPrice = (decimal)CinemaPriceCategoriesEnum.PensionerTicketPrice;
            }
        }
        else//If you are neither Pensioner or Youth your ticket will be a standard ticket
        {
            if (Utilities.GetEnumDecryption(CinemaPriceCategoriesEnum.StandardTicketPrice, out ticketPriceInfo))
            {

                TicketPrice = (decimal)CinemaPriceCategoriesEnum.StandardTicketPrice;
            }
        }
    }

    /// <summary>
    /// Display the cinema ticket price.
    /// </summary>
    private void DisplayTicketPrice()
    {
        Console.WriteLine($"{TicketPriceInfo}: {string.Format("{0:c}", TicketPrice)}");
    }

    /// <summary>
    /// Get the visitors age from the user.
    /// </summary>
    private void GetVisitorsAge()
    {
        bool validAge = false;
        do
        {

            VisitorsAge = Utilities.ReadUserChoice(LocalCinemaMenuChoicesEnum.EnterYourAgePrompt);
            if (VisitorsAge > (int)LocalCinemaMenuChoicesEnum.Exit)

            {
                validAge = true;
            }
            else
            {

                Utilities.NewLine();
                Utilities.CustomErrorMessage("Please enter a realistic age.");
                Utilities.NewLine();
            }

        } while (!validAge);


    }
}//end of class
