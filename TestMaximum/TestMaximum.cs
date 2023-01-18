using System.Collections.Generic;

namespace TestMaximum
{
    internal class TestCases
    {
        // test case 1 : max value at first position
        public static void TestCase1Integer()
        {
            int result = TestMaximum.Comparer(10, 5, 6);
            Console.WriteLine("\nMaximum value is " + result);
        }

        //test case 2: max value at second position
        public static void TestCase2Integer()
        {
            int result = TestMaximum.Comparer(10, 15, 6);
            Console.WriteLine("\nMaximum value is " + result);
        }

        //test case 3: max value at third position
        public static void TestCase3Integer()
        {
            int result = TestMaximum.Comparer(10, 5, 16);
            Console.WriteLine("\nMaximum value is " + result);
        }
    }
    internal class TestMaximum
    {
        public static int Comparer(int first, int second , int third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            else
            {
                Console.WriteLine("First,second and third are same");
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum value of 3 values");

            TestCases.TestCase1Integer();
            TestCases.TestCase2Integer();
            TestCases.TestCase3Integer();
        }
    }
}