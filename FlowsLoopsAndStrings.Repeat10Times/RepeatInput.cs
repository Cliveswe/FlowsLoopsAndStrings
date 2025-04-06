

using FlowsLoopsAndStrings.Helpers;

namespace FlowsLoopsAndStrings.Repeat10Times
{
    public class RepeatInput
    {
        private int repeatNumber;

        public int RepeatNumber
        {
            get { return repeatNumber; }
            private set { repeatNumber = value; }
        }

        private string inputText;
        public string InputText
        {
            get { return inputText; }
            private set { inputText = value; }
        }
        public RepeatInput()
        {
            RepeatNumber = 10;
            InputText = "";
        }

        public void RepeatInputedText()
        {
            DisplayInfomationToUser();
            ReadInputString();
            RepeatTextToUser();
            Utilities.NewLine();
            Utilities.NewLine();
        }

        /// <summary>
        /// Get the users text input.
        /// </summary>
        private void ReadInputString()
        {
            InputText = Utilities.ReadInputString();
        }

        private void RepeatTextToUser()
        {
            for (int index = 0; index < repeatNumber; index++)
            {
                if (index < repeatNumber - 1)
                {
                    Console.Write($"{index + 1}. {InputText}, ");
                }
                else
                {
                    Console.Write($"{index + 1}. {InputText}");
                }
            }

        }



        private void DisplayInfomationToUser()
        {
            Utilities.ClearScreen();
            Console.WriteLine($"********** Repeat text {RepeatNumber} times ***********");
            Console.WriteLine("* Input an arbitrary text of your choice. *");
            Console.WriteLine($"* Then I will repeat the text {RepeatNumber} times.   *");
            Console.WriteLine("-------------------------------------------");
            Utilities.NewLine();
        }
    }
}
