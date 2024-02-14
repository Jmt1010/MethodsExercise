namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            var userName = Console.ReadLine();
            Console.WriteLine($"Hi, {userName}. What is your favortire color?");
            var color = Console.ReadLine();
            Console.WriteLine($"{color} is an awesome color! What is your favorite animal??");
            var animal = Console.ReadLine();
            Console.WriteLine("Great! Now, what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine("Thanks for the info! Compiling results now.");
            Console.WriteLine("-------------------------");

            Console.WriteLine($"Today we have learned {userName} is a big fan of the color {color}. {userName} loves seeing {animal} in the wild. Also, will never miss the chance to see {band} in concert.");

            Console.WriteLine("Thank you for participating in this excercise!");
        }
    }
}
