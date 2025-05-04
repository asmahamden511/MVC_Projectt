using Microsoft.EntityFrameworkCore;
using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public class BookingRepository : IBookingReposirtory
    {
        MVCProjectContext _context;
        public BookingRepository(MVCProjectContext context)
        {
            _context = context;
        }

        public void Delete(Booking obj)
        {
            _context.Bookings.Remove(obj);
        }

        public List<Booking> GetAll()
        {
            return _context.Bookings
                  .Include(b => b.Hall)
                  .Include(b => b.Session)
                  .Include(b => b.Atelier)
                  .Include(b => b.MakeUp)
                  .Include(b => b.Decor)
                  .AsNoTracking()
                  .ToList();
        }

        public Booking GetById(int id)
        {
            return _context.Bookings
                           .Include(b => b.Hall)
                           .Include(b => b.Session)
                           .Include(b => b.Decor)
                           .Include(b => b.Atelier)
                           .Include(b => b.MakeUp)
                           .Include(b => b.user) 
                           .FirstOrDefault(b => b.Id == id);
        }


        public void insert(Booking obj)
        {
            _context.Bookings.Add(obj);
        }

        public void Update(Booking obj)
        {
            _context.Bookings.Update(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
