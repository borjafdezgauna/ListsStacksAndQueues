
namespace ListsStacksAndQueues
{
    public interface IPushPop<T>
    {
        string AsString();
        int Count();
        void Clear();
        void Push(T value);
        T Pop();
    }
}