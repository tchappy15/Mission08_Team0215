namespace Mission08_Team0215.Models
{
    public interface IQuadrantrepository
    {
        List<Quadrant> Quadrants { get; }

        public void AddManager(Quadrant manager);
    }
}