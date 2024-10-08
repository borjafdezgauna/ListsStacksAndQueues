using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsStacksAndQueues
{
    public interface IGenericList<T> : IEnumerable
    {
        int Count();

        T Get(int index);

        void Add(T value);

        void Remove(int index);

        void Clear();
    }
}
