using System.Collections.Generic;

namespace Business.Abstract1.Plates
{
    using Entity.Concrete;
    public interface IPlatesService
    {
        void Add(Plates plates);
        void Delete(Plates plates);
        List<Plates> GetAll();
        void Update(Plates plates);
    }
}
