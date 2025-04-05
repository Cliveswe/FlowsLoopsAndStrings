// Ignore Spelling: Colour

using System.ComponentModel;
using System.Reflection;

namespace FlowsLoopsAndStrings.Helpers;
public static class Utilities
{
    /// <summary>
    /// Get the decryption from a Enum class. 
    /// </summary>
    /// <param name="value">An enum member.</param>
    /// <returns>The enum decryption as a string.</returns>
    public static bool GetEnumDecryption(Enum value, out string decryptionAsString)
    {

        Type Type = value.GetType();
        FieldInfo field = Type.GetField(value.ToString());
        string name = value.ToString();

        if ((field != null) && (name != null))
        {

            decryptionAsString = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is not DescriptionAttribute attribute ? name : attribute.Description;
            return true;
        }
        else
        {

            decryptionAsString = name;
        }

        return false;

    }//end of GetEnumDecryption

    public static string ReadInputString()
    {
        bool done;
        string inputText;

        do
        {

            Console.Write("Input your text: ");
            inputText = Console.ReadLine();
            done = string.IsNullOrEmpty(inputText);
            if (done)
            {

                Utilities.ErrorTextColour();
                Console.WriteLine("You need to input some text.");
                Utilities.ResetTextColour();
                inputText = string.Empty;
            }
        }
        while (done);

        return inputText;
    }

    /// <summary>
    /// Get the user menu choice. If the user choice is number then return the choice 
    /// </summary>
    /// <param name="prompt">Select a message from a Enum.</param>
    /// <returns>The user choice as a number int otherwise -1 for an incorrect choice.</returns>
    public static int ReadUserChoice(Enum prompt)
    {

        Utilities.GetEnumDecryption(prompt, out string promptMessage);

        Console.Write($"{promptMessage}: ");

        if (!int.TryParse(Console.ReadLine(), out int userChoice))
        {
            InputErrorDisplayMessage();
            userChoice = -1;
        }

        return userChoice;
    }//end of ReadUserChoice


    /// <summary>
    /// Inform the user that they inputed an incorrect choice.
    /// </summary>
    public static void InputErrorDisplayMessage()
    {

        //save a copy of the current console foreground colour to be restored at 
        //the end of this method
        ConsoleColor currentConsoleColour = Console.ForegroundColor;

        ErrorTextColour();
        GetEnumDecryption(MainMenuEnum.WrongChoice, out string message);
        Console.WriteLine($"{Environment.NewLine}{message}");

        Console.ForegroundColor = currentConsoleColour;
    }//end of InputErrorDisplayMessage

    /// <summary>
    /// Format and display a menu choice.
    /// </summary>
    /// <param name="MenuNumber">The key menu choice as an int.</param>
    /// <param name="MenuDescription">Text Description of the menu choice as String</param>
    public static void DisplayChoice(int MenuNumber, string MenuDescription) => Console.WriteLine($"{MenuNumber} {MenuDescription}");

    public static void CinemaTextColour() => Console.ForegroundColor = ConsoleColor.Green;
    public static void ErrorTextColour() => Console.ForegroundColor = ConsoleColor.Cyan;
    public static void ResetTextColour() => Console.ResetColor();

    public static void ClearScreen() => Console.Clear();

    public static void NewLine() => Console.WriteLine();

}//end of class

