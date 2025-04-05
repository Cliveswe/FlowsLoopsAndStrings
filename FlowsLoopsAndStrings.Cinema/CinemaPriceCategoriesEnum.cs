using System.ComponentModel;

namespace FlowsLoopsAndStrings.Cinema;

public enum CinemaPriceCategoriesEnum
{
    [Description("No cost")]
    Free = 0,

    [Description("Child younger than")]
    Child = 5,

    [Description("Youth younger than")]
    Youth = 20,

    [Description("Youth ticket price")]
    YouthTicketPrice = 80,

    [Description("Pensioner older than")]
    Pensioner = 64,

    [Description("Pensioner ticket price")]
    PensionerTicketPrice = 90,

    [Description("Centennial younger than")]
    Centennial = 100,

    [Description("Standard ticket price")]
    StandardTicketPrice = 120
}
