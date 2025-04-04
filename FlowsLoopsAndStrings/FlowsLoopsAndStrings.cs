using FlowsLoopsAndStrings.Helpers;

namespace FlowsLoopsAndStrings;
public class FlowsLoopsAndStrings
{
    public FlowsLoopsAndStrings()
    {

    }

    public void Start()
    {
        DisplayMenu();

        Console.ReadKey();
    }//end of Start

    private void DisplayMenu()
    {
        Console.WriteLine("***********************************");
        Console.WriteLine("* Choose an option from the menu. *");
        Console.WriteLine("***********************************");

        string exit = "";

        foreach (MainMenuEnum mainMenuEnum in Enum.GetValues(typeof(MainMenuEnum)))
        {
            string res;

            //exit to be added at the end of the displayed menu
            if (mainMenuEnum == MainMenuEnum.Exit)
            {

                Utils.GetEnumDecryption(mainMenuEnum, out exit);
                continue;
            }

            if (Utils.GetEnumDecryption(mainMenuEnum, out res))
            {

                DisplayChoice((int)mainMenuEnum, res);
            }
        }

        if (!string.IsNullOrEmpty(exit))
        {
            DisplayChoice((int)MainMenuEnum.Exit, exit);
        }
    }//end of DisplayMenu

    private void DisplayChoice(int MenuNumber, string MenuDecryption) => Console.WriteLine($"{MenuNumber} {MenuDecryption}");


}//end of class

