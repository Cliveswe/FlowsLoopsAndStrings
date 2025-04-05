
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
        public ThirdWord()
        {

        }

        public void TheThirdWord()
        {
            DisplayInformationToTheUser();

        }

        private void DisplayInformationToTheUser()
        {
            Console.WriteLine($"*********************************");
            Console.WriteLine($"* Input a sentence with a minimum of {minimumNumberOfWords} words.");
            Console.WriteLine($"* I will display every {minimumNumberOfWords}rd word.");
            Console.WriteLine("----------------------------------");
        }
    }
}
