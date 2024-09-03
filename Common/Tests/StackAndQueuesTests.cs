using Common;
using System;
using System.Data.SqlTypes;
using System.Diagnostics;

namespace ListsStacksAndQueues
{
    public class StackAndQueuesTests
    {
        const int numSamples = 10000;

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
            int timeoutSecs = 10;
            Console.WriteLine($"\n# Measuring performance (n={numSamples})");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Reset();
            stopwatch.Start();
            System.Threading.Tasks.Task timeoutTask = System.Threading.Tasks.Task.Delay(timeoutSecs * 1000);
            System.Threading.Tasks.Task<bool> testTask = System.Threading.Tasks.Task.Factory.StartNew(
                () =>
                {
                    try
                    {
                        //Push
                        for (int i = 0; i < numSamples; i++)
                            pushPop.Push(initialValues[i % initialValues.Length]);
                        return pushPop.Count() == numSamples;
                    }
                    catch
                    {
                        return false;
                    }
                });

            var winner = System.Threading.Tasks.Task.WhenAny(testTask, timeoutTask).Result;
            if (testTask == winner && testTask.Result)
            {
                Console.WriteLine($"Ok. Push (n={numSamples}) -> {Utils.ToString(stopwatch.Elapsed.TotalSeconds, numDigits)}");
            }
            else
            {
                Console.WriteLine("Error. The task timed out (> 30s)");
                return false;
            }
            //Add again n elements
            for (int i = 0; i < numSamples; i++)
                pushPop.Push(initialValues[i % initialValues.Length]);

            //Remove first element
            stopwatch.Reset();
            stopwatch.Start();
            timeoutTask = System.Threading.Tasks.Task.Delay(timeoutSecs * 1000);
            testTask = System.Threading.Tasks.Task.Factory.StartNew(
                () =>
                {
                    try
                    {
                        for (int i = 0; i < numSamples; i++)
                            pushPop.Pop();
                        return pushPop.Count() == 0;
                    }
                    catch
                    {
                        return false;
                    }
                });
            winner = System.Threading.Tasks.Task.WhenAny(testTask, timeoutTask).Result;
            if (testTask.IsCompleted && testTask.Result)
            {
                Console.WriteLine($"Ok. Pop (n={numSamples}) -> {Utils.ToString(stopwatch.Elapsed.TotalSeconds, numDigits)} s");
                return true;
            }
            else
            {
                Console.WriteLine("Error. The task timed out (> 30s)");
                return false;
            }

        }
    }
}