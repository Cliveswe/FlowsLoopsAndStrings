using System.ComponentModel;

namespace FlowsLoopsAndStrings.Cinema;

public enum CinemaPriceCategoriesEnum
{
    [Description("Youth younger than")]
    Youth = 20,
    [Description("Youth ticket price")]
    YouthTicketPrice = 80,
    [Description("Pensioner older than")]
    Pensioner = 64,
    [Description("Pensioner ticket price")]
    PensionerTicketPrice = 90,
    [Description("Standard ticket price")]
    StandardTicketPrice = 120
}
