using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MiaLukashyk_Lab02
{
    internal class Program
    {
        static void Task1()
        {
            double[] threePoints = new double[3];
            for(int i = 0; i < threePoints.Length; ++i)
            {
                Console.Write($"Enter {i + 1}th point: ");
                while (!double.TryParse(Console.ReadLine(), out threePoints[i]))
                {
                    Console.WriteLine("Try again");
                }
            }
            bool result = true;
            for (int i = 0; i < threePoints.Length && result; ++i)
            {
                result = Math.Abs(threePoints[i]) <= 5;
            }
            if(result)
            {
                Console.WriteLine("Points belong to [-5; 5]");
            }
            else
            {
                Console.WriteLine("Points don't belong to [-5; 5]");
            }
        }
        static void Task2()
        {
            double[] threeNumbers = new double[3];
            for (int i = 0; i < threeNumbers.Length; ++i)
            {
                Console.Write($"Enter {i + 1}th number: ");
                while (!double.TryParse(Console.ReadLine(), out threeNumbers[i]))
                {
                    Console.WriteLine("Try again");
                }
            }
            double max = threeNumbers[0];
            double min = threeNumbers[0];
            for (int i = 1; i < threeNumbers.Length; ++i)
            {
                if (threeNumbers[i] > max)
                {
                    max = threeNumbers[i];
                }
                else if (threeNumbers[i] < min)
                {
                    min = threeNumbers[i];
                }
            }
            Console.WriteLine($"min = {min}; max = {max}");
        }
        public enum HTTPError : int
        {
            BadRequest = 400,
            Unauthorized,
            PaymentRequired,
            Forbidden,
            NotFound
        }
        static void Task3()
        {
            Console.Write("Enter HTTP error code: ");
            HTTPError error;
            while(!HTTPError.TryParse(Console.ReadLine(), out error))
            {
                Console.WriteLine("Try again");
            }
            Console.WriteLine($"{error}");
        }
        public struct Dog
        {
            public string Name { get; set; }
            public string Mark { get; set; }
            private int age;
            public int Age 
            { 
                get
                {
                    return age;
                }
                set
                {
                    if(value < 0)
                    {
                        age = 0;
                        throw new Exception("Age of dog must be positive");
                    }
                    else
                    {
                        age = value;
                    }
                }
            }
            public override string ToString()
            {
                return $"{Name}, {Mark}, {Age} years old";
            }
        }
        static void Task4()
        {
            int age;
            Console.Write("Enter age: ");
            while(!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Enter valid age");
            }
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter mark: ");
            string mark = Console.ReadLine();
            try
            {
                Dog myDog = new Dog() { Age = age, Name = name, Mark = mark };
                Console.WriteLine(myDog);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            Task4();
            Console.ReadKey();
        }
    }
}
