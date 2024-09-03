using System;
using System.Collections;
namespace ListsStacksAndQueues
{
    public class GenericArrayList<T> : IGenericList<T> where T : new()
    {
        T[] Values;
        int NumElements = 0;

        public GenericArrayList(int n)
        {
            //TODO #1: initialize Values with an array of size n
        }
        public string AsString()
        {
            string output = "[";

            for (int i = 0; i < Count(); i++)
                output += Values[i].ToString() + ",";
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        

        public void Add(T value)
        {
            //TODO #2: add a new element to the end of the list
        }

        public T Get(int index)
        {
            //TODO #3: return the element on the index-th position. Return the default value for object class T if the position is out of bounds
            
            return default(T);
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