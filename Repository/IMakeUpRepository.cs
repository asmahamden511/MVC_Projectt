using MVC_Projec2.Models;

namespace MVC_Projec2.Repository
{
    public interface IMakeUpRepository:IGenericRepository<MakeUp_Service>
    {
        MakeUp_Service GetByIdWithImages(int id);

        List<MakeUp_Service> GetAllWithImages();

        IEnumerable<MakeUp_Service> SearchByName(string name);
    }
}
