using System.ComponentModel;

namespace FlowsLoopsAndStrings.Helpers
{
    public enum MainMenuEnum
    {


        [Description("Go to the cinema.")]
        GoToTheCinema = 1,

        [Description("Repeat 10 times!")]
        Repeat10Times,

        [Description("3rd word!")]
        TheThirdWord,

        [Description("Wrong choice, try again!")]
        WrongChoice,

        [Description("Enter a menu option")]
        Prompt,

        [Description("Exit application.")]
        Exit = 0
    }
}
