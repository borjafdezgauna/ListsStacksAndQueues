
using Common;
using System;
using System.Diagnostics;

namespace ListsStacksAndQueues
{
    public class IntTests
    {
        public static bool IntListTest(IList myList)
        {

            int[] initialValues = new int[5];
            initialValues[0] = 3;
            initialValues[1] = 6;
            initialValues[2] = 2;
            initialValues[3] = 9;
            initialValues[4] = -3;

            for (int i = 0; i < initialValues.Length; i++)
                myList.Add(initialValues[i]);

            Console.WriteLine();

            Console.WriteLine("1. Running tests");
            Console.Write("1.1. Testing Add/Count()...");
            if (myList.Count() != 5)
            {
                Console.WriteLine($"ERROR. Count returned {myList.Count()} instead of 5");
                return false;
            }
            Console.WriteLine($"PASSED.");

            Console.Write("1.2. Testing Get()...");
            for (int i = 0; i < initialValues.Length; i++)
            {
                if (myList.Get(i) != initialValues[i])
                {
                    Console.WriteLine($"ERROR. Get({i}) returned {myList.Get(i)} instead of {initialValues[i]}");
                    return false;
                }

            }
            Console.WriteLine($"PASSED.");

            Console.Write("1.3. Testing Remove()...");
            myList.Remove(4);
            if (myList.Count() != 4)
            {
                Console.WriteLine($"ERROR. Removing the last element didn't work");
                return false;
            }
            myList.Remove(0);
            if (myList.Count() != 3 || myList.Get(0) != initialValues[1])
            {
                Console.WriteLine($"ERROR. Removing the first element didn't work");
                return false;
            }



            Console.WriteLine($"PASSED");

            Console.Write("1.4. Testing Clear()...");
            myList.Clear();
            if (myList.Count() != 0)
            {
                Console.WriteLine($"ERROR. {myList.Count()} elements in the list after Clear() instead of 0");
                return false;
            }
            Console.WriteLine($"PASSED");

            int size = 10;
            int maxSize = 10000;
            Console.WriteLine($"\n2. Measuring speed");
            Stopwatch stopwatch = new Stopwatch();
            int numMaxDecimalDigits = 5;
            while (size <= maxSize)
            {
                //Add numbers from 0 to size
                Console.Write($"n={size} => ");
                stopwatch.Start();
                for (int i = 0; i < size; i++)
                    myList.Add(i);
                stopwatch.Stop();
                Console.Write($"{Utils.ToString(stopwatch.Elapsed.TotalSeconds, numMaxDecimalDigits)}s (Add) ");

                //Count
                stopwatch.Start();
                myList.Count();
                stopwatch.Stop();
                Console.Write($", {Utils.ToString(stopwatch.Elapsed.TotalSeconds, numMaxDecimalDigits)}s (Count)");

                //Add again n elements
                for (int i = 0; i < size; i++)
                    myList.Add(i);

                //Remove first element
                stopwatch.Start();
                for (int i = 0; i < size; i++)
                    myList.Remove(0);
                stopwatch.Stop();
                Console.Write($", {Utils.ToString(stopwatch.Elapsed.TotalSeconds, numMaxDecimalDigits)}s (Remove 1st)");

                //Add again n elements
                for (int i = 0; i < size; i++)
                    myList.Add(i);

                //Remove last element
                stopwatch.Start();
                for (int i = 0; i < size; i++)
                    myList.Remove(myList.Count() - 1);
                stopwatch.Stop();
                Console.WriteLine($", {Utils.ToString(stopwatch.Elapsed.TotalSeconds, numMaxDecimalDigits)}s (Remove last)");

                size *= 10;
            }
            return true;
        }

