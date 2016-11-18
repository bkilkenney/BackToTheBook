using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToTheBook
{
    class Program
    {
        static void Main(string[] args)
        {

            //int numberThatCausesProblems = 54;
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);

            //    if (i == numberThatCausesProblems)
            //    {
            //        break;
            //    }
            //}
            //while (true)
            //{
            //    Console.Write("What is thy bidding, master?");
            //    string input = Console.ReadLine();

            //    if (input == "quit" || input == "exit")
            //        break;
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 3 ==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //for (int i = 0; i < 5; i++)
            //{
            //    for (int column = 0; column < 10; column++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}




            //for (int row = 0; row < 10; row++)
            //{
            //    for (int column = 0; column < row; column++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine("I'm about to go into a method...");

            //DoSomethingAwesome();

            //Console.WriteLine("Now I'm back from the DoSomethingAwesome() method");

            //Console.WriteLine(GetRandomNumber());


            //Call GetNumFromUser:
            //Console.WriteLine("The user picked: " + GetNumFromUser());
            //Console.ReadLine();


            //Console.WriteLine("The players score is: " + CalculatePlayerScore());
            //Console.ReadLine();


            //Count(25);
            //Console.ReadLine();

            //Count(6);
            //Console.ReadLine();


            //Console.WriteLine(Multiply(4, 6));
            //Console.ReadLine();

            Multiply(3, 9);

            Console.WriteLine(Multiply(4, 2, 9, 3));
            Console.ReadLine();


            int[] numbers = GenerateNumbers();

            Print(numbers);
            Console.ReadLine();

            Reverse(numbers);
            Console.ReadLine();

            int num = int.Parse("58");
            Console.WriteLine(num + 3);

            int num2 = Convert.ToInt32(4.324);      //Rounds down
            Console.WriteLine(num2);


            Console.WriteLine(Factorial(9));
            Console.ReadLine();



            Console.WriteLine("Select a number: ");
            int fib = int.Parse(Console.ReadLine());
            for (int i = 0; i < fib; i++)
            {
                Console.WriteLine("The Fibonacci sequence is: " + Fibonacci(i));
            }

        }

        public static int[] GenerateNumbers()
        {
            int[] ints = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            return ints;
        }


        public static void Print(int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        public static void Reverse(int[] numbers)
        {
            var r = numbers.Reverse();
            foreach (var item in r)
            {
                Console.WriteLine(item);
            }            
        }




        //static Array GenerateNumbers(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j)
        //{
        //    int[] returnedArray = { a, b, c, d, e, f, g, h, i, j };
        //    return returnedArray;
        //}

        //static void Print()
        //{
           
        //}

        

        //static void DoSomethingAwesome()
        //{
        //    Console.WriteLine("I'm inside of a method");
        //}

        //static float GetRandomNumber()
        //{
        //    return 4.2324f;
        //}

        static int GetNumFromUser()
        {
            int usersNum = 0;

            while (usersNum < 1 || usersNum > 10)
            {
                Console.WriteLine("Enter a number between 1 and 10: ");
                string usersResponse = Console.ReadLine();
                usersNum = int.Parse(usersResponse);
            }
            return usersNum;
        }

        static int CalculatePlayerScore()
        {
            int livesLeft = 3;
            int underlingsDestroyed = 17;
            int minionsDetroyed = 4;
            int bossesDestroyed = 1;

            //if a player is out of lives they lose all their points
            if (livesLeft == 0)
            {
                return 0;
            }
            else
            {
                return underlingsDestroyed * 10 +
                        minionsDetroyed * 100 +
                        bossesDestroyed * 1000;
            }

        }

        static void Count(int numToCountTo)
        {
            for (int i = 0; i <= numToCountTo; i++)
            {
                Console.WriteLine(i);
            }
        }


        /// <summary>
        /// Method multiplies 2 nums and returns the results
        /// </summary>
        /// <param name="a">First num to be multiplied</param>
        /// <param name="b">2nd num to be multiplied</param>
        /// <returns>Product of a * b</returns>
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Method that takes 3 nums and multiplies them, returning the result
        /// </summary>
        /// <param name="a">1st num to multiply</param>
        /// <param name="b">2nd num to multiply</param>
        /// <param name="c">3rd num to multiply</param>
        /// <returns>The product of 3 input numbers</returns>
        static int Multiply(int a, int b, int c, int d)
        {
            return a * b * c * d;
        }


        static int Factorial(int number)
        {
            //Next line is the "Base Case"
            if (number == 1)
                return 1;

            return number * Factorial(number - 1);
        }

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }



    }
}
