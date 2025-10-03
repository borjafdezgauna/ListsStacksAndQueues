using System;

namespace Lists
{
    public class ArrayList<T> : IList<T>
    {
        T[] Values = new T[10];
        int NumElements = 0;

        

        public ArrayList(int n = 10)
        {
            Values = new T[n];
            Clear();
        }
        public override string ToString()
        {
            
            string output = "[";

            for (int i = 0; i < Count(); i++)
                output += Values[i].ToString() + ",";
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
            
        }

        public int Count()
        {
            //TODO #6: return the number of elements on the list
            
            return 0;
            
        }

        public T Get(int index)
        {
            //TODO #7: return the element on the index-th position. O if the position is out of bounds
            
            return default(T);
            
        }

        public void Add(T value)
        {
            //TODO #8: add a new integer to the end of the list.
            //[After #11 -> If there is no place, resize (double the size) and add]
            
        }



        public T Remove(int index)
        {
            //TODO #9: remove the element on the index-th position. Do nothing if position is out of bounds
            //Return the removed item, -1 if the position is incorrect
            
            return default(T);
            
        }

        public void Clear()
        {
            //TODO #10: remove all the elements on the list
            
        }

        private void Resize(int newSize)
        {
            //TODO #11: return the element on the index-th position. O if the position is out of bounds
            //Once done, finish #8
            
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            //TODO #12 : Return an enumerator using "yield return" for each of the values in this list
            
            yield return null;
            
        }
    }
}