using Microsoft.EntityFrameworkCore;
using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly MVCProjectContext _context;
        public CommentRepository(MVCProjectContext context)
        {
            _context = context;
        }

        public void Delete(Comment obj)
        {
            _context.Comments.Remove(obj);
            Save();  
        }

        public List<Comment> GetAll()
        {
            return _context.Comments.ToList(); 
        }

        public Comment GetById(int id)
        {
            return _context.Comments.Find(id); 
        }

        public List<Comment> GetCommentsByService(int serviceId, ServiceType serviceType)
        {
            return _context.Comments
                .Include(c => c.User)
                .Where(c => c.ServiceId == serviceId && c.ServiceType == serviceType)
                .OrderByDescending(c => c.CreatedAt)
                .ToList();
        }

        public List<Comment> GetCommentsByUser(string userId)
        {
            return _context.Comments
                .Include(c => c.User) 
                .Where(c => c.UserId == userId)
                .OrderByDescending(c => c.CreatedAt)
                .ToList();
        }

        public void insert(Comment comment)
        {
            _context.Comments.Add(comment);
            Save();
        }

        public void Update(Comment obj)
        {
            _context.Comments.Update(obj);
            Save();  
        }
        
        public void Save()
        {
            _context.SaveChanges(); 
        }

    }
}
