using System.Security.Claims;

namespace MethodsExercise
{
    public class Program
    {
        public static int Multiply(int num1, int num2, int num3) 
        {
            return num1 * num2 * num3;
        }
        public static int Sum(int num1, int num2) 
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            var wins = Sum(14, 28);
            var points = Multiply(3, 1, wins);



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

            Console.WriteLine($"Today we have learned {userName} is a big fan of the color {color}. {userName} enjoys seeing a {animal} at the zoo. Also, {userName} will never miss the chance to see {band} in concert.");

            Console.WriteLine("-------------------------");
            
            Console.WriteLine($"Thank you for participating in this excercise {userName}!");
        }
    }
}
