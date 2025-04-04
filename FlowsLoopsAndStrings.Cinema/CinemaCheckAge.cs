using FlowsLoopsAndStrings.Helpers;

namespace FlowsLoopsAndStrings.Cinema;

public class CinemaCheckAge
{
    public CinemaCheckAge()
    {

    }
    /// <summary>
    /// Validate the visitors age.
    /// </summary>
    /// <param name="VisitorsAge">The age of the visitor to the cinema as a int.</param>
    public void ValidatYouthOrPensioner(int VisitorsAge)
    {
        string ticketPriceInfo = "";
        decimal ticketPrice = 0M;

        //If you are a Youth your ticket will be a youth ticket
        if (VisitorsAge < (int)CinemaPriceCategoriesEnum.Youth)
        {

            if (Utilities.GetEnumDecryption(CinemaPriceCategoriesEnum.YouthTicketPrice, out ticketPriceInfo))
            {

                ticketPrice = (decimal)CinemaPriceCategoriesEnum.YouthTicketPrice;
                DisplayTicketPrice(ticketPriceInfo, ticketPrice);
            }
        }//If you are a Pensioner your ticket will be a pensioners ticket
        else if (VisitorsAge > (int)CinemaPriceCategoriesEnum.Pensioner)
        {

            if (Utilities.GetEnumDecryption(CinemaPriceCategoriesEnum.PensionerTicketPrice, out ticketPriceInfo))
            {

                ticketPrice = (decimal)CinemaPriceCategoriesEnum.PensionerTicketPrice;
                DisplayTicketPrice(ticketPriceInfo, ticketPrice);
            }
        }
        else//If you are neither Pensioner or Youth your ticket will be a standard ticket
        {
            if (Utilities.GetEnumDecryption(CinemaPriceCategoriesEnum.StandardTicketPrice, out ticketPriceInfo))
            {

                ticketPrice = (decimal)CinemaPriceCategoriesEnum.StandardTicketPrice;
                DisplayTicketPrice(ticketPriceInfo, ticketPrice);
            }
        }
    }

    /// <summary>
    /// Display the cinema ticket price.
    /// </summary>
    /// <param name="ticketPriceInfo">Information on what you ticket is as a string.</param>
    /// <param name="ticketPrice">Price of your ticket as int.</param>
    private void DisplayTicketPrice(string ticketPriceInfo, decimal ticketPrice)
    {
        Console.WriteLine($"{ticketPriceInfo}: {string.Format("{0:c}", ticketPrice)}");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public int GetVisitorsAge()
    {
        int userAge = 0;
        do
        {

            userAge = Utilities.ReadUserChoice(LocalCinemaMenuChoicesEnum.EnterYourAgePrompt);
        } while (userAge <= (int)LocalCinemaMenuChoicesEnum.Exit);

        return userAge;
    }


}
