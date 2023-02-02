namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, TA. Below are the two operators exercises.?");





            //Exercise 1




            int a = 17;

            int b = 4;


            Console.WriteLine(a + b);


            Console.WriteLine(a - b);


            Console.WriteLine(a * b);


            Console.WriteLine(a / b);


            Console.WriteLine(a % b);


            int quotient = a / b;


            int remainder = a % b;


            if (a == 17 && b == 4)



                Console.WriteLine("17/4 is 4 remainder 1");




            //Exercise 2




            Console.WriteLine($"What is the radius of your circle?");

            var radius = double.Parse(Console.ReadLine());

            var answer = AreaOfCircle(radius);

            Console.WriteLine($"The area of your circle with radius of {radius} is {answer}.");





        }

        public static double AreaOfCircle(double radius)
        {

            return(Math.PI * radius * radius);


            }
    }
}



