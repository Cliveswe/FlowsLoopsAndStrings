
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
            ValidateText();
            DisplayEveryThirdWord();
        }

        private void DisplayEveryThirdWord()
        {
            throw new NotImplementedException();
        }

        private bool ValidateText()
        {

            var testText = InputText.Split([' '], StringSplitOptions.RemoveEmptyEntries);
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
