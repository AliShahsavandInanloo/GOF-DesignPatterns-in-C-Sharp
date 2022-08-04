namespace DesignPatterns.Iterator.Exercise
{
    public interface IIterator<out T>
    {
        bool HasNext();
        T    Current();
        void Next();
    }
}