using System;
using System.Collections;
using System.Text;

namespace Lists
{
    public interface IIntList : System.Collections.IEnumerable
    {
        int Count();

        int Get(int index);

        void Add(int value);

        int Remove(int index);

        void Clear();
    }
}
