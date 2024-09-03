using ListsStacksAndQueues;

namespace Tests
{
    public class UnitTests
    {
        [Fact]
        public void IntListBasicTests()
        {
            Assert.True(IntTests.IntListTest(new IntList()));
        }
        [Fact]
        public void ArrayListBasicTests()
        {

            Assert.True(IntTests.IntListTest(new IntArrayList(1000000)));
        }
        [Fact]
        public void GenericListBasicTests()
        {

            Assert.True(IntTests.GenericListTest(new GenericList<int>()));
        }
        [Fact]
        public void GenericArrayListBasicTests()
        {
            Assert.True(IntTests.GenericListTest(new GenericArrayList<int>(1000000)));
        }

        [Fact]
        public void GenericStackIntBasicTests()
        {
            int[] testIntValues = new int[] { 3, 2, 6, 1, 2 };
            Assert.True(StackAndQueuesTests.Test(new GenericStack<int>(), testIntValues));
        }
        [Fact]
        public void GenericStackStringeBasicTests()
        {
            string[] testStringValues = new string[] { "aB", "0x0", "ro", "123", "hitza" };
            Assert.True(StackAndQueuesTests.Test(new GenericStack<string>(), testStringValues));
        }
        [Fact]
        public void GenericQueueIntBasicTests()
        {
            int[] testIntValues = new int[] { 3, 2, 6, 1, 2 };
            Assert.True(StackAndQueuesTests.Test(new GenericQueue<int>(), testIntValues, true));
        }
        [Fact]
        public void GenericQueueStringBasicTests()
        {
            string[] testStringValues = new string[] { "aB", "0x0", "ro", "123", "hitza" };
            Assert.True(StackAndQueuesTests.Test(new GenericQueue<string>(), testStringValues, true));
        }

        [Fact]
        public void GenericStackPerformanceTests()
        {
            int[] testIntValues = new int[] { 3, 2, 6, 1, 2 };
            Assert.True(StackAndQueuesTests.MeasurePerformance(new GenericStack<int>(), testIntValues));
        }

        [Fact]
        public void GenericQueuePerformanceTests()
        {
            int[] testIntValues = new int[] { 3, 2, 6, 1, 2 };
            Assert.True(StackAndQueuesTests.MeasurePerformance(new GenericQueue<int>(), testIntValues));
        }
    }
}