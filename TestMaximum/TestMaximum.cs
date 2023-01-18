using System.Collections.Generic;

namespace TestMaximum
{
    internal class TestCases
    {
        //Test cases for int values
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

        //Test cases for float values
        //test case 1: max value at first position
        public static void TestCase1Float()
        {
            float result = TestMaximum.Comparer(21.5f, 8.5f, 15.7f);
            Console.WriteLine("\nMaximum value is " + result);
        }
        //test case 2: max value at second position
        public static void TestCase2Float()
        {
            float result = TestMaximum.Comparer(2.6f, 15.4f, 1.5f);
            Console.WriteLine("\nMaximum value is " + result);
        }
        //test case 3: max value at third position
        public static void TestCase3Float()
        {
            float result = TestMaximum.Comparer(2.6f, 8.5f, 15.7f);
            Console.WriteLine("\nMaximum value is " + result);
        }

        //Test cases for String values
        //test case 1: max value at first position
        public static void TestCase1String()
        {
            String result = TestMaximum.Comparer("Peach", "Apple", "Banana");
            Console.WriteLine("\nMaximum value is " + result);
        }
        //test case 2: max value at second position
        public static void TestCase2String()
        {
            String result = TestMaximum.Comparer("Lion", "Zebra", "Cat");
            Console.WriteLine("\nMaximum value is " + result);
        }
        //test case 3: max value at third position
        public static void TestCase3String()
        {
            String result = TestMaximum.Comparer("Blue", "Red", "Xerox");
            Console.WriteLine("\nMaximum value is " + result);
        }
    }
    internal class TestMaximum
    {
        public static int Comparer(int first, int second , int third) // UC1 Comparing 3 integer values
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

        public static float Comparer(float first, float second , float third) // UC2 Comparing 3 float values
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

        public static string Comparer(string first, string second, string third) // UC3 Comparing 3 string values
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else
            {
                return third;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Maximum value of 3 values");

            TestCases.TestCase1Integer();
            TestCases.TestCase2Integer();
            TestCases.TestCase3Integer();

            TestCases.TestCase1Float();
            TestCases.TestCase2Float();
            TestCases.TestCase3Float();

            TestCases.TestCase1String();
            TestCases.TestCase2String();
            TestCases.TestCase3String();
        }
    }
}