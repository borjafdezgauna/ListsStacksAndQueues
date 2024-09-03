using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsStacksAndQueues
{
    public interface IList
    {
        string AsString();

        int Count();

        int Get(int index);

        void Add(int value);

        void Remove(int index);

        void Clear();
    }
}
