namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What's your favorite subject in school?");

            string userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "math":
                    Console.WriteLine($"You must be pretty smart!");
                    break;
                case "science":
                    Console.WriteLine($"Science is really interesting!");
                    break;
                case "english":
                    Console.WriteLine($"CooL! Definitely my worst subject in school!");
                    break;
                case "history":
                    Console.WriteLine($"I hated history!");
                    break;
                case "music":
                    Console.WriteLine($"My favorite! Do you play any instruments?");
                    break;

                default:
                    Console.WriteLine($"Nice! I've never taken that before.");
                    break;






            }
        }
    }
}