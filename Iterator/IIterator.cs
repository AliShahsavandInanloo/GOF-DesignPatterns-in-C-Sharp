namespace DesignPatterns.Iterator
{
    public interface IIterator<out T>
    {
        bool HastNext();
        T    Current();
        void Next();
    }
}