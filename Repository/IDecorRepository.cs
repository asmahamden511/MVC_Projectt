using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public interface IDecorRepository:IGenericRepository<Decor>
    {
        Decor GetByIdWithImages(int id);

        List<Decor> GetAllWithImages();

        IEnumerable<Decor> SearchByName(string name);
    }
}
