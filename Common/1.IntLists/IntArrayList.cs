using System;
using System.Collections;

namespace ListsStacksAndQueues
{
    public class IntArrayList : IList
    {
        int[] Values;
        int NumElements = 0;

        public IntArrayList(int n)
        {
            //TODO #1: initialize Values with an array of size n
        }
        public override string ToString()
        {
            string output = "[";

            for (int i = 0; i < Count(); i++)
                output += Values[i] + ",";
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        private void Resize(int newSize)
        {
            //TODO #2: resize the array of values (Values) from the current size (NumElements) to the new one (newSize).
            //a) create a new array, b) copy already existing items, and c) update the array and number of elements of this instance
            //This method is private because it is going to be used only internally
        }

        public void Add(int value)
        {
            //TODO #3: add a new integer to the end of the list
        }

        public int Get(int index)
        {
            //TODO #4: return the element on the index-th position. O if the position is out of bounds
            return 0;
        }


        
        public int Count()
        {
            //TODO #5: return the number of elements on the list
            return 0;
        }


       
        public void Remove(int index)
        {
            //TODO #6: remove the element on the index-th position. Do nothing if position is out of bounds
        }


        public void Clear()
        {
            //TODO #7: remove all the elements on the list
        }

        public IEnumerator GetEnumerator()
        {
            //TODO #8: return all items one by one using "yield return ..."
            return null;
        }
    }
}