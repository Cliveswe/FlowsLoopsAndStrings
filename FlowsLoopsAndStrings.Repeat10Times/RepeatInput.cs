

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

        private void ReadInputString()
        {
            bool done;

            do
            {

                Console.Write("Input your text: ");
                InputText = Console.ReadLine();
                done = string.IsNullOrEmpty(InputText);
                if (done)
                {

                    Utilities.ErrorTextColour();
                    Console.WriteLine("You need to input some text.");
                    Utilities.ResetTextColour();
                    InputText = string.Empty;
                }
            }
            while (done);

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
