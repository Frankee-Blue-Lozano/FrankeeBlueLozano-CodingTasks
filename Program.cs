using System;

namespace FrankeeBlueLozano_CodingTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge 1: " + Sum(1, 5));
            Console.WriteLine("Challenge 2: " + Convert(5));
            Console.WriteLine("Challenge 3: " + PlusOne(3));
            Console.WriteLine("Challenge 4: " + CircutPower(230, 10));
            Console.WriteLine("Challenge 5: " + CalcAge(65, 365));
            Console.WriteLine("Challenge 6: " + lessThanOrEqualToZero(5, 0));
            Console.WriteLine("Challenge 7: " + triArea(3, 2));
            Console.WriteLine("Challenge 8: " + lessThen100(22, 15));
            Console.WriteLine("Challenge 9.1: " + IsEqual(5, 6));
            Console.WriteLine("Challenge 9.2: " + IsEqual(1, 1));
            Console.WriteLine("Challenge 10: " + GiveMeSomething(" is better than nothing"));
            Console.WriteLine("Challenge 10.1: " + GiveMeSomething(" Bob Jane"));
            Console.WriteLine("Challenge 10.2: " + GiveMeSomething(" something"));
            Console.WriteLine("Challenge 11: " + Reverse(true));
            Console.WriteLine("Challenge 11.1: " + Reverse(false));
            Console.WriteLine("Challenge 12: " + howManySeconds(2));
            Console.WriteLine("Challenge 13: " + SumPolygon(3));
            Console.WriteLine("Challenge 13.1: " + SumPolygon(4));
            Console.WriteLine("Challenge 13.2: " + SumPolygon(6));
            Console.WriteLine("Challenge 14: " + nameString("Mubashir"));
            Console.WriteLine("Challenge 14.1: " + nameString("Edabit"));
            Console.WriteLine("Challenge 14.2: " + nameString("C#"));
            Console.WriteLine("Challenge 15: " + And(true, false));
            Console.WriteLine("Challenge 15.1: " + And(true, true));
            Console.WriteLine("Challenge 15.2: " + And(false, true));
            Console.WriteLine("Challenge 15.3: " + And(false, false));
            Console.WriteLine("Challenge 16: " + points(1, 1));
            Console.WriteLine("Challenge 16.1: " + points(7, 5));
            Console.WriteLine("Challenge 17: " + FindPerimeter(6, 7));
            Console.WriteLine("Challenge 17.1: " + FindPerimeter(20, 10));
            Console.WriteLine("Challenge 18: " + HelloName("Gerald"));
            Console.WriteLine("Challenge 18.1: " + HelloName("Tiffany"));
            Console.WriteLine("Challenge 19: " + FarmAnimals(2, 3, 5));
            Console.WriteLine("Challenge 19.1: " + FarmAnimals(1, 2, 3));
            Console.WriteLine("Challenge 20: " + FootballPoints(3, 4, 2));
            Console.WriteLine("Challenge 20.1: " + FootballPoints(5, 0, 2));
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
        
        public static bool And(bool a, bool b)
        {
            if (a && b)
                return true;
            else
                return false;
        }

        public static int points(int two, int three)
        {
            return (two * 2) + (three * 3);
        }

        public static int FindPerimeter(int L, int W)
        {
            return (L * 2) + (W * 2);
        }

        public static string HelloName(string a)
        {
            return "Hello " + a + "!";
        }

        public static int FarmAnimals(int chicks, int cow, int pig)
        {
            return (pig * 4) + (cow * 4) + (chicks * 2);
        }

        public static int FootballPoints(int wins, int draws, int losses)
        {
            return (wins * 3) + (draws * 1) + (losses * 0); 
        }
    }
}
