using Microsoft.EntityFrameworkCore;
using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public class SessionRepository:ISessionRepository
    {
        MVCProjectContext _context;
        public SessionRepository(MVCProjectContext context)
        {
            _context = context;
        }

        public Session GetByIdWithImages(int id)
        {
            return _context.Sessions
                .Include(a => a.Images)
                .AsNoTracking()
                .FirstOrDefault();
        }

        public List<Session> GetAllWithImages()
        {
            return _context.Sessions
                .Include(a => a.Images)
                .AsNoTracking()
                .ToList();
        }

        public void Delete(Session obj)
        {
            _context.Sessions.Remove(obj);
        }

        public List<Session> GetAll()
        {
            return _context.Sessions.ToList();
        }

        public Session GetById(int id)
        {
            return _context.Sessions.Where(s => s.Id == id).FirstOrDefault();
        }

        public IEnumerable<Session> SearchByName(string name)
        {
            return _context.Sessions
                
                .Where(s => s.Name.Contains(name))
                .AsNoTracking()
                .ToList();
        }


        public void insert(Session obj)
        {
            _context.Sessions.Add(obj);
        }

        public void Update(Session obj)
        {
            _context.Sessions.Update(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }

}
