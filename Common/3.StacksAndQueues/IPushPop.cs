
namespace ListsStacksAndQueues
{
    public interface IPushPop<T>
    {
        int Count();
        void Clear();
        void Push(T value);
        T Pop();
    }
}