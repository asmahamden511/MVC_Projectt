using MVC_Projec2.Models;
using MVC_Projec2.Repository;

namespace MVC_Projec2.Repository
{
    public interface ISessionRepository:IGenericRepository<Session>
    {
        Session GetByIdWithImages(int id);

        List<Session> GetAllWithImages();

        IEnumerable<Session> SearchByName(string name);
    }
}
