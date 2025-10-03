using Lists;

namespace Tests
{
    public class UnitTests
    {
        [Fact]
        public void IntListBasicTests()
        {
            Assert.True(ListTests.IntListTest(new IntList()));
        }

        [Fact]
        public void IntListEnumerator()
        {
            Assert.True(ListTests.ListEnumeratorTest(new IntList()));

        }

        [Fact]
        public void IntArrayListResize()
        {
            IntArrayList arrayList = new IntArrayList(10);
            for(int i= 0; i< 20; i++)
                arrayList.Add(i);
            Assert.Equal(20, arrayList.Count());
        }

        [Fact]
        public void IntArrayListBasicTests()
        {

            Assert.True(ListTests.IntListTest(new IntArrayList(1000000)));
        }

        [Fact]
        public void IntArrayListEnumerator()
        {
            Assert.True(ListTests.ListEnumeratorTest(new IntArrayList(1000000)));
            
        }

        [Fact]
        public void ArrayListResize()
        {

            ArrayList<int> arrayList = new ArrayList<int>(10);
            for (int i = 0; i < 20; i++)
                arrayList.Add(i);
            Assert.Equal(20, arrayList.Count());
        }
        [Fact]
        public void ListBasicTests()
        {

            Assert.True(ListTests.ListTest(new List<int>()));
        }
        [Fact]
        public void ListEnumerator()
        {
            Assert.True(ListTests.ListEnumeratorTest(new List<int>()));

        }
        [Fact]
        public void ArrayListBasicTests()
        {
            Assert.True(ListTests.ListTest(new ArrayList<int>(1000000)));
        }
        [Fact]
        public void ArrayListEnumerator()
        {
            Assert.True(ListTests.ListEnumeratorTest(new ArrayList<int>(1000000)));

        }
        [Fact]
        public void StackIntBasicTests()
        {
            int[] testIntValues = new int[] { 3, 2, 6, 1, 2 };
            Assert.True(StackAndQueuesTests.Test(new Lists.Stack<int>(), testIntValues));
        }
        [Fact]
        public void StackStringeBasicTests()
        {
            string[] testStringValues = new string[] { "aB", "0x0", "ro", "123", "hitza" };
            Assert.True(StackAndQueuesTests.Test(new Lists.Stack<string>(), testStringValues));
        }
        [Fact]
        public void QueueIntBasicTests()
        {
            int[] testIntValues = new int[] { 3, 2, 6, 1, 2 };
            Assert.True(StackAndQueuesTests.Test(new Lists.Queue<int>(), testIntValues, true));
        }
        [Fact]
        public void QueueStringBasicTests()
        {
            string[] testStringValues = new string[] { "aB", "0x0", "ro", "123", "hitza" };
            Assert.True(StackAndQueuesTests.Test(new Lists.Queue<string>(), testStringValues, true));
        }

        [Fact]
        public void ListPerformanceTests()
        {
            int[] testIntValues = new int[] { 3, 2, 6, 1, 2 };
            Assert.True(ListTests.MeasurePerformance(new List<int>(), testIntValues));
        }

        [Fact]
        public void ArrayListPerformanceTests()
        {
            int[] testIntValues = new int[] { 3, 2, 6, 1, 2 };
            Assert.True(ListTests.MeasurePerformance(new List<int>(), testIntValues));
        }

        [Fact]
        public void StackPerformanceTests()
        {
            int[] testIntValues = new int[] { 3, 2, 6, 1, 2 };
            Assert.True(StackAndQueuesTests.MeasurePerformance(new Lists.Stack<int>(), testIntValues));
        }

        [Fact]
        public void QueuePerformanceTests()
        {
            int[] testIntValues = new int[] { 3, 2, 6, 1, 2 };
            Assert.True(StackAndQueuesTests.MeasurePerformance(new Lists.Queue<int>(), testIntValues));
        }
    }
}