using System;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //     Console.WriteLine("What is your SuperheroName?");
            //      string superName = Console.ReadLine();

            //      Console.WriteLine("What is your favorite color Batman?");
            //      string favoriteColor = Console.ReadLine();

            //      Console.WriteLine("What is favorite Animal?");
            //      string favAnimal = Console.ReadLine();

            //      Console.WriteLine("What is your favorite Band?");
            //      string favBand = Console.ReadLine();

            //      Console.WriteLine($"There once was a Superhero named {superName}, Thier favorite color was {favoriteColor}, They loved their {favAnimal}, and they enjoyed listening to {favBand}"); 

            //Console.WriteLine("Give me a number to add");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Give me a number to add to the first one");
            //int num2 = int.Parse(Console.ReadLine());

            //int sum = Sum(num1, num2);
            //Console.WriteLine($"The sum is:{sum}");

            //Console.WriteLine("Provide me with a number you would like to multiply");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Provide me with a second number to multiply by the first number that you entered");
            //int b = int.Parse(Console.ReadLine());

            //int sum2 = Multiply(a, b);
            //Console.WriteLine($"The sum is: {sum2}");


            //Console.WriteLine("What number would you like to divide?");
            // int x = int.Parse(Console.ReadLine());

            //Console.WriteLine("What is the second number that you would like to divide the first number by?");
            //int z = int.Parse(Console.ReadLine());

            //int produce = Divide(x, z);
            //Console.WriteLine($"The sum of both numbers is:{produce}");

            Console.WriteLine("Give me a number that you want to subtract?");
                int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a second muber please?");
            int num4 = int.Parse(Console.ReadLine());

            int product = Subtract(num3, num4);
            Console.WriteLine($"The answer is: {product}");



        }


        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
            
        }


        public static int Multiply(int a, int b)
        {
            return a * b;
        }



        public static int Divide(int x, int z)
        {
            return x / z;
        }

        public static int Subtract(int num3, int num4)
        {
            return num3 - num4;
        }

        public static int Sum(params int[] Basketballs)
        {
            int sum = 0;
            for (int i = 0; i < Basketballs.Length; i++)
            {
                sum = sum + Basketballs[i];
            }
            return sum;
        }


    }




}
