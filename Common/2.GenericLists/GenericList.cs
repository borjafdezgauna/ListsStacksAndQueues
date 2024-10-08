using System.Collections;

namespace ListsStacksAndQueues
{

    public class GenericListNode<T>
    {
        public T Value;
        public GenericListNode<T> Next = null;

        public GenericListNode(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    public class GenericList<T> : IGenericList<T>
    {
        GenericListNode<T> First = null;
        GenericListNode<T> Last = null;

        public override string ToString()
        {
            GenericListNode<T> node = First;
            string output = "[";

            while (node != null)
            {
                output += node.ToString() + ",";
                node = node.Next;
            }
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        public void Add(T value)
        {
            //TODO #1: add a new element to the end of the list
        }

        public T Get(int index)
        {
            //TODO #2: return the element on the index-th position. YOU MUST USE FindNode(int). Return the default value for object class T if the position is out of bounds

            return default(T);
        }
        public int Count()
        {
            //TODO #3: return the number of elements on the list

            return 0;
        }


        public void Remove(int index)
        {
            //TODO #4: remove the element on the index-th position. Do nothing if position is out of bounds
        }

        public void Clear()
        {
            //TODO #5: remove all the elements on the list
        }
        public IEnumerator GetEnumerator()
        {
            //TODO #6: return all items one by one using "yield return ..."
            return null;
        }
    }
}