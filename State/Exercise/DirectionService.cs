namespace DesignPatterns.State.Exercise
{
    public class DirectionService // Context class
    {
        public ITravelMode TravelMode { get; set; }

        public object GetEta()
        {
            return this.TravelMode.GetEta();
        }

        public object GetDirection()
        {
            return this.TravelMode.GetDirection();
        }
    }
}