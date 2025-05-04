using Microsoft.EntityFrameworkCore;
using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public class DecorRepository : IDecorRepository
    {
        MVCProjectContext _context;
        public DecorRepository(MVCProjectContext context)
        {
            _context = context;
        }

        public void Delete(Decor obj)
        {
            _context.Decors.Remove(obj);
        }

        public List<Decor> GetAll()
        {
            return _context.Decors.ToList();
        }

        public List<Decor> GetAllWithImages()
        {
            return _context.Decors
                .Include(d => d.Images) 
                .AsNoTracking() 
                .ToList();
        }

        public Decor GetById(int id)
        {
            return _context.Decors.Where(d => d.Id == id).FirstOrDefault();
        }

        public Decor GetByIdWithImages(int id)
        {
            return _context.Decors
                .Include(d => d.Images)
                .FirstOrDefault(d => d.Id == id);
        }

        public IEnumerable<Decor> SearchByName(string name)
        {
            return _context.Decors
                .Include(d => d.Images)
                .Where(d => d.Style.Contains(name))
                .AsNoTracking()
                .ToList();
        }

        public void insert(Decor obj)
        {
            _context.Decors.Add(obj);
        }

        public void Update(Decor obj)
        {
            _context.Decors.Update(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
