
using System;
using Lists;


namespace RunTestsConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("## Testing IntList class");
            if (!IntTests.IntListTest(new IntList()))
                return;

            Console.WriteLine("\n\n## Testing IntArrayList class");
            if (!IntTests.IntListTest(new IntArrayList(1000000)))
                return;

            Console.WriteLine("\n\n## Testing List class");
            if (!ListTests.ListTest(new List<int>()))
                return;

            bool listPerformancePasses = ListTests.MeasurePerformance(new List<int>(), new int[] { 1, 2, 4, 3 });

            Console.WriteLine("\n\n## Testing ArrayList class");
            if (!ListTests.ListTest(new ArrayList<int>(1000000)))
                return;

            bool listArrayPerformancePasses = ListTests.MeasurePerformance(new ArrayList<int>(), new int[] { 1, 2, 4, 3 });

            Console.WriteLine("\n\n## Testing Stack class");
            int[] testIntValues = new int[] { 3, 2, 6, 1, 2 };
            string[] testStringValues = new string[] { "aB", "0x0", "ro", "123", "hitza" };

            if (!StackAndQueuesTests.Test(new Stack<int>(), testIntValues))
                return;

            if (!StackAndQueuesTests.Test(new Stack<string>(), testStringValues))
                return;

            bool stackPerformancePasses = StackAndQueuesTests.MeasurePerformance(new Stack<int>(), testIntValues);


            Console.WriteLine("\n\n## Testing Queue class");
            if (!StackAndQueuesTests.Test(new Queue<int>(), testIntValues, true))
                return;

            if (!StackAndQueuesTests.Test(new Queue<string>(), testStringValues, true))
                return;

            bool queuePerformancePasses = StackAndQueuesTests.MeasurePerformance(new Queue<int>(), testIntValues);

            if (listPerformancePasses && listArrayPerformancePasses && stackPerformancePasses && queuePerformancePasses)
                Console.WriteLine("ASSIGNMENT FINISHED: ALL TESTS PASSED");
            else
                Console.WriteLine("ALL THE CLASSES WORK PROPERLY BUT DIDN'T PASS THE PERFORMANCE TEST");
        }
    }
}