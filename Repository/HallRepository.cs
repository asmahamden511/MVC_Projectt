using Microsoft.EntityFrameworkCore;
using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public class HallRepository : IHallRepository
    {
        MVCProjectContext _context;
        public HallRepository(MVCProjectContext context)
        {
            _context = context;
        }

        public void Delete(Hall obj)
        {
            _context.Halls.Remove(obj);
        }

        public List<Hall> GetAll()
        {
           return _context.Halls.ToList();
        }

        public List<Hall> GetAllWithImages()
        {
            return _context.Halls
                .Include(h => h.Images)
                .AsNoTracking()
                .ToList();
        }

        public Hall GetById(int id)
        {
            return _context.Halls.Where(h => h.Id == id).FirstOrDefault();
        }

        public Hall GetByIdWithImages(int id)
        {
            return _context.Halls
                .Include(h => h.Images) 
                .AsNoTracking() 
                .FirstOrDefault(h => h.Id == id);
        }

        public IEnumerable<Hall> SearchByName(string name)
        {
            return _context.Halls
                .Include(h => h.Images) 
                .Where(h => h.Name.Contains(name))
                .AsNoTracking()
                .ToList();
        }

        public void insert(Hall obj)
        {
            _context.Halls.Add(obj);
        }

        public void Update(Hall obj)
        {
            _context.Halls.Update(obj);
        }
        
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
