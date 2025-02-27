namespace Mission08_Team0215.Models
{
    public interface IQuadrantRepository
    {
        List<Quadrant> Quadrants { get; }

        public void AddQuadrant(Quadrant quadrant);
        
    }
}