        public static bool GenericListTest(IGenericList<int> myList)
        {

            int[] initialValues = new int[5];
            initialValues[0] = 3;
            initialValues[1] = 6;
            initialValues[2] = 2;
            initialValues[3] = 9;
            initialValues[4] = -3;

            for (int i = 0; i < initialValues.Length; i++)
                myList.Add(initialValues[i]);

            Console.WriteLine();

            Console.WriteLine("1. Running tests");
            Console.Write("1.1. Testing Add/Count()...");
            if (myList.Count() != 5)
            {
                Console.WriteLine($"ERROR. Count returned {myList.Count()} instead of 5");
                return false;
            }
            Console.WriteLine($"PASSED.");

            Console.Write("1.2. Testing Get()...");
            for (int i = 0; i < initialValues.Length; i++)
            {
                if (myList.Get(i) != initialValues[i])
                {
                    Console.WriteLine($"ERROR. Get({i}) returned {myList.Get(i)} instead of {initialValues[i]}");
                    return false;
                }

            }
            Console.WriteLine($"PASSED.");

            Console.Write("1.3. Testing Remove()...");
            myList.Remove(4);
            if (myList.Count() != 4)
            {
                Console.WriteLine($"ERROR. Removing the last element didn't work");
                return false;
            }
            myList.Remove(0);
            if (myList.Count() != 3 || myList.Get(0) != initialValues[1])
            {
                Console.WriteLine($"ERROR. Removing the first element didn't work");
                return false;
            }



            Console.WriteLine($"PASSED");

            Console.Write("1.4. Testing Clear()...");
            myList.Clear();
            if (myList.Count() != 0)
            {
                Console.WriteLine($"ERROR. {myList.Count()} elements in the list after Clear() instead of 0");
                return false;
            }
            Console.WriteLine($"PASSED");

            int size = 10;
            int maxSize = 10000;
            Console.WriteLine($"\n2. Measuring speed");
            Stopwatch stopwatch = new Stopwatch();
            int numMaxDecimalDigits = 5;
            while (size <= maxSize)
            {
                //Add numbers from 0 to size
                Console.Write($"n={size} => ");
                stopwatch.Start();
                for (int i = 0; i < size; i++)
                    myList.Add(i);
                stopwatch.Stop();
                Console.Write($"{Utils.ToString(stopwatch.Elapsed.TotalSeconds, numMaxDecimalDigits)}s (Add) ");

                //Count
                stopwatch.Start();
                myList.Count();
                stopwatch.Stop();
                Console.Write($", {Utils.ToString(stopwatch.Elapsed.TotalSeconds, numMaxDecimalDigits)}s (Count)");

                //Add again n elements
                for (int i = 0; i < size; i++)
                    myList.Add(i);

                //Remove first element
                stopwatch.Start();
                for (int i = 0; i < size; i++)
                    myList.Remove(0);
                stopwatch.Stop();
                Console.Write($", {Utils.ToString(stopwatch.Elapsed.TotalSeconds, numMaxDecimalDigits)}s (Remove 1st)");

                //Add again n elements
                for (int i = 0; i < size; i++)
                    myList.Add(i);

                //Remove last element
                stopwatch.Start();
                for (int i = 0; i < size; i++)
                    myList.Remove(myList.Count() - 1);
                stopwatch.Stop();
                Console.WriteLine($", {Utils.ToString(stopwatch.Elapsed.TotalSeconds, numMaxDecimalDigits)}s (Remove last)");

                size *= 10;
            }
            return true;
        }

        public static bool ListEnumeratorTest(IList myList)
        {

            int[] initialValues = new int[5];
            initialValues[0] = 3;
            initialValues[1] = 6;
            initialValues[2] = 2;
            initialValues[3] = 9;
            initialValues[4] = -3;

            for (int i = 0; i < initialValues.Length; i++)
                myList.Add(initialValues[i]);

            foreach (int i in myList)
                Console.WriteLine(i);

            return true;
        }

        public static bool ListEnumeratorTest(IGenericList<int> myList)
        {
            for (int i = 0; i < 10; i++)
                myList.Add(i);

            foreach (int i in myList)
                Console.WriteLine(i);

            return true;
        }
    }
}