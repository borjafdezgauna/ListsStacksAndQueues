using System;
using System.Collections;

namespace Lists
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

    public class IntList : IIntList
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


        public int Count()
        {
            //TODO #1: return the number of elements on the list
            
            return 0;
            
        }

        
        public int Get(int index)
        {
            //TODO #2: return the element on the index-th position. O if the position is out of bounds
            
            return 0;
            
        }


        public void Add(int value)
        {
            //TODO #3: add a new integer to the end of the list
            
        }


        public int Remove(int index)
        {
            //TODO #4: remove the element on the index-th position. Do nothing if position is out of bounds
            //Return the removed item, -1 if the position is incorrect
            
            return 0;
            
        }


        public void Clear()
        {
            //TODO #5: remove all the elements on the list
            
        }

        public IEnumerator GetEnumerator()
        {
            //TODO #6 : Return an enumerator using "yield return" for each of the values in this list
            
            yield return null;
            
        }
    }
}