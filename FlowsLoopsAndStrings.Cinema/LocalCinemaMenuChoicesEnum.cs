using System.ComponentModel;

namespace FlowsLoopsAndStrings.Cinema;

public enum LocalCinemaMenuChoicesEnum
{
    [Description("Do you qualify for Youth or Pensioner ticket?")]
    YouthPensionerCheck = 1,

    [Description("Group ticket purchase")]
    GroupTicketPurchase = 2,

    [Description("Exit")]
    Exit = 0,

    [Description("Enter your age")]
    EnterYourAgePrompt = -1,

    [Description("How many visitors")]
    EnterTheNumberOfVisitorsPrompt = -2

}
