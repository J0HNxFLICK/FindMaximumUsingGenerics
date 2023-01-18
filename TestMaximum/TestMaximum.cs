using System.Collections.Generic;

namespace TestMaximum
{
    internal class TestCases
    {
        //Test cases for int values
        // test case 1 : max value at first position
        public static void TestCase1Integer()
        {
            TestMaximum<int>.Comparer(10, 5, 6);
        }

        //test case 2: max value at second position
        public static void TestCase2Integer()
        {
            TestMaximum<int>.Comparer(10, 15, 6);
        }

        //test case 3: max value at third position
        public static void TestCase3Integer()
        {
            TestMaximum<int>.Comparer(10, 5, 16);
        }

        //Test cases for float values
        //test case 1: max value at first position
        public static void TestCase1Float()
        {
            TestMaximum<float>.Comparer(21.5f, 8.5f, 15.7f);
        }
        //test case 2: max value at second position
        public static void TestCase2Float()
        {
            TestMaximum<float>.Comparer(2.6f, 15.4f, 1.5f);
        }
        //test case 3: max value at third position
        public static void TestCase3Float()
        {
            TestMaximum<float>.Comparer(2.6f, 8.5f, 15.7f);
        }

        //Test cases for String values
        //test case 1: max value at first position
        public static void TestCase1String()
        {
            TestMaximum<string>.Comparer("Peach", "Apple", "Banana");
        }
        //test case 2: max value at second position
        public static void TestCase2String()
        {
            TestMaximum<string>.Comparer("Lion", "Zebra", "Cat");
        }
        //test case 3: max value at third position
        public static void TestCase3String()
        {
            TestMaximum<string>.Comparer("Blue", "Red", "Xerox");
        }
    }
    internal class TestMaximum <T> //refactored as a generic class
    {
        //public static int Comparer(int first, int second , int third) // UC1 Comparing 3 integer values
        //{
        //    if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
        //    {
        //        return first;
        //    }
        //    else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
        //    {
        //        return second;
        //    }
        //    else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
        //    {
        //        return third;
        //    }
        //    else
        //    {
        //        Console.WriteLine("First,second and third are same");
        //        return 0;
        //    }
        //}

        //public static float Comparer(float first, float second , float third) // UC2 Comparing 3 float values
        //{
        //    if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
        //    {
        //        return first;
        //    }
        //    else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
        //    {
        //        return second;
        //    }
        //    else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
        //    {
        //        return third;
        //    }
        //    else
        //    {
        //        Console.WriteLine("First,second and third are same");
        //        return 0;
        //    }
        //}

        //public static string Comparer(string first, string second, string third) // UC3 Comparing 3 string values
        //{
        //    if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
        //    {
        //        return first;
        //    }
        //    else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
        //    {
        //        return second;
        //    }
        //    else
        //    {
        //        return third;
        //    }
        //}

        public static void Comparer(T first, T second, T third) //Refactored as a generic method
        {
            dynamic d1 = first;
            dynamic d2 = second;
            dynamic d3 = third;
            if (d1.CompareTo(d2) > 0 && d1.CompareTo(d3) > 0)
            {
                Console.WriteLine("Max value is : " + first);
            }
            else if (d2.CompareTo(d1) > 0 && d2.CompareTo(d3) > 0)
            {
                Console.WriteLine("Max value is : " + second);
            }
            else
            {
                Console.WriteLine("Max value is : " + third);
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