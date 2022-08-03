namespace DesignPatterns.State.Exercise
{
    public interface ITravelMode // the state interface
    {
        object GetEta();
        object GetDirection();
    }
}