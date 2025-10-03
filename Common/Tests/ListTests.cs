
using System;
using System.Diagnostics;

namespace Lists
{
    public class ListTests
    {
        public static bool IntListTest(IIntList myList)
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
            if (myList.Count() != 4 && myList.Get(3) == initialValues[3])
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
            myList.Remove(0);
            if (myList.Count() != 2 || myList.Get(0) != initialValues[2])
            {
                Console.WriteLine($"ERROR. Removing the first element TWICE didn't work");
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

        public static bool ListTest(IList<int> myList)
        {

            int[] initialValues = new int[5];
            initialValues[0] = 3;
            initialValues[1] = 6;
            initialValues[2] = 2;
            initialValues[3] = 9;
            initialValues[4] = -3;

            Console.WriteLine();

            Console.WriteLine("1. Running tests");
            Console.Write("1.1. Testing Add/Count()...");

            for (int i = 0; i < initialValues.Length; i++)
                myList.Add(initialValues[i]);

            
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
            myList.Remove(0);
            if (myList.Count() != 2 || myList.Get(0) != initialValues[2])
            {
                Console.WriteLine($"ERROR. Removing the first element TWICE didn't work");
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

            Console.Write("1.4. Testing Add/Get/Remove()...");
            myList.Clear();
            myList.Add(initialValues[0]);
            if (myList.Count() != 1)
            {
                Console.WriteLine($"ERROR. {myList.Count()} elements in the list after Add() instead of 1");
                return false;
            }
            if (myList.Get(0) != initialValues[0])
            {
                Console.WriteLine($"ERROR. Get(0) failed after adding one element");
                return false;
            }
            myList.Add(initialValues[1]);
            if (myList.Count() != 2)
            {
                Console.WriteLine($"ERROR. {myList.Count()} elements in the list after second Add() instead of 2");
                return false;
            }
            if (myList.Get(0) != initialValues[0])
            {
                Console.WriteLine($"ERROR. Get(0) failed after adding two elements");
                return false;
            }
            if (myList.Get(1) != initialValues[1])
            {
                Console.WriteLine($"ERROR. Get(1) failed after adding two elements");
                return false;
            }
            myList.Remove(0);
            if (myList.Count() != 1)
            {
                Console.WriteLine($"ERROR. {myList.Count()} elements in the list after adding two elements and removing one");
                return false;
            }
            if (myList.Get(0) != initialValues[1])
            {
                Console.WriteLine($"ERROR. Get(0) failed after adding two elements and removing the first");
                return false;
            }
            myList.Add(initialValues[2]);
            if (myList.Count() != 2)
            {
                Console.WriteLine($"ERROR. {myList.Count()} elements in the list after adding two elements, removing one, and adding a third");
                return false;
            }
            if (myList.Get(0) != initialValues[1])
            {
                Console.WriteLine($"ERROR. Get(0) failed after adding two elements and removing one");
                return false;
            }
            if (myList.Get(1) != initialValues[2])
            {
                Console.WriteLine($"ERROR. Get(1) failed after adding two elements and removing one");
                return false;
            }
            Console.WriteLine($"PASSED");

            
            return true;
        }


        public static bool ListEnumeratorTest(IIntList myList)
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

        public static bool ListEnumeratorTest(IList<int> myList)
        {
            for (int i = 0; i < 10; i++)
                myList.Add(i);

            foreach (int i in myList)
                Console.WriteLine(i);

            return true;
        }

        const int NumSamples = 100000;
        public static bool MeasurePerformance<T>(IList<T> list, T[] initialValues)
        {
            int numDigits = 3;
            int timeoutSecs = 1;
            Console.WriteLine($"\n# Measuring performance (n={NumSamples})");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Reset();
            stopwatch.Start();
            System.Threading.Tasks.Task timeoutTask = System.Threading.Tasks.Task.Delay(timeoutSecs * 1000);
            System.Threading.Tasks.Task<bool> testTask = System.Threading.Tasks.Task.Factory.StartNew(
                () =>
                {
                    try
                    {
                        //Add
                        for (int i = 0; i < NumSamples; i++)
                            list.Add(initialValues[i % initialValues.Length]);
                        if (list.Count() != NumSamples)
                            return false;
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                });

            var winner = System.Threading.Tasks.Task.WhenAny(testTask, timeoutTask).Result;
            if (testTask.IsCompleted && testTask.Result == true)
            {
                Console.WriteLine($"'Add' Ok. (n={NumSamples}) -> {Utils.ToString(stopwatch.Elapsed.TotalSeconds, numDigits)}");
            }
            else if (testTask.IsCompleted)
            {
                Console.WriteLine($"Error. 'Add' failed");
                return false;
            }
            else
            {
                Console.WriteLine($"Error. 'Add' timed out (> {timeoutSecs}s)");
                return false;
            }

            //Remove first/last
            stopwatch.Reset();
            stopwatch.Start();
            timeoutTask = System.Threading.Tasks.Task.Delay(timeoutSecs * 1000);
            testTask = System.Threading.Tasks.Task.Factory.StartNew(
                () =>
                {
                    if (list.Count() != NumSamples)
                        return false;
                    for (int i = 0; i < NumSamples; i++)
                    {
                        if (i % 2 == 0)
                            list.Remove(0);
                        else
                            list.Remove(list.Count() - 1);
                    }
                    if (list.Count() != 0)
                        return false;
                    return true;
                });
            winner = System.Threading.Tasks.Task.WhenAny(testTask, timeoutTask).Result;
            double t = stopwatch.Elapsed.TotalSeconds;
            if (testTask.IsCompleted && testTask.Result == true)
            {
                Console.WriteLine($"'Remove' Ok. (n={NumSamples}) -> {Utils.ToString(stopwatch.Elapsed.TotalSeconds, numDigits)} s");
                return true;
            }
            else if (testTask.IsCompleted)
            {
                Console.WriteLine($"Error. 'Remove' failed");
                return false;
            }
            else
            {
                Console.WriteLine($"Error. 'Remove' timed out (> {timeoutSecs}s)");
                return false;
            }

        }
    }
}