namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch(subject.ToLower()) 
            {
                case "math":
                    Console.WriteLine("I hate math!");
                    break;
                case "Science":
                    Console.WriteLine("I love science!");
                    break;
                case "pe":
                    Console.WriteLine("PE is the best!");
                    break;
                case "History":
                    Console.WriteLine("History is awesome!");
                    break;
                case "English":
                    Console.WriteLine("English is boring.");
                    break;
                default:
                    Console.WriteLine("I don't know that subject.");
                    break; 

            }
        }
    }
}