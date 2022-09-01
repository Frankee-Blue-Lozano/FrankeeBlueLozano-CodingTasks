using System;

namespace FrankeeBlueLozano_CodingTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge 1:" + Sum(1, 5));
            Console.WriteLine("Challenge 2:" + Convert(5));
            Console.WriteLine("Challenge 3:" + PlusOne(3));
            Console.WriteLine("Challenge 4:" + CircutPower(230, 10));
            Console.WriteLine("Challenge 5:" + CalcAge(65, 365));
            Console.WriteLine("Challenge 6:" + lessThanOrEqualToZero(5, 0));
            Console.WriteLine("Challenge 7:" + triArea(3, 2));
            Console.WriteLine("Challenge 8:" + lessThen100(22, 15));
            Console.WriteLine("Challenge 9.1:" + IsEqual(5, 6));
            Console.WriteLine("Challenge 9.2:" + IsEqual(1, 1));
            Console.WriteLine("Challenge 10:" + GiveMeSomething(" is better than nothing"));
            Console.WriteLine("Challenge 10.1:" + GiveMeSomething(" Bob Jane"));
            Console.WriteLine("Challenge 10.2:" + GiveMeSomething(" something"));
            Console.WriteLine("Challenge 11:" + Reverse(true));
            Console.WriteLine("Challenge 11.1:" + Reverse(false));
            Console.WriteLine("Challenge 12:" + howManySeconds(2));
            Console.WriteLine("Challenge 13:" + SumPolygon(3));
            Console.WriteLine("Challenge 13.1:" + SumPolygon(4));
            Console.WriteLine("Challenge 13.2:" + SumPolygon(6));
            Console.WriteLine("Challenge 14:" + nameString("Mubashir"));
            Console.WriteLine("Challenge 14.1:" + nameString("Edabit"));
            Console.WriteLine("Challenge 14.2:" + nameString("C#"));


        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Convert(int minutes)
        {
            return minutes * 60;
        }

        public static int PlusOne(int a)
        {
            return a + 1;
        }

        public static int CircutPower(int voltage, int current)
        {
            return voltage * current;
        }

        public static int CalcAge(int age, int days)
        {
            return age * days;
        }

        public static int triArea(int Base, int height)
        {
            return Base * height / 2;
        }

        public static bool lessThanOrEqualToZero(int number, int zero)
        {
            if (number <= zero)
            return true;
            else return false;
        }

        public static bool lessThen100(int a, int b)
        {
            if (a + b < 100)
                return true;
            else return false;
        }

        public static bool IsEqual(int c, int b)
        {
            if (c == b)
                return true;
            else return false;
        }

        public static string GiveMeSomething(string a)
        {
            return " something" + a;
        }

        public static bool Reverse(bool a)
        {
            if (a == true)
                return false;
            else
                return true;
        }

        public static int howManySeconds(int hours)
        {
            return hours * 60 * 60;
        }

        public static int SumPolygon(int n)
        {
            return (n - 2) * 180;
        }

        public static string nameString(string a)
        {
            return a + "Edabit";
        }
    }
}
