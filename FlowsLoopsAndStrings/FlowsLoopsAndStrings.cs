using FlowsLoopsAndStrings.Helpers;

namespace FlowsLoopsAndStrings;

public class FlowsLoopsAndStrings
{
    public FlowsLoopsAndStrings()
    {

    }

    public void Start()
    {
        Console.WriteLine($"testing enums {Utils.GetEnumDecryption(MainMenuEnum.Exit)}");
        Console.WriteLine($"testing enums {Utils.GetEnumDecryption(MainMenuEnum.WrongChoice)} {MainMenuEnum.WrongChoice}");

        if (MainMenuEnum.WrongChoice == (MainMenuEnum)4)
        {
            Console.WriteLine("found 4");
        }
        Console.ReadKey();
    }//end of Start

}//end of class

