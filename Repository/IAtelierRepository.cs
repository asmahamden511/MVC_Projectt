using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public interface IAtelierRepository:IGenericRepository<Atelier>
    {
        Atelier GetByIdWithImages(int id);

        List<Atelier> GetAllWithImages();

        IEnumerable<Atelier> SearchByName(string name);
    }
}
