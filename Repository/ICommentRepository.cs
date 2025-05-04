using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public interface ICommentRepository:IGenericRepository<Comment>
    {
        List<Comment> GetCommentsByService(int serviceId, ServiceType serviceType);
        List<Comment> GetCommentsByUser(string userId);
    }
}
