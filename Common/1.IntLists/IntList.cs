using System;
using System.Collections;

namespace ListsStacksAndQueues
{
    public class IntListNode
    {
        public int Value;
        public IntListNode Next = null;

        public IntListNode(int value)
        {
            Value = value;
        }
    }

    public class IntList : IList
    {
        IntListNode First = null;

        //This method returns all the elements on the list as a string
        //Use it as an example on how to access all the elements on the list
        public override string ToString()
        {
            IntListNode node = First;
            string output = "[";

            while (node != null)
            {
                output += node.Value + ",";
                node = node.Next;
            }
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        
        public void Add(int value)
        {
            //TODO #1: add a new integer to the end of the list
        }

                
        public int Get(int index)
        {
            //TODO #3: return the element on the index-th position. O if the position is out of bounds
            return 0;
        }

        
        public int Count()
        {
            //TODO #4: return the number of elements on the list
            return 0;
        }
        
        public void Remove(int index)
        {
            //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
        }

        
        public void Clear()
        {
            //TODO #6: remove all the elements on the list
        }

        public IEnumerator GetEnumerator()
        {
            //TODO #7: return all items one by one using "yield return ..."
            return null;
        }
    }
}