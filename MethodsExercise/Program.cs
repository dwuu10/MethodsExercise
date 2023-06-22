namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            int answer = num1 + num2;
            
            return answer;
        }
        public static int Product(int num1, int num2)
        {
            int answer = num1* num2;

            return answer;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Product(1, 2));
            

            Console.WriteLine("Name");
            string name = Console.ReadLine();
            Console.WriteLine("favorite Food");
            string food = Console.ReadLine();
            Console.WriteLine("Flavor");
            string flavor = Console.ReadLine();

            Console.WriteLine($"One day, {name} decided to go out on a walk, they saw a stand selling {food} on the side of the road, {name} purchased some, the {food} was {flavor}!");
        }
    }
}
