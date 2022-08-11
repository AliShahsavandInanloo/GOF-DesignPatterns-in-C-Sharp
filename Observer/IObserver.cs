namespace DesignPatterns.Observer
{
    public interface IObserver
    {
        //void Update(int value); // the push style
        void Update(); // the pull style
    }
}