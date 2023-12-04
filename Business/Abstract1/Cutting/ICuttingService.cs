using System.Collections.Generic;
namespace Business.Abstract1.Cutting
{
    using Entity.Concrete;
    public interface ICuttingService
    {
        void Add(Cutting cutting);
        void Delete(Cutting cutting);
        List<Cutting> GetAll();
        List<Cutting> GetCuttingByProjeID(int PROJEID);
        void Update(Cutting cutting);
    }
}
