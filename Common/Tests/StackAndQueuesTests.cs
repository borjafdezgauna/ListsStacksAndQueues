using System;
using System.Diagnostics;

namespace Lists
{
    public class StackAndQueuesTests
    {
        const int NumSamples = 100000;

        public static bool Test<T>(IPushPop<T> pushPop, T[] initialValues, bool isQueue = false)
        {
            Console.WriteLine("# Running tests");
            Console.Write("Testing Push()/Count()...");
            for (int i = 0; i < initialValues.Length; i++)
            {
                pushPop.Push(initialValues[i]);

                if (pushPop.Count() != i + 1)
                {
                    Console.WriteLine($"ERROR. Count() returned {pushPop.Count()} instead of {i + 1}");
                    return false;
                }
            }
            Console.WriteLine($"OK.");

            Console.Write("Testing Clear()...");
            pushPop.Clear();
            if (pushPop.Count() != 0)
            {
                Console.WriteLine($"ERROR. Count returned {pushPop.Count()} instead of 0 after Clear()");
                return false;
            }
            Console.WriteLine($"OK.");

            Console.Write("Testing Push()/Pop()...");
            for (int i = 0; i < initialValues.Length; i++)
                pushPop.Push(initialValues[i]);

            for (int i = 0; i < initialValues.Length; i++)
            {
                T value = pushPop.Pop();

                if (!isQueue && !value.Equals(initialValues[initialValues.Length - i - 1])
                || isQueue && !value.Equals(initialValues[i])
                )
                {
                    Console.WriteLine($"ERROR. Pop() returned {value} instead of {initialValues[initialValues.Length - i - 1]}");
                    return false;
                }
            }
            Console.WriteLine($"OK.");
            return true;
        }
        public static bool MeasurePerformance<T>(IPushPop<T> pushPop, T[] initialValues)
        {
            int numDigits = 3;
            int timeoutSecs = 1;
            Console.WriteLine($"\n# Measuring performance (n={NumSamples})");

            Stopwatch stopwatch = Stopwatch.StartNew();
            System.Threading.Tasks.Task timeoutTask = System.Threading.Tasks.Task.Delay(timeoutSecs * 1000);
            System.Threading.Tasks.Task<bool> testTask = System.Threading.Tasks.Task.Factory.StartNew(
                () =>
                {
                    try
                    {
                        //Push
                        for (int i = 0; i < NumSamples; i++)
                            pushPop.Push(initialValues[i % initialValues.Length]);
                        if (pushPop.Count() != NumSamples)
                            return false;
                    }
                    catch
                    {
                        return false;
                    }
                    return true;
                });

            var winner = System.Threading.Tasks.Task.WhenAny(testTask, timeoutTask).Result;
            if (testTask.IsCompleted && testTask.Result)
            {
                Console.WriteLine($"'Push' Ok. (n={NumSamples}) -> {Utils.ToString(stopwatch.Elapsed.TotalSeconds, numDigits)}");
            }
            else if (testTask.IsCompleted)
            {
                Console.WriteLine($"Error. 'Push' failed");
                return false;
            }
            else if (testTask.IsCompleted)
            {
                Console.WriteLine($"Error. 'Push' timed out (> {timeoutSecs}s)");
                return false;
            }
            //Remove first element
            stopwatch = Stopwatch.StartNew();
            timeoutTask = System.Threading.Tasks.Task.Delay(timeoutSecs * 1000);
            testTask = System.Threading.Tasks.Task.Factory.StartNew(
                () =>
                {
                    try
                    {
                        if (pushPop.Count() != NumSamples)
                            return false;
                        for (int i = 0; i < NumSamples; i++)
                            pushPop.Pop();
                        if (pushPop.Count() != 0)
                            return false;
                    }
                    catch
                    {
                        return false;
                    }
                    return true;
                });
            winner = System.Threading.Tasks.Task.WhenAny(testTask, timeoutTask).Result;
            if (testTask.IsCompleted && testTask.Result)
            {
                Console.WriteLine($"'Pop' Ok. (n={NumSamples}) -> {Utils.ToString(stopwatch.Elapsed.TotalSeconds, numDigits)}");
            }
            else if (testTask.IsCompleted)
            {
                Console.WriteLine($"Error. 'Pop' failed");
                return false;
            }
            else if (testTask.IsCompleted)
            {
                Console.WriteLine($"Error. 'Pop' timed out (> {timeoutSecs}s)");
                return false;
            }
            return true;
        }
    }
}