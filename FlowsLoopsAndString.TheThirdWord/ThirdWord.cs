
using FlowsLoopsAndStrings.Helpers;

namespace FlowsLoopsAndString.TheThirdWord
{
    public class ThirdWord
    {
        private readonly int minimumNumberOfWords = 3;

        private string inputText;
        public string InputText
        {
            get { return inputText; }
            private set { inputText = value; }
        }

        private string[] outputText;
        public string[] OutputText
        {
            get { return outputText; }
            private set { outputText = value; }
        }

        public ThirdWord()
        {
            InputText = "";
            OutputText = [];
        }

        public void TheThirdWord()
        {

            DisplayInformationToTheUser();
            ReadUserInput();
            DisplayResults();
        }

        private void DisplayResults()
        {
            if (SplitAndValidateText(out string[] testTextResult) &&
                (testTextResult.Length >= minimumNumberOfWords))
            {
                DisplayEveryThirdWord(testTextResult);
            }
            else
            {
                Console.WriteLine("Nothing to display!");
            }
            Utilities.NewLine();
        }


        private void DisplayEveryThirdWord(string[] testTextResult)
        {
            for (int index = 0; index < testTextResult.Length; index++)
            {

                if ((index + 1) % minimumNumberOfWords == 0)
                {

                    if (!testTextResult[index].Any(Char.IsDigit))
                    {

                        Console.WriteLine($"{testTextResult[index]}");
                    }
                    else
                    {

                        //found a word that is contaminated
                        Utilities.ErrorTextColour();
                        Console.WriteLine($"{testTextResult[index]} is technically not a word!");
                        Utilities.ResetTextColour();
                    }
                }
            }
        }

        private bool SplitAndValidateText(out string[] testText)
        {

            testText = InputText.Split([' '], StringSplitOptions.RemoveEmptyEntries);
            //bool integer = testText[0].Any(Char.IsDigit);

            if (testText.Length >= minimumNumberOfWords)
            {
                OutputText = testText;
                return true;
            }

            return false;
        }

        private void ReadUserInput()
        {

            InputText = Utilities.ReadInputString();
        }

        private void DisplayInformationToTheUser()
        {
            Utilities.ClearScreen();
            Console.WriteLine($"************** The Third Word *****************");
            Console.WriteLine($"* Input a sentence with a minimum of {minimumNumberOfWords} words. *");
            Console.WriteLine($"* I will display every {minimumNumberOfWords}rd word.              *");
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
