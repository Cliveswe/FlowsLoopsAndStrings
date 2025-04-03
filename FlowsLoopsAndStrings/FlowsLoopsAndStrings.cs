using FlowsLoopsAndStrings.Helpers;


namespace FlowsLoopsAndStrings;

public class FlowsLoopsAndStrings
{
    public FlowsLoopsAndStrings()
    {

    }

    public void Start()
    {

        if ((int)MainMenuEnum.Exit == 0)
        {
            Console.WriteLine("found 0");
        }
        Console.ReadKey();
    }//end of Start

}//end of class

