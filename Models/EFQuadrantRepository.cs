using SQLitePCL;

namespace Mission08_Team0215.Models
{
    public class EFQuadrantRepository : IQuadrantRepository
    {
        private QuadrantsContext _context;
        public EFQuadrantRepository(QuadrantsContext temp)
        {
            _context = temp;
        }

        public List<Quadrant> Quadrant => _context.Quadrants.ToList();

        public List<Quadrant> Quadrants => throw new NotImplementedException();

        public void AddManager(Quadrant manager)
        {
            throw new NotImplementedException();
        }

        public void AddQuadrant(Quadrant quadrant)
        {
            _context.Add(quadrant);
            _context.SaveChanges();

        }
    }
}